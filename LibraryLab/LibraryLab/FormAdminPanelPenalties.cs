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
    public partial class FormAdminPanelPenalties : Form
    {

        private static FormAdminPanelPenalties f;
        public static FormAdminPanelPenalties fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormAdminPanelPenalties();
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

        public FormAdminPanelPenalties()
        {
            InitializeComponent();
        }

        private void penaltiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.penaltiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void FormAdminPanelPenalties_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Penalties". При необходимости она может быть перемещена или удалена.
            this.penaltiesTableAdapter.Fill(this.libraryDataSet.Penalties);

        }

        private void buttonShowPenalties_Click(object sender, EventArgs e)
        {
            dataGridViewPenalties.DataSource = FillDataGridView("SELECT * FROM Penalties");

            if (dataGridViewPenalties.Columns.Contains("PenaltyID"))
                dataGridViewPenalties.Columns["PenaltyID"].HeaderText = "Код пени";
            if (dataGridViewPenalties.Columns.Contains("IssueID"))
                dataGridViewPenalties.Columns["IssueID"].HeaderText = "ID выдачи";
            if (dataGridViewPenalties.Columns.Contains("PenaltyAmount"))
                dataGridViewPenalties.Columns["PenaltyAmount"].HeaderText = "Сумма";
            if (dataGridViewPenalties.Columns.Contains("CalculatedOn"))
                dataGridViewPenalties.Columns["CalculatedOn"].HeaderText = "Дата начисления";
        }

        private void buttonExecuteDML_Click(object sender, EventArgs e)
        {
            if (radioButtonAddPenalty.Checked)
                InsertPenalty();
            else if (radioButtonUpdatePenalty.Checked)
                UpdatePenalty();
            else if (radioButtonDeletePenalty.Checked)
                DeletePenalty();
            else
                MessageBox.Show("Вы не выбрали действие", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }



        void DeletePenalty()
        {
            if (string.IsNullOrWhiteSpace(penaltyIDTextBox.Text))
            {
                MessageBox.Show("Укажите ID пени для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int penaltyId;
            if (!int.TryParse(penaltyIDTextBox.Text, out penaltyId))
            {
                MessageBox.Show("Некорректный ID пени!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlDelete = "DELETE FROM Penalties WHERE PenaltyID = @PenaltyID";

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.LibraryConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlDelete, connection);
                command.Parameters.AddWithValue("@PenaltyID", penaltyId);

                try
                {
                    int rows = command.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Пеня удалена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Пеня с таким ID не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        void UpdatePenalty()
        {
            if (string.IsNullOrWhiteSpace(penaltyIDTextBox.Text))
            {
                MessageBox.Show("Укажите ID пени для обновления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int penaltyId;
            if (!int.TryParse(penaltyIDTextBox.Text, out penaltyId))
            {
                MessageBox.Show("Некорректный ID пени!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlUpdate = "UPDATE Penalties SET {0} WHERE PenaltyID = @PenaltyID";
            string sqlValues = "";

            if (!string.IsNullOrWhiteSpace(issueIDTextBox.Text))
                sqlValues += "IssueID = @IssueID, ";
            if (!string.IsNullOrWhiteSpace(penaltyAmountTextBox.Text))
                sqlValues += "PenaltyAmount = @PenaltyAmount, ";

            sqlValues += "CalculatedOn = @CalculatedOn, ";

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

                SqlCommand command = new SqlCommand(string.Format(sqlUpdate, sqlValues), connection);
                command.Parameters.AddWithValue("@PenaltyID", penaltyId);

                if (sqlValues.Contains("IssueID"))
                {
                    int issueId;
                    if (int.TryParse(issueIDTextBox.Text, out issueId))
                        command.Parameters.AddWithValue("@IssueID", issueId);
                    else
                    {
                        MessageBox.Show("Некорректный IssueID!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (sqlValues.Contains("PenaltyAmount"))
                {
                    decimal penaltyAmount;
                    if (decimal.TryParse(penaltyAmountTextBox.Text, out penaltyAmount))
                        command.Parameters.AddWithValue("@PenaltyAmount", penaltyAmount);
                    else
                    {
                        MessageBox.Show("Некорректная сумма!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                command.Parameters.AddWithValue("@CalculatedOn", calculatedOnDateTimePicker.Value);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Пеня обновлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при обновлении.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        void InsertPenalty()
        {
            if (string.IsNullOrWhiteSpace(issueIDTextBox.Text) ||
                string.IsNullOrWhiteSpace(penaltyAmountTextBox.Text))
            {
                MessageBox.Show("Укажите ID выдачи и сумму пени.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int issueId;
            if (!int.TryParse(issueIDTextBox.Text, out issueId))
            {
                MessageBox.Show("Некорректный ID выдачи!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal penaltyAmount;
            if (!decimal.TryParse(penaltyAmountTextBox.Text, out penaltyAmount))
            {
                MessageBox.Show("Некорректная сумма пени!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime calculatedOn = calculatedOnDateTimePicker.Value;

            string sqlInsert = @"
        INSERT INTO Penalties (IssueID, PenaltyAmount, CalculatedOn)
        VALUES (@IssueID, @PenaltyAmount, @CalculatedOn)";

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.LibraryConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlInsert, connection);
                command.Parameters.AddWithValue("@IssueID", issueId);
                command.Parameters.AddWithValue("@PenaltyAmount", penaltyAmount);
                command.Parameters.AddWithValue("@CalculatedOn", calculatedOn);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Пеня успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении пени.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
