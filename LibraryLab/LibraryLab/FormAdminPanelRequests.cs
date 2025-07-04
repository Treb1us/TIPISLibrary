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
    public partial class FormAdminPanelRequests : Form
    {

        private static FormAdminPanelRequests f;
        public static FormAdminPanelRequests fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormAdminPanelRequests();
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

        public FormAdminPanelRequests()
        {
            InitializeComponent();
        }

        private void storageRequestsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.storageRequestsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void FormAdminPanelIssues_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.StorageRequests". При необходимости она может быть перемещена или удалена.
            this.storageRequestsTableAdapter.Fill(this.libraryDataSet.StorageRequests);

        }

        private void buttonExecuteDML_Click(object sender, EventArgs e)
        {
            if (radioButtonAddRequest.Checked)
                InsertStorageRequest();
            else if (radioButtonUpdateRequest.Checked)
                UpdateStorageRequest();
            else if (radioButtonDeleteRequest.Checked)
                DeleteStorageRequest();
            else
                MessageBox.Show("Вы не выбрали действие", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void buttonShowRequests_Click(object sender, EventArgs e)
        {
            dataGridViewRequests.DataSource = FillDataGridView("SELECT * FROM StorageRequests");

            if (dataGridViewRequests.Columns.Contains("RequestID"))
                dataGridViewRequests.Columns["RequestID"].HeaderText = "Код заявки";
            if (dataGridViewRequests.Columns.Contains("UserID"))
                dataGridViewRequests.Columns["UserID"].HeaderText = "Код пользователя";
            if (dataGridViewRequests.Columns.Contains("BookID"))
                dataGridViewRequests.Columns["BookID"].HeaderText = "Код книги";
            if (dataGridViewRequests.Columns.Contains("RequestDate"))
                dataGridViewRequests.Columns["RequestDate"].HeaderText = "Дата запроса";
            if (dataGridViewRequests.Columns.Contains("ReadyDate"))
                dataGridViewRequests.Columns["ReadyDate"].HeaderText = "Готовность";
            if (dataGridViewRequests.Columns.Contains("Status"))
                dataGridViewRequests.Columns["Status"].HeaderText = "Статус";
        }



        void DeleteStorageRequest()
        {
            if (string.IsNullOrWhiteSpace(requestIDTextBox.Text))
            {
                MessageBox.Show("Укажите ID заявки для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int requestId;
            if (!int.TryParse(requestIDTextBox.Text, out requestId))
            {
                MessageBox.Show("Некорректный ID!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlDelete = "DELETE FROM StorageRequests WHERE RequestID = @RequestID";

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.LibraryConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = sqlDelete;
                command.Parameters.AddWithValue("@RequestID", requestId);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        MessageBox.Show("Заявка удалена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Заявка с таким ID не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        void UpdateStorageRequest()
        {
            if (string.IsNullOrWhiteSpace(requestIDTextBox.Text))
            {
                MessageBox.Show("Укажите ID заявки для изменения.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int requestId;
            if (!int.TryParse(requestIDTextBox.Text, out requestId))
            {
                MessageBox.Show("Некорректный ID заявки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlUpdate = "UPDATE StorageRequests SET {0} WHERE RequestID = @RequestID";
            string sqlValues = "";

            if (!string.IsNullOrWhiteSpace(userIDTextBox.Text))
                sqlValues += "UserID = @UserID, ";
            if (!string.IsNullOrWhiteSpace(bookIDTextBox.Text))
                sqlValues += "BookID = @BookID, ";
            sqlValues += "RequestDate = @RequestDate, ReadyDate = @ReadyDate, ";
            if (!string.IsNullOrWhiteSpace(statusComboBox.Text))
                sqlValues += "Status = @Status, ";

            if (sqlValues.EndsWith(", "))
                sqlValues = sqlValues.Remove(sqlValues.Length - 2);

            if (string.IsNullOrEmpty(sqlValues))
            {
                MessageBox.Show("Нет данных для обновления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.LibraryConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = string.Format(sqlUpdate, sqlValues);

                command.Parameters.AddWithValue("@RequestID", requestId);
                if (sqlValues.Contains("UserID"))
                    command.Parameters.AddWithValue("@UserID", int.Parse(userIDTextBox.Text));
                if (sqlValues.Contains("BookID"))
                    command.Parameters.AddWithValue("@BookID", int.Parse(bookIDTextBox.Text));
                if (sqlValues.Contains("Status"))
                    command.Parameters.AddWithValue("@Status", statusComboBox.Text);

                command.Parameters.AddWithValue("@RequestDate", requestDateDateTimePicker.Value);
                command.Parameters.AddWithValue("@ReadyDate",
                    readyDateDateTimePicker.Checked ? (object)readyDateDateTimePicker.Value : DBNull.Value);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Заявка обновлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при обновлении заявки.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        void InsertStorageRequest()
        {
            if (string.IsNullOrWhiteSpace(userIDTextBox.Text) ||
                string.IsNullOrWhiteSpace(bookIDTextBox.Text) ||
                string.IsNullOrWhiteSpace(statusComboBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните обязательные поля: UserID, BookID, Статус.", "Внимание",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId, bookId;
            if (!int.TryParse(userIDTextBox.Text, out userId) ||
                !int.TryParse(bookIDTextBox.Text, out bookId))
            {
                MessageBox.Show("Некорректный формат ID!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string status = statusComboBox.Text;
            DateTime requestDate = requestDateDateTimePicker.Value;
            DateTime? readyDate = readyDateDateTimePicker.Checked ? (DateTime?)readyDateDateTimePicker.Value : null;

            string sqlInsert = @"
        INSERT INTO StorageRequests (UserID, BookID, RequestDate, ReadyDate, Status)
        VALUES (@UserID, @BookID, @RequestDate, @ReadyDate, @Status)";

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.LibraryConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlInsert, connection);

                command.Parameters.AddWithValue("@UserID", userId);
                command.Parameters.AddWithValue("@BookID", bookId);
                command.Parameters.AddWithValue("@RequestDate", requestDate);
                command.Parameters.AddWithValue("@Status", status);
                if (readyDate.HasValue)
                    command.Parameters.AddWithValue("@ReadyDate", readyDate);
                else
                    command.Parameters.AddWithValue("@ReadyDate", DBNull.Value);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Заявка успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении заявки.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
