using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryLab
{
    public partial class FormAdminPanelUsers : Form
    {

        private static FormAdminPanelUsers f;
        public static FormAdminPanelUsers fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormAdminPanelUsers();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }
        //объявляем метод, на вход подаем строку запроса, а возвращаем объект DataTable
        DataTable FillDataGridView(string sqlSelect)
        {
            //Создаем объект connection класса SqlConnection для соединения с БД
            //CafeConnectionString – строка описания соединения с источникомданных

            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.LibraryConnectionString);
            //Создаем объект command для SQL команды
            SqlCommand command = connection.CreateCommand();
            //Заносим текст SQL запроса через параметр sqlSelect
            command.CommandText = sqlSelect;
            //Создаем объект adapter класса SqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Задаем адаптеру нужную команду, в данном случае команду Select
            adapter.SelectCommand = command;
            //Создаем объект table для последующего отображения результата
            DataTable table = new DataTable();
            //заполним набор данных результатом запроса
            adapter.Fill(table);
            return table;
        }

        public FormAdminPanelUsers()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void FormAdminPanel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.libraryDataSet.Users);

        }

        private void buttonShowUsers_Click(object sender, EventArgs e)
        {
            // Загружаем всех пользователей
            dataGridViewUsers.DataSource = FillDataGridView("SELECT * FROM Users");

            // Устанавливаем заголовки столбцов (если нужно)
            if (dataGridViewUsers.Columns.Contains("UserID"))
                dataGridViewUsers.Columns["UserID"].HeaderText = "Код пользователя";
            if (dataGridViewUsers.Columns.Contains("FullName"))
                dataGridViewUsers.Columns["FullName"].HeaderText = "ФИО";
            if (dataGridViewUsers.Columns.Contains("StudentID"))
                dataGridViewUsers.Columns["StudentID"].HeaderText = "Номер студенческого";
            if (dataGridViewUsers.Columns.Contains("BirthDate"))
                dataGridViewUsers.Columns["BirthDate"].HeaderText = "Дата рождения";
            if (dataGridViewUsers.Columns.Contains("CardIssueDate"))
                dataGridViewUsers.Columns["CardIssueDate"].HeaderText = "Выдан";
            if (dataGridViewUsers.Columns.Contains("CardExpiryDate"))
                dataGridViewUsers.Columns["CardExpiryDate"].HeaderText = "Истекает";
            if (dataGridViewUsers.Columns.Contains("Status"))
                dataGridViewUsers.Columns["Status"].HeaderText = "Статус";
        }


        private void buttonExecuteDML_Click(object sender, EventArgs e)
        {
            if (radioButtonAddUser.Checked)
                InsertUser();
            else if (radioButtonUpdateUser.Checked)
                UpdateUser();
            else if (radioButtonDeleteUser.Checked)
                DeleteUser();
            else
                MessageBox.Show("Вы не выбрали действие", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void radioButtonAddStuff_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonCodeChange_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonCodeDelete_CheckedChanged(object sender, EventArgs e)
        {

        }


        void InsertUser()
        {
            // Проверка обязательных полей
            if (string.IsNullOrWhiteSpace(fullNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(studentIDTextBox.Text) ||
                string.IsNullOrWhiteSpace(statusTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля: ФИО, Номер студенческого, Статус.",
                                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime birthDate = birthDateDateTimePicker.Value;
            DateTime issueDate = cardIssueDateDateTimePicker.Value;
            DateTime expiryDate = cardExpiryDateDateTimePicker.Value;

            string sqlInsert = @"
        INSERT INTO Users (FullName, StudentID, BirthDate, CardIssueDate, CardExpiryDate, Status)
        VALUES (@FullName, @StudentID, @BirthDate, @CardIssueDate, @CardExpiryDate, @Status)";

            SqlConnection connection = new SqlConnection(Properties.Settings.Default.LibraryConnectionString);
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;

            command.Parameters.AddWithValue("@FullName", fullNameTextBox.Text);
            command.Parameters.AddWithValue("@StudentID", studentIDTextBox.Text);
            command.Parameters.AddWithValue("@BirthDate", birthDate);
            command.Parameters.AddWithValue("@CardIssueDate", issueDate);
            command.Parameters.AddWithValue("@CardExpiryDate", expiryDate);
            command.Parameters.AddWithValue("@Status", statusTextBox.Text);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Пользователь успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении пользователя.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        void UpdateUser()
        {
            if (string.IsNullOrWhiteSpace(userIDTextBox.Text))
            {
                MessageBox.Show("Укажите ID пользователя для обновления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId;
            if (!int.TryParse(userIDTextBox.Text, out userId))
            {
                MessageBox.Show("Некорректное значение ID!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlUpdate = "UPDATE Users SET {0} WHERE UserID = @UserID";
            string sqlValues = "";

            if (!string.IsNullOrWhiteSpace(fullNameTextBox.Text))
                sqlValues += "FullName = @FullName, ";
            if (!string.IsNullOrWhiteSpace(studentIDTextBox.Text))
                sqlValues += "StudentID = @StudentID, ";
            sqlValues += "BirthDate = @BirthDate, CardIssueDate = @CardIssueDate, CardExpiryDate = @CardExpiryDate, ";
            if (!string.IsNullOrWhiteSpace(statusTextBox.Text))
                sqlValues += "Status = @Status, ";

            if (sqlValues.EndsWith(", "))
                sqlValues = sqlValues.Remove(sqlValues.Length - 2);

            if (string.IsNullOrEmpty(sqlValues))
            {
                MessageBox.Show("Нет данных для обновления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection connection = new SqlConnection(Properties.Settings.Default.LibraryConnectionString);
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = string.Format(sqlUpdate, sqlValues);

            command.Parameters.AddWithValue("@UserID", userId);
            if (sqlValues.Contains("FullName"))
                command.Parameters.AddWithValue("@FullName", fullNameTextBox.Text);
            if (sqlValues.Contains("StudentID"))
                command.Parameters.AddWithValue("@StudentID", studentIDTextBox.Text);
            if (sqlValues.Contains("Status"))
                command.Parameters.AddWithValue("@Status", statusTextBox.Text);

            command.Parameters.AddWithValue("@BirthDate", birthDateDateTimePicker.Value);
            command.Parameters.AddWithValue("@CardIssueDate", cardIssueDateDateTimePicker.Value);
            command.Parameters.AddWithValue("@CardExpiryDate", cardExpiryDateDateTimePicker.Value);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Пользователь обновлён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }


        void DeleteUser()
        {
            if (string.IsNullOrWhiteSpace(userIDTextBox.Text))
            {
                MessageBox.Show("Укажите ID пользователя для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId;
            if (!int.TryParse(userIDTextBox.Text, out userId))
            {
                MessageBox.Show("Некорректный ID!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlDelete = "DELETE FROM Users WHERE UserID = @UserID";

            SqlConnection connection = new SqlConnection(Properties.Settings.Default.LibraryConnectionString);
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlDelete;
            command.Parameters.AddWithValue("@UserID", userId);

            try
            {
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                    MessageBox.Show("Пользователь удалён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Пользователь с таким ID не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }



    }
}
