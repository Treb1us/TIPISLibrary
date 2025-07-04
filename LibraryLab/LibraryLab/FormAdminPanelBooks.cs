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
    public partial class FormAdminPanelBooks : Form
    {

        private static FormAdminPanelBooks f;
        public static FormAdminPanelBooks fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormAdminPanelBooks();
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

        public FormAdminPanelBooks()
        {
            InitializeComponent();
        }

        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void FormAdminPanelBooks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.libraryDataSet.Books);

        }
        private void buttonExecuteDML_Click(object sender, EventArgs e)
        {
            if (radioButtonAddBook.Checked)
                InsertBook();
            else if (radioButtonUpdateBook.Checked)
                UpdateBook();
            else if (radioButtonDeleteBook.Checked)
                DeleteBook();
            else
                MessageBox.Show("Вы не выбрали действие", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void buttonShowBooks_Click(object sender, EventArgs e)
        {
            dataGridViewBooks.DataSource = FillDataGridView("SELECT * FROM Books");

            if (dataGridViewBooks.Columns.Contains("BookID"))
                dataGridViewBooks.Columns["BookID"].HeaderText = "Код книги";
            if (dataGridViewBooks.Columns.Contains("Title"))
                dataGridViewBooks.Columns["Title"].HeaderText = "Название";
            if (dataGridViewBooks.Columns.Contains("Author"))
                dataGridViewBooks.Columns["Author"].HeaderText = "Автор";
            if (dataGridViewBooks.Columns.Contains("Cipher"))
                dataGridViewBooks.Columns["Cipher"].HeaderText = "Шифр";
            if (dataGridViewBooks.Columns.Contains("Location"))
                dataGridViewBooks.Columns["Location"].HeaderText = "Местоположение";
            if (dataGridViewBooks.Columns.Contains("AvailableCopies"))
                dataGridViewBooks.Columns["AvailableCopies"].HeaderText = "Доступно экземпляров";
        }
        void InsertBook()
        {
            if (string.IsNullOrWhiteSpace(titleTextBox.Text) ||
                string.IsNullOrWhiteSpace(authorTextBox.Text) ||
                string.IsNullOrWhiteSpace(cipherTextBox.Text) ||
                string.IsNullOrWhiteSpace(locationTextBox.Text))
            {
                MessageBox.Show("Заполните все обязательные поля: Название, Автор, Шифр, Местоположение.",
                                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int availableCopies = 0;
            if (!int.TryParse(availableCopiesTextBox.Text, out availableCopies))
            {
                MessageBox.Show("Некорректное значение количества экземпляров!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlInsert = @"
        INSERT INTO Books (Title, Author, Cipher, Location, AvailableCopies)
        VALUES (@Title, @Author, @Cipher, @Location, @AvailableCopies)";

            SqlConnection connection = new SqlConnection(Properties.Settings.Default.LibraryConnectionString);
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;

            command.Parameters.AddWithValue("@Title", titleTextBox.Text);
            command.Parameters.AddWithValue("@Author", authorTextBox.Text);
            command.Parameters.AddWithValue("@Cipher", cipherTextBox.Text);
            command.Parameters.AddWithValue("@Location", locationTextBox.Text);
            command.Parameters.AddWithValue("@AvailableCopies", availableCopies);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Книга добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении книги.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        void UpdateBook()
        {
            if (string.IsNullOrWhiteSpace(bookIDTextBox.Text))
            {
                MessageBox.Show("Укажите ID книги.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bookId;
            if (!int.TryParse(bookIDTextBox.Text, out bookId))
            {
                MessageBox.Show("Некорректный ID книги!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlUpdate = "UPDATE Books SET {0} WHERE BookID = @BookID";
            string sqlValues = "";

            if (!string.IsNullOrWhiteSpace(titleTextBox.Text))
                sqlValues += "Title = @Title, ";
            if (!string.IsNullOrWhiteSpace(authorTextBox.Text))
                sqlValues += "Author = @Author, ";
            if (!string.IsNullOrWhiteSpace(cipherTextBox.Text))
                sqlValues += "Cipher = @Cipher, ";
            if (!string.IsNullOrWhiteSpace(locationTextBox.Text))
                sqlValues += "Location = @Location, ";
            if (!string.IsNullOrWhiteSpace(availableCopiesTextBox.Text))
                sqlValues += "AvailableCopies = @AvailableCopies, ";

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

            command.Parameters.AddWithValue("@BookID", bookId);
            if (sqlValues.Contains("Title"))
                command.Parameters.AddWithValue("@Title", titleTextBox.Text);
            if (sqlValues.Contains("Author"))
                command.Parameters.AddWithValue("@Author", authorTextBox.Text);
            if (sqlValues.Contains("Cipher"))
                command.Parameters.AddWithValue("@Cipher", cipherTextBox.Text);
            if (sqlValues.Contains("Location"))
                command.Parameters.AddWithValue("@Location", locationTextBox.Text);
            if (sqlValues.Contains("AvailableCopies"))
            {
                int availableCopies;
                if (!int.TryParse(availableCopiesTextBox.Text, out availableCopies))
                {
                    MessageBox.Show("Некорректное значение количества экземпляров!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    connection.Close();
                    return;
                }
                command.Parameters.AddWithValue("@AvailableCopies", availableCopies);
            }

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Книга обновлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        void DeleteBook()
        {
            if (string.IsNullOrWhiteSpace(bookIDTextBox.Text))
            {
                MessageBox.Show("Укажите ID книги.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bookId;
            if (!int.TryParse(bookIDTextBox.Text, out bookId))
            {
                MessageBox.Show("Некорректный ID!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlDelete = "DELETE FROM Books WHERE BookID = @BookID";

            SqlConnection connection = new SqlConnection(Properties.Settings.Default.LibraryConnectionString);
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlDelete;
            command.Parameters.AddWithValue("@BookID", bookId);

            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                    MessageBox.Show("Книга удалена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Книга с таким ID не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
