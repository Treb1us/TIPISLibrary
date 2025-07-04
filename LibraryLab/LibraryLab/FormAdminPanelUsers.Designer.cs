namespace LibraryLab
{
    partial class FormAdminPanelUsers
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label studentIDLabel;
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label cardIssueDateLabel;
            System.Windows.Forms.Label cardExpiryDateLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label userIDLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new LibraryLab.LibraryDataSet();
            this.buttonExecuteDML = new System.Windows.Forms.Button();
            this.radioButtonDeleteUser = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdateUser = new System.Windows.Forms.RadioButton();
            this.radioButtonAddUser = new System.Windows.Forms.RadioButton();
            this.panelTovar = new System.Windows.Forms.Panel();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.cardExpiryDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cardIssueDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.buttonShowUsers = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.usersTableAdapter = new LibraryLab.LibraryDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new LibraryLab.LibraryDataSetTableAdapters.TableAdapterManager();
            fullNameLabel = new System.Windows.Forms.Label();
            studentIDLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            cardIssueDateLabel = new System.Windows.Forms.Label();
            cardExpiryDateLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            this.panelTovar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(64, 18);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(57, 13);
            fullNameLabel.TabIndex = 0;
            fullNameLabel.Text = "Full Name:";
            // 
            // studentIDLabel
            // 
            studentIDLabel.AutoSize = true;
            studentIDLabel.Location = new System.Drawing.Point(60, 47);
            studentIDLabel.Name = "studentIDLabel";
            studentIDLabel.Size = new System.Drawing.Size(61, 13);
            studentIDLabel.TabIndex = 2;
            studentIDLabel.Text = "Student ID:";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new System.Drawing.Point(60, 78);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(57, 13);
            birthDateLabel.TabIndex = 4;
            birthDateLabel.Text = "Birth Date:";
            // 
            // cardIssueDateLabel
            // 
            cardIssueDateLabel.AutoSize = true;
            cardIssueDateLabel.Location = new System.Drawing.Point(344, 22);
            cardIssueDateLabel.Name = "cardIssueDateLabel";
            cardIssueDateLabel.Size = new System.Drawing.Size(86, 13);
            cardIssueDateLabel.TabIndex = 6;
            cardIssueDateLabel.Text = "Card Issue Date:";
            // 
            // cardExpiryDateLabel
            // 
            cardExpiryDateLabel.AutoSize = true;
            cardExpiryDateLabel.Location = new System.Drawing.Point(341, 47);
            cardExpiryDateLabel.Name = "cardExpiryDateLabel";
            cardExpiryDateLabel.Size = new System.Drawing.Size(89, 13);
            cardExpiryDateLabel.TabIndex = 8;
            cardExpiryDateLabel.Text = "Card Expiry Date:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(390, 74);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 10;
            statusLabel.Text = "Status:";
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new System.Drawing.Point(75, 60);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(46, 13);
            userIDLabel.TabIndex = 5;
            userIDLabel.Text = "User ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(userIDLabel);
            this.groupBox1.Controls.Add(this.userIDTextBox);
            this.groupBox1.Controls.Add(this.buttonExecuteDML);
            this.groupBox1.Controls.Add(this.radioButtonDeleteUser);
            this.groupBox1.Controls.Add(this.radioButtonUpdateUser);
            this.groupBox1.Controls.Add(this.radioButtonAddUser);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операторы";
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UserID", true));
            this.userIDTextBox.Location = new System.Drawing.Point(127, 57);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.userIDTextBox.TabIndex = 6;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonExecuteDML
            // 
            this.buttonExecuteDML.Location = new System.Drawing.Point(269, 54);
            this.buttonExecuteDML.Name = "buttonExecuteDML";
            this.buttonExecuteDML.Size = new System.Drawing.Size(122, 23);
            this.buttonExecuteDML.TabIndex = 5;
            this.buttonExecuteDML.Text = "Выполнить запрос";
            this.buttonExecuteDML.UseVisualStyleBackColor = true;
            this.buttonExecuteDML.Click += new System.EventHandler(this.buttonExecuteDML_Click);
            // 
            // radioButtonDeleteUser
            // 
            this.radioButtonDeleteUser.AutoSize = true;
            this.radioButtonDeleteUser.Location = new System.Drawing.Point(429, 20);
            this.radioButtonDeleteUser.Name = "radioButtonDeleteUser";
            this.radioButtonDeleteUser.Size = new System.Drawing.Size(142, 17);
            this.radioButtonDeleteUser.TabIndex = 2;
            this.radioButtonDeleteUser.TabStop = true;
            this.radioButtonDeleteUser.Text = "Удалить пользователя";
            this.radioButtonDeleteUser.UseVisualStyleBackColor = true;
            this.radioButtonDeleteUser.CheckedChanged += new System.EventHandler(this.radioButtonCodeDelete_CheckedChanged);
            // 
            // radioButtonUpdateUser
            // 
            this.radioButtonUpdateUser.AutoSize = true;
            this.radioButtonUpdateUser.Location = new System.Drawing.Point(200, 18);
            this.radioButtonUpdateUser.Name = "radioButtonUpdateUser";
            this.radioButtonUpdateUser.Size = new System.Drawing.Size(191, 17);
            this.radioButtonUpdateUser.TabIndex = 1;
            this.radioButtonUpdateUser.TabStop = true;
            this.radioButtonUpdateUser.Text = "Изменить данные пользователя";
            this.radioButtonUpdateUser.UseVisualStyleBackColor = true;
            this.radioButtonUpdateUser.CheckedChanged += new System.EventHandler(this.radioButtonCodeChange_CheckedChanged);
            // 
            // radioButtonAddUser
            // 
            this.radioButtonAddUser.AutoSize = true;
            this.radioButtonAddUser.Location = new System.Drawing.Point(19, 18);
            this.radioButtonAddUser.Name = "radioButtonAddUser";
            this.radioButtonAddUser.Size = new System.Drawing.Size(149, 17);
            this.radioButtonAddUser.TabIndex = 0;
            this.radioButtonAddUser.TabStop = true;
            this.radioButtonAddUser.Text = "Добавить пользователя";
            this.radioButtonAddUser.UseVisualStyleBackColor = true;
            this.radioButtonAddUser.CheckedChanged += new System.EventHandler(this.radioButtonAddStuff_CheckedChanged);
            // 
            // panelTovar
            // 
            this.panelTovar.Controls.Add(statusLabel);
            this.panelTovar.Controls.Add(this.statusTextBox);
            this.panelTovar.Controls.Add(cardExpiryDateLabel);
            this.panelTovar.Controls.Add(this.cardExpiryDateDateTimePicker);
            this.panelTovar.Controls.Add(cardIssueDateLabel);
            this.panelTovar.Controls.Add(this.cardIssueDateDateTimePicker);
            this.panelTovar.Controls.Add(birthDateLabel);
            this.panelTovar.Controls.Add(this.birthDateDateTimePicker);
            this.panelTovar.Controls.Add(studentIDLabel);
            this.panelTovar.Controls.Add(this.studentIDTextBox);
            this.panelTovar.Controls.Add(fullNameLabel);
            this.panelTovar.Controls.Add(this.fullNameTextBox);
            this.panelTovar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTovar.Location = new System.Drawing.Point(0, 94);
            this.panelTovar.Name = "panelTovar";
            this.panelTovar.Size = new System.Drawing.Size(688, 122);
            this.panelTovar.TabIndex = 2;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(436, 71);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(200, 20);
            this.statusTextBox.TabIndex = 11;
            // 
            // cardExpiryDateDateTimePicker
            // 
            this.cardExpiryDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usersBindingSource, "CardExpiryDate", true));
            this.cardExpiryDateDateTimePicker.Location = new System.Drawing.Point(436, 43);
            this.cardExpiryDateDateTimePicker.Name = "cardExpiryDateDateTimePicker";
            this.cardExpiryDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.cardExpiryDateDateTimePicker.TabIndex = 9;
            // 
            // cardIssueDateDateTimePicker
            // 
            this.cardIssueDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usersBindingSource, "CardIssueDate", true));
            this.cardIssueDateDateTimePicker.Location = new System.Drawing.Point(436, 18);
            this.cardIssueDateDateTimePicker.Name = "cardIssueDateDateTimePicker";
            this.cardIssueDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.cardIssueDateDateTimePicker.TabIndex = 7;
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usersBindingSource, "BirthDate", true));
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(123, 74);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthDateDateTimePicker.TabIndex = 5;
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "StudentID", true));
            this.studentIDTextBox.Location = new System.Drawing.Point(127, 44);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(196, 20);
            this.studentIDTextBox.TabIndex = 3;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "FullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(127, 15);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(196, 20);
            this.fullNameTextBox.TabIndex = 1;
            // 
            // buttonShowUsers
            // 
            this.buttonShowUsers.Location = new System.Drawing.Point(241, 222);
            this.buttonShowUsers.Name = "buttonShowUsers";
            this.buttonShowUsers.Size = new System.Drawing.Size(212, 23);
            this.buttonShowUsers.TabIndex = 16;
            this.buttonShowUsers.Text = "Показать список пользователей";
            this.buttonShowUsers.UseVisualStyleBackColor = true;
            this.buttonShowUsers.Click += new System.EventHandler(this.buttonShowUsers_Click);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewUsers.Location = new System.Drawing.Point(0, 251);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(688, 344);
            this.dataGridViewUsers.TabIndex = 15;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookIssuesTableAdapter = null;
            this.tableAdapterManager.BooksTableAdapter = null;
            this.tableAdapterManager.PenaltiesTableAdapter = null;
            this.tableAdapterManager.StorageRequestsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LibraryLab.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // FormAdminPanelUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 595);
            this.Controls.Add(this.buttonShowUsers);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.panelTovar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAdminPanelUsers";
            this.Text = "Управление пользователями";
            this.Load += new System.EventHandler(this.FormAdminPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            this.panelTovar.ResumeLayout(false);
            this.panelTovar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonExecuteDML;
        private System.Windows.Forms.RadioButton radioButtonDeleteUser;
        private System.Windows.Forms.RadioButton radioButtonUpdateUser;
        private System.Windows.Forms.RadioButton radioButtonAddUser;
        private System.Windows.Forms.Panel panelTovar;
        private System.Windows.Forms.Button buttonShowUsers;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private LibraryDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private LibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.DateTimePicker cardExpiryDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker cardIssueDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;

    }
}