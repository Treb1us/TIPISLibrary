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
    public partial class FormAddOrder : Form
    {
        private static FormAddOrder f;
        public static FormAddOrder fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormAddOrder();
                return f;
            }
        }
        public FormAddOrder()
        {
            InitializeComponent();
        }

        private void bookIssuesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.storageRequestsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.libraryDataSet.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.StorageRequests". При необходимости она может быть перемещена или удалена.
            this.storageRequestsTableAdapter.Fill(this.libraryDataSet.StorageRequests);

        }
        public void ShowForm()
        {
            storageRequestsBindingSource.Position = 0;
            Show();
            Activate();
        }

        private void textBoxFilterUserID_TextChanged(object sender, EventArgs e)
        {
            int userId;
            if (int.TryParse(textBoxFilterUserID.Text, out userId))
            {
                // Применим фильтр к BindingSource
                storageRequestsBindingSource.Filter = "UserID = " + userId;
            }
            else
            {
                MessageBox.Show("Введите корректный числовой ID пользователя.");
            }
        }

        private void storageRequestsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            var currentRow = ((DataRowView)storageRequestsBindingSource.Current).Row as LibraryDataSet.StorageRequestsRow;
            int userId;
            if (!int.TryParse(textBoxFilterUserID.Text, out userId))
            {
                MessageBox.Show("Введите корректный ID пользователя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ищем пользователя в таблице Users
            var userRow = libraryDataSet.Users.FindByUserID(userId);
            if (userRow == null)
            {
                MessageBox.Show("Пользователь с таким ID не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка на блокировку
            if (userRow.Status == "Заблокирован")
            {
                MessageBox.Show("Пользователь заблокирован. Сохранение невозможно.", "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Проверка на недопустимый статус
            if (currentRow != null)
            {
                string status = currentRow.Status;

                // Пользователь попытался установить недопустимый статус вручную
                if (status == "Готов" || status == "Просрочен" || status == "Выдан")
                {
                    MessageBox.Show("Вы не можете установить этот статус вручную.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Запрос к базе для получения оригинального статуса (если редактируем существующую строку)
                var originalRow = libraryDataSet.StorageRequests.FindByRequestID(currentRow.RequestID);
                if (originalRow != null && (originalRow.Status == "Готов" || originalRow.Status == "Просрочен"))
                {
                    MessageBox.Show("Этот заказ уже обработан и не может быть изменён.", "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            this.Validate();
            this.storageRequestsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
        private void storageRequestsBindingSource_CurrentChanging(object sender, CancelEventArgs e)
        {
            if (storageRequestsBindingSource.Current == null) return;

            var currentRow = ((DataRowView)storageRequestsBindingSource.Current).Row as LibraryDataSet.StorageRequestsRow;

            // Проверяем, не удаляется ли строка (по статусу)
            if (currentRow != null && currentRow.RowState != DataRowState.Deleted && currentRow.Status != "Отменён")
            {
                MessageBox.Show("Удаление возможно только для отменённых заявок.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void btnDeleteCustom_Click(object sender, EventArgs e)
        {
            var currentRow = ((DataRowView)storageRequestsBindingSource.Current).Row as LibraryDataSet.StorageRequestsRow;

            if (currentRow.Status != "Отменён")
            {
                MessageBox.Show("Удаление возможно только для отменённых заявок.", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Вы действительно хотите удалить заявку?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                storageRequestsBindingSource.RemoveCurrent();
                tableAdapterManager.UpdateAll(libraryDataSet); // Сохраняем изменения
            }
        }
    }
}
