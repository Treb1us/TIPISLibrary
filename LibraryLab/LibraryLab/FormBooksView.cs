using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryLab
{
    public partial class FormBooksView : Form
    {
     private static FormBooksView f;
        public static FormBooksView fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormBooksView();
                return f;
            }
        }
        public FormBooksView()
        {
            InitializeComponent();
        }

        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void booksBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void booksBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void booksBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void FormBooksView_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.libraryDataSet.Books);

        }

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxFind.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int indexPos;
            try
            {
                indexPos = booksBindingSource.Find(GetSelectedFieldName(), toolStripTextBoxFind.Text);

            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }

            if (indexPos > -1)
            {
                booksBindingSource.Position = indexPos;
            }
            else
            {
                MessageBox.Show("Такая книга не найдена", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                booksBindingSource.Position = 0;
            }

        }
        string GetSelectedFieldName()
        {
            return
           booksDataGridView.Columns[booksDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }

        private void checkBoxFind_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFind.Checked)
            {
                if (toolStripTextBoxFind.Text == "")
                {
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        booksBindingSource.Filter = GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" + err.Message);
                    }
                }
            }
            else
            {
                // Сброс фильтра
                booksBindingSource.Filter = "";
            }

            if (booksBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких записей");
                booksBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }
        }
        public void ShowForm()
        {
            booksBindingSource.Position = 0;
            Show();
            Activate();
        }
    }
}
