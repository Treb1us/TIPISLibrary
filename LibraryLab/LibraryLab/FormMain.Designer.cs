namespace LibraryLab
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администраторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_Books = new System.Windows.Forms.Button();
            this.Main_OwnedBooks = new System.Windows.Forms.Button();
            this.Main_Orders = new System.Windows.Forms.Button();
            this.Main_notifications = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(353, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.администраторToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // администраторToolStripMenuItem
            // 
            this.администраторToolStripMenuItem.Name = "администраторToolStripMenuItem";
            this.администраторToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.администраторToolStripMenuItem.Text = "Администратор";
            this.администраторToolStripMenuItem.Click += new System.EventHandler(this.администраторToolStripMenuItem_Click);
            // 
            // Main_Books
            // 
            this.Main_Books.Location = new System.Drawing.Point(12, 188);
            this.Main_Books.Name = "Main_Books";
            this.Main_Books.Size = new System.Drawing.Size(121, 43);
            this.Main_Books.TabIndex = 2;
            this.Main_Books.Text = "Каталог";
            this.Main_Books.UseVisualStyleBackColor = true;
            this.Main_Books.Click += new System.EventHandler(this.Main_Books_Click);
            // 
            // Main_OwnedBooks
            // 
            this.Main_OwnedBooks.Location = new System.Drawing.Point(220, 188);
            this.Main_OwnedBooks.Name = "Main_OwnedBooks";
            this.Main_OwnedBooks.Size = new System.Drawing.Size(121, 43);
            this.Main_OwnedBooks.TabIndex = 3;
            this.Main_OwnedBooks.Text = "Мои книги";
            this.Main_OwnedBooks.UseVisualStyleBackColor = true;
            this.Main_OwnedBooks.Click += new System.EventHandler(this.Main_OwnedBooks_Click);
            // 
            // Main_Orders
            // 
            this.Main_Orders.Location = new System.Drawing.Point(12, 237);
            this.Main_Orders.Name = "Main_Orders";
            this.Main_Orders.Size = new System.Drawing.Size(121, 43);
            this.Main_Orders.TabIndex = 4;
            this.Main_Orders.Text = "Заказы";
            this.Main_Orders.UseVisualStyleBackColor = true;
            this.Main_Orders.Click += new System.EventHandler(this.Main_Orders_Click);
            // 
            // Main_notifications
            // 
            this.Main_notifications.Location = new System.Drawing.Point(220, 237);
            this.Main_notifications.Name = "Main_notifications";
            this.Main_notifications.Size = new System.Drawing.Size(121, 43);
            this.Main_notifications.TabIndex = 5;
            this.Main_notifications.Text = "Уведомления";
            this.Main_notifications.UseVisualStyleBackColor = true;
            this.Main_notifications.Click += new System.EventHandler(this.Main_notifications_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 305);
            this.Controls.Add(this.Main_notifications);
            this.Controls.Add(this.Main_Orders);
            this.Controls.Add(this.Main_OwnedBooks);
            this.Controls.Add(this.Main_Books);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Программа для библиотеки";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администраторToolStripMenuItem;
        private System.Windows.Forms.Button Main_Books;
        private System.Windows.Forms.Button Main_OwnedBooks;
        private System.Windows.Forms.Button Main_Orders;
        private System.Windows.Forms.Button Main_notifications;
    }
}

