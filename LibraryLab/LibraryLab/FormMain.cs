using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryLab.Properties;

namespace LibraryLab
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void FormClosing_Main(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?",
           "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
           DialogResult.Yes;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР, КСУП\n Дорофеев Дмитрий Сергеевич\n группа 522, 2025", "О программе",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        private void Main_Books_Click(object sender, EventArgs e)
        {
            FormBooksView.fw.ShowForm();
        }

        private void Main_OwnedBooks_Click(object sender, EventArgs e)
        {
            FormMyBooks.fw.ShowForm();
        }

        private void Main_Orders_Click(object sender, EventArgs e)
        {
            FormAddOrder.fw.ShowForm();
        }

        private void Main_notifications_Click(object sender, EventArgs e)
        {
            FormNotifs.fd.ShowForm();
        }

        private void администраторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminPanel.fw.ShowForm();
        }
    }
}
