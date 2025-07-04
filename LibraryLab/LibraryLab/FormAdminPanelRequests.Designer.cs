namespace LibraryLab
{
    partial class FormAdminPanelRequests
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
            System.Windows.Forms.Label requestIDLabel;
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label bookIDLabel;
            System.Windows.Forms.Label requestDateLabel;
            System.Windows.Forms.Label readyDateLabel;
            System.Windows.Forms.Label statusLabel;
            this.buttonShowRequests = new System.Windows.Forms.Button();
            this.dataGridViewRequests = new System.Windows.Forms.DataGridView();
            this.panelTovar = new System.Windows.Forms.Panel();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.storageRequestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new LibraryLab.LibraryDataSet();
            this.readyDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.requestDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bookIDTextBox = new System.Windows.Forms.TextBox();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.requestIDTextBox = new System.Windows.Forms.TextBox();
            this.buttonExecuteDML = new System.Windows.Forms.Button();
            this.radioButtonDeleteRequest = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdateRequest = new System.Windows.Forms.RadioButton();
            this.radioButtonAddRequest = new System.Windows.Forms.RadioButton();
            this.storageRequestsTableAdapter = new LibraryLab.LibraryDataSetTableAdapters.StorageRequestsTableAdapter();
            this.tableAdapterManager = new LibraryLab.LibraryDataSetTableAdapters.TableAdapterManager();
            requestIDLabel = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            bookIDLabel = new System.Windows.Forms.Label();
            requestDateLabel = new System.Windows.Forms.Label();
            readyDateLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).BeginInit();
            this.panelTovar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storageRequestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // requestIDLabel
            // 
            requestIDLabel.AutoSize = true;
            requestIDLabel.Location = new System.Drawing.Point(73, 57);
            requestIDLabel.Name = "requestIDLabel";
            requestIDLabel.Size = new System.Drawing.Size(64, 13);
            requestIDLabel.TabIndex = 5;
            requestIDLabel.Text = "Request ID:";
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new System.Drawing.Point(91, 18);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(46, 13);
            userIDLabel.TabIndex = 0;
            userIDLabel.Text = "User ID:";
            // 
            // bookIDLabel
            // 
            bookIDLabel.AutoSize = true;
            bookIDLabel.Location = new System.Drawing.Point(88, 54);
            bookIDLabel.Name = "bookIDLabel";
            bookIDLabel.Size = new System.Drawing.Size(49, 13);
            bookIDLabel.TabIndex = 2;
            bookIDLabel.Text = "Book ID:";
            // 
            // requestDateLabel
            // 
            requestDateLabel.AutoSize = true;
            requestDateLabel.Location = new System.Drawing.Point(315, 18);
            requestDateLabel.Name = "requestDateLabel";
            requestDateLabel.Size = new System.Drawing.Size(76, 13);
            requestDateLabel.TabIndex = 4;
            requestDateLabel.Text = "Request Date:";
            // 
            // readyDateLabel
            // 
            readyDateLabel.AutoSize = true;
            readyDateLabel.Location = new System.Drawing.Point(324, 54);
            readyDateLabel.Name = "readyDateLabel";
            readyDateLabel.Size = new System.Drawing.Size(67, 13);
            readyDateLabel.TabIndex = 6;
            readyDateLabel.Text = "Ready Date:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(430, 96);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 8;
            statusLabel.Text = "Status:";
            // 
            // buttonShowRequests
            // 
            this.buttonShowRequests.Location = new System.Drawing.Point(233, 230);
            this.buttonShowRequests.Name = "buttonShowRequests";
            this.buttonShowRequests.Size = new System.Drawing.Size(212, 23);
            this.buttonShowRequests.TabIndex = 20;
            this.buttonShowRequests.Text = "Показать список запросов";
            this.buttonShowRequests.UseVisualStyleBackColor = true;
            this.buttonShowRequests.Click += new System.EventHandler(this.buttonShowRequests_Click);
            // 
            // dataGridViewRequests
            // 
            this.dataGridViewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequests.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewRequests.Location = new System.Drawing.Point(0, 261);
            this.dataGridViewRequests.Name = "dataGridViewRequests";
            this.dataGridViewRequests.Size = new System.Drawing.Size(661, 344);
            this.dataGridViewRequests.TabIndex = 19;
            // 
            // panelTovar
            // 
            this.panelTovar.Controls.Add(statusLabel);
            this.panelTovar.Controls.Add(this.statusComboBox);
            this.panelTovar.Controls.Add(readyDateLabel);
            this.panelTovar.Controls.Add(this.readyDateDateTimePicker);
            this.panelTovar.Controls.Add(requestDateLabel);
            this.panelTovar.Controls.Add(this.requestDateDateTimePicker);
            this.panelTovar.Controls.Add(bookIDLabel);
            this.panelTovar.Controls.Add(this.bookIDTextBox);
            this.panelTovar.Controls.Add(userIDLabel);
            this.panelTovar.Controls.Add(this.userIDTextBox);
            this.panelTovar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTovar.Location = new System.Drawing.Point(0, 98);
            this.panelTovar.Name = "panelTovar";
            this.panelTovar.Size = new System.Drawing.Size(661, 126);
            this.panelTovar.TabIndex = 18;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storageRequestsBindingSource, "Status", true));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Готов",
            "Отменён",
            "Просрочен",
            "Ожидает",
            "Выдан"});
            this.statusComboBox.Location = new System.Drawing.Point(476, 93);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 21);
            this.statusComboBox.TabIndex = 9;
            // 
            // storageRequestsBindingSource
            // 
            this.storageRequestsBindingSource.DataMember = "StorageRequests";
            this.storageRequestsBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // readyDateDateTimePicker
            // 
            this.readyDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.storageRequestsBindingSource, "ReadyDate", true));
            this.readyDateDateTimePicker.Location = new System.Drawing.Point(397, 50);
            this.readyDateDateTimePicker.Name = "readyDateDateTimePicker";
            this.readyDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.readyDateDateTimePicker.TabIndex = 7;
            // 
            // requestDateDateTimePicker
            // 
            this.requestDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.storageRequestsBindingSource, "RequestDate", true));
            this.requestDateDateTimePicker.Location = new System.Drawing.Point(397, 14);
            this.requestDateDateTimePicker.Name = "requestDateDateTimePicker";
            this.requestDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.requestDateDateTimePicker.TabIndex = 5;
            // 
            // bookIDTextBox
            // 
            this.bookIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storageRequestsBindingSource, "BookID", true));
            this.bookIDTextBox.Location = new System.Drawing.Point(143, 51);
            this.bookIDTextBox.Name = "bookIDTextBox";
            this.bookIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.bookIDTextBox.TabIndex = 3;
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storageRequestsBindingSource, "UserID", true));
            this.userIDTextBox.Location = new System.Drawing.Point(143, 15);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.userIDTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(requestIDLabel);
            this.groupBox1.Controls.Add(this.requestIDTextBox);
            this.groupBox1.Controls.Add(this.buttonExecuteDML);
            this.groupBox1.Controls.Add(this.radioButtonDeleteRequest);
            this.groupBox1.Controls.Add(this.radioButtonUpdateRequest);
            this.groupBox1.Controls.Add(this.radioButtonAddRequest);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 98);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операторы";
            // 
            // requestIDTextBox
            // 
            this.requestIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storageRequestsBindingSource, "RequestID", true));
            this.requestIDTextBox.Location = new System.Drawing.Point(143, 54);
            this.requestIDTextBox.Name = "requestIDTextBox";
            this.requestIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.requestIDTextBox.TabIndex = 6;
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
            // radioButtonDeleteRequest
            // 
            this.radioButtonDeleteRequest.AutoSize = true;
            this.radioButtonDeleteRequest.Location = new System.Drawing.Point(429, 20);
            this.radioButtonDeleteRequest.Name = "radioButtonDeleteRequest";
            this.radioButtonDeleteRequest.Size = new System.Drawing.Size(107, 17);
            this.radioButtonDeleteRequest.TabIndex = 2;
            this.radioButtonDeleteRequest.TabStop = true;
            this.radioButtonDeleteRequest.Text = "Удалить запрос";
            this.radioButtonDeleteRequest.UseVisualStyleBackColor = true;
            // 
            // radioButtonUpdateRequest
            // 
            this.radioButtonUpdateRequest.AutoSize = true;
            this.radioButtonUpdateRequest.Location = new System.Drawing.Point(200, 18);
            this.radioButtonUpdateRequest.Name = "radioButtonUpdateRequest";
            this.radioButtonUpdateRequest.Size = new System.Drawing.Size(115, 17);
            this.radioButtonUpdateRequest.TabIndex = 1;
            this.radioButtonUpdateRequest.TabStop = true;
            this.radioButtonUpdateRequest.Text = "Изменить запрос";
            this.radioButtonUpdateRequest.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddRequest
            // 
            this.radioButtonAddRequest.AutoSize = true;
            this.radioButtonAddRequest.Location = new System.Drawing.Point(19, 18);
            this.radioButtonAddRequest.Name = "radioButtonAddRequest";
            this.radioButtonAddRequest.Size = new System.Drawing.Size(114, 17);
            this.radioButtonAddRequest.TabIndex = 0;
            this.radioButtonAddRequest.TabStop = true;
            this.radioButtonAddRequest.Text = "Добавить запрос";
            this.radioButtonAddRequest.UseVisualStyleBackColor = true;
            // 
            // storageRequestsTableAdapter
            // 
            this.storageRequestsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookIssuesTableAdapter = null;
            this.tableAdapterManager.BooksTableAdapter = null;
            this.tableAdapterManager.PenaltiesTableAdapter = null;
            this.tableAdapterManager.StorageRequestsTableAdapter = this.storageRequestsTableAdapter;
            this.tableAdapterManager.UpdateOrder = LibraryLab.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // FormAdminPanelRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 605);
            this.Controls.Add(this.buttonShowRequests);
            this.Controls.Add(this.dataGridViewRequests);
            this.Controls.Add(this.panelTovar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAdminPanelRequests";
            this.Text = "Управление запросами";
            this.Load += new System.EventHandler(this.FormAdminPanelIssues_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).EndInit();
            this.panelTovar.ResumeLayout(false);
            this.panelTovar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storageRequestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowRequests;
        private System.Windows.Forms.DataGridView dataGridViewRequests;
        private System.Windows.Forms.Panel panelTovar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonExecuteDML;
        private System.Windows.Forms.RadioButton radioButtonDeleteRequest;
        private System.Windows.Forms.RadioButton radioButtonUpdateRequest;
        private System.Windows.Forms.RadioButton radioButtonAddRequest;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource storageRequestsBindingSource;
        private LibraryDataSetTableAdapters.StorageRequestsTableAdapter storageRequestsTableAdapter;
        private LibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox requestIDTextBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.DateTimePicker readyDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker requestDateDateTimePicker;
        private System.Windows.Forms.TextBox bookIDTextBox;
        private System.Windows.Forms.TextBox userIDTextBox;
    }
}