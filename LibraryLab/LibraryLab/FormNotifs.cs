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
    public partial class FormNotifs : Form
    {

        private static FormNotifs f;
        public static FormNotifs fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormNotifs();
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


        public FormNotifs()
        {
            InitializeComponent();
        }


        private void radioButtonRent_CheckedChanged(object sender, EventArgs e)
        {
            int userId;
            if (!int.TryParse(textBoxUserID.Text, out userId))
            {
                MessageBox.Show("Введите корректный числовой ID.");
                return;
            }

                        string query = @"
                SELECT 
                    u.UserID AS [Код пользователя],
                    u.FullName AS [ФИО],
                    b.Title AS [Название книги],
                    bi.IssueDate AS [Дата выдачи],
                    bi.DueDate AS [Дата возврата],
                    CASE
                        WHEN u.Status = 'Заблокирован' THEN
                            'Для разблокировки, обратитесь к администратору лично со всеми долгами.'
                        WHEN DATEDIFF(DAY, GETDATE(), bi.DueDate) <= 3 AND DATEDIFF(DAY, GETDATE(), bi.DueDate) >= 0 THEN
                            'Поторопитесь!'
                        WHEN DATEDIFF(DAY, GETDATE(), bi.DueDate) > 3 THEN
                            'Не забудьте вернуть книгу вовремя!'
                        ELSE 
                            'Срок возврата уже истёк!'
                    END AS [Сообщение]
                FROM Users u
                LEFT JOIN BookIssues bi ON u.UserID = bi.UserID
                LEFT JOIN Books b ON bi.BookID = b.BookID
                WHERE u.UserID = " + userId + " AND bi.ReturnDate IS NULL";

                        dataGridViewNotifs.DataSource = FillDataGridView(query);
        }

        private void radioButtonPenalties_CheckedChanged(object sender, EventArgs e)
        {
            int userId;
            if (!int.TryParse(textBoxUserID.Text, out userId))
            {
                MessageBox.Show("Введите корректный числовой ID.");
                return;
            }

                            string query = string.Format(@"
                    SELECT 
                        u.UserID AS [Код пользователя],
                        u.FullName AS [ФИО],
                        b.Title AS [Название книги],
                        sr.RequestDate AS [Дата запроса],
                        CASE 
                            WHEN sr.Status = 'Готов' THEN sr.ReadyDate 
                            ELSE NULL 
                        END AS [Дата готовности],
                        sr.Status AS [Статус заявки],
                        CASE 
                            WHEN sr.Status = 'Ожидает' THEN 'Ваша заявка ещё не была обработана'
                            WHEN sr.Status = 'Готов' THEN 'Ваша книга готова к выдаче!'
                        END AS [Сообщение]
                    FROM StorageRequests sr
                    LEFT JOIN Users u ON sr.UserID = u.UserID
                    LEFT JOIN Books b ON sr.BookID = b.BookID
                    WHERE sr.UserID = {0} AND sr.Status IN ('Ожидает', 'Готов')", userId);

                            dataGridViewNotifs.DataSource = FillDataGridView(query);

        }

        private void FormNotifs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.BookIssues". При необходимости она может быть перемещена или удалена.
            this.bookIssuesTableAdapter.Fill(this.libraryDataSet.BookIssues);

        }

        private void radioButtonPenalties_CheckedChanged_1(object sender, EventArgs e)
        {
            int userId;
            if (!int.TryParse(textBoxUserID.Text, out userId))
            {
                MessageBox.Show("Введите корректный числовой ID.");
                return;
            }

                    string query = string.Format(@"
            SELECT 
                u.UserID AS [Код пользователя],
                u.FullName AS [ФИО],
                ISNULL(SUM(p.PenaltyAmount), 0) AS [Общая задолженность],
                CASE 
                    WHEN SUM(p.PenaltyAmount) IS NULL OR SUM(p.PenaltyAmount) = 0 THEN 
                        'У вас долгов нет, спасибо за опрятность!'
                    ELSE 
                        'Пожалуйста, обратитесь к администратору для погашения долга'
                END AS [Сообщение]
            FROM Users u
            LEFT JOIN BookIssues bi ON u.UserID = bi.UserID
            LEFT JOIN Penalties p ON bi.IssueID = p.IssueID
            WHERE u.UserID = {0}
            GROUP BY u.UserID, u.FullName", userId);

                    dataGridViewNotifs.DataSource = FillDataGridView(query);

        }



    }
}
