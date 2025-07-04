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
    public partial class FormAdminPanel : Form
    {
        private static FormAdminPanel f;
        public static FormAdminPanel fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormAdminPanel();
                return f;
            }
        }
        public FormAdminPanel()
        {
            InitializeComponent();
        }

        private void buttonToUsers_Click(object sender, EventArgs e)
        {
            FormAdminPanelUsers.fd.ShowForm();
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void buttonToBooks_Click(object sender, EventArgs e)
        {
            FormAdminPanelBooks.fd.ShowForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAdminPanelRequests.fd.ShowForm();
        }

        private void buttonToPenalties_Click(object sender, EventArgs e)
        {
            FormAdminPanelPenalties.fd.ShowForm();
        }
    }
}
