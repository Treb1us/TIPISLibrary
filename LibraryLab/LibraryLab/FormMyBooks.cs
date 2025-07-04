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
    public partial class FormMyBooks : Form
    {
        private static FormMyBooks f;
        public static FormMyBooks fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormMyBooks();
                return f;
            }
        }
        public FormMyBooks()
        {
            InitializeComponent();
        }

        private void bookIssuesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookIssuesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void FormMyBooks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.BookIssues". При необходимости она может быть перемещена или удалена.
            this.bookIssuesTableAdapter.Fill(this.libraryDataSet.BookIssues);

        }

        private void toolStripTextBoxUserID_TextChanged(object sender, EventArgs e)
        {
            bookIssuesBindingSource.Filter = "UserID" + "='" + toolStripTextBoxUserID.Text + "'";
        }
                public void ShowForm()
        {
            bookIssuesBindingSource.Position = 0;
            Show();
            Activate();
        }
    }
}
