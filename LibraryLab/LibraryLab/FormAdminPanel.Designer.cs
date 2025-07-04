namespace LibraryLab
{
    partial class FormAdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonToUsers = new System.Windows.Forms.Button();
            this.buttonToBooks = new System.Windows.Forms.Button();
            this.buttonToRequests = new System.Windows.Forms.Button();
            this.buttonToPenalties = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonToUsers
            // 
            this.buttonToUsers.Location = new System.Drawing.Point(12, 77);
            this.buttonToUsers.Name = "buttonToUsers";
            this.buttonToUsers.Size = new System.Drawing.Size(125, 57);
            this.buttonToUsers.TabIndex = 0;
            this.buttonToUsers.Text = "Управление пользователями";
            this.buttonToUsers.UseVisualStyleBackColor = true;
            this.buttonToUsers.Click += new System.EventHandler(this.buttonToUsers_Click);
            // 
            // buttonToBooks
            // 
            this.buttonToBooks.Location = new System.Drawing.Point(236, 77);
            this.buttonToBooks.Name = "buttonToBooks";
            this.buttonToBooks.Size = new System.Drawing.Size(125, 57);
            this.buttonToBooks.TabIndex = 1;
            this.buttonToBooks.Text = "Управление книгами";
            this.buttonToBooks.UseVisualStyleBackColor = true;
            this.buttonToBooks.Click += new System.EventHandler(this.buttonToBooks_Click);
            // 
            // buttonToRequests
            // 
            this.buttonToRequests.Location = new System.Drawing.Point(12, 165);
            this.buttonToRequests.Name = "buttonToRequests";
            this.buttonToRequests.Size = new System.Drawing.Size(125, 57);
            this.buttonToRequests.TabIndex = 2;
            this.buttonToRequests.Text = "Управление запросами";
            this.buttonToRequests.UseVisualStyleBackColor = true;
            this.buttonToRequests.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonToPenalties
            // 
            this.buttonToPenalties.Location = new System.Drawing.Point(236, 165);
            this.buttonToPenalties.Name = "buttonToPenalties";
            this.buttonToPenalties.Size = new System.Drawing.Size(125, 57);
            this.buttonToPenalties.TabIndex = 3;
            this.buttonToPenalties.Text = "К монетарным наказаниям";
            this.buttonToPenalties.UseVisualStyleBackColor = true;
            this.buttonToPenalties.Click += new System.EventHandler(this.buttonToPenalties_Click);
            // 
            // FormAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 332);
            this.Controls.Add(this.buttonToPenalties);
            this.Controls.Add(this.buttonToRequests);
            this.Controls.Add(this.buttonToBooks);
            this.Controls.Add(this.buttonToUsers);
            this.Name = "FormAdminPanel";
            this.Text = "Панель администратора";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonToUsers;
        private System.Windows.Forms.Button buttonToBooks;
        private System.Windows.Forms.Button buttonToRequests;
        private System.Windows.Forms.Button buttonToPenalties;
    }
}