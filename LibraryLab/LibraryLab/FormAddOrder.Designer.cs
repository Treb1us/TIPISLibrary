namespace LibraryLab
{
    partial class FormAddOrder
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
            System.Windows.Forms.Label requestDateLabel;
            System.Windows.Forms.Label requestIDLabel;
            System.Windows.Forms.Label bookIDLabel;
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label statusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddOrder));
            this.libraryDataSet = new LibraryLab.LibraryDataSet();
            this.storageRequestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storageRequestsTableAdapter = new LibraryLab.LibraryDataSetTableAdapters.StorageRequestsTableAdapter();
            this.tableAdapterManager = new LibraryLab.LibraryDataSetTableAdapters.TableAdapterManager();
            this.storageRequestsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.storageRequestsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteCustom = new System.Windows.Forms.ToolStripButton();
            this.requestDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.requestIDTextBox = new System.Windows.Forms.TextBox();
            this.bookIDTextBox = new System.Windows.Forms.TextBox();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFilterUserID = new System.Windows.Forms.TextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new LibraryLab.LibraryDataSetTableAdapters.UsersTableAdapter();
            requestDateLabel = new System.Windows.Forms.Label();
            requestIDLabel = new System.Windows.Forms.Label();
            bookIDLabel = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageRequestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageRequestsBindingNavigator)).BeginInit();
            this.storageRequestsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // requestDateLabel
            // 
            requestDateLabel.AutoSize = true;
            requestDateLabel.Location = new System.Drawing.Point(19, 121);
            requestDateLabel.Name = "requestDateLabel";
            requestDateLabel.Size = new System.Drawing.Size(76, 13);
            requestDateLabel.TabIndex = 25;
            requestDateLabel.Text = "Request Date:";
            // 
            // requestIDLabel
            // 
            requestIDLabel.AutoSize = true;
            requestIDLabel.Location = new System.Drawing.Point(69, 45);
            requestIDLabel.Name = "requestIDLabel";
            requestIDLabel.Size = new System.Drawing.Size(64, 13);
            requestIDLabel.TabIndex = 23;
            requestIDLabel.Text = "Request ID:";
            // 
            // bookIDLabel
            // 
            bookIDLabel.AutoSize = true;
            bookIDLabel.Location = new System.Drawing.Point(84, 94);
            bookIDLabel.Name = "bookIDLabel";
            bookIDLabel.Size = new System.Drawing.Size(49, 13);
            bookIDLabel.TabIndex = 21;
            bookIDLabel.Text = "Book ID:";
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new System.Drawing.Point(87, 68);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(46, 13);
            userIDLabel.TabIndex = 19;
            userIDLabel.Text = "User ID:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(93, 164);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 28;
            statusLabel.Text = "Status:";
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storageRequestsBindingSource
            // 
            this.storageRequestsBindingSource.DataMember = "StorageRequests";
            this.storageRequestsBindingSource.DataSource = this.libraryDataSet;
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
            // storageRequestsBindingNavigator
            // 
            this.storageRequestsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.storageRequestsBindingNavigator.BindingSource = this.storageRequestsBindingSource;
            this.storageRequestsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.storageRequestsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.storageRequestsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.storageRequestsBindingNavigatorSaveItem,
            this.btnDeleteCustom});
            this.storageRequestsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.storageRequestsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.storageRequestsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.storageRequestsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.storageRequestsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.storageRequestsBindingNavigator.Name = "storageRequestsBindingNavigator";
            this.storageRequestsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.storageRequestsBindingNavigator.Size = new System.Drawing.Size(657, 25);
            this.storageRequestsBindingNavigator.TabIndex = 0;
            this.storageRequestsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // storageRequestsBindingNavigatorSaveItem
            // 
            this.storageRequestsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.storageRequestsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("storageRequestsBindingNavigatorSaveItem.Image")));
            this.storageRequestsBindingNavigatorSaveItem.Name = "storageRequestsBindingNavigatorSaveItem";
            this.storageRequestsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.storageRequestsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.storageRequestsBindingNavigatorSaveItem.Click += new System.EventHandler(this.storageRequestsBindingNavigatorSaveItem_Click);
            // 
            // btnDeleteCustom
            // 
            this.btnDeleteCustom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteCustom.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCustom.Image")));
            this.btnDeleteCustom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteCustom.Name = "btnDeleteCustom";
            this.btnDeleteCustom.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteCustom.Text = "Удалить";
            this.btnDeleteCustom.Click += new System.EventHandler(this.btnDeleteCustom_Click);
            // 
            // requestDateDateTimePicker
            // 
            this.requestDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.storageRequestsBindingSource, "RequestDate", true));
            this.requestDateDateTimePicker.Location = new System.Drawing.Point(101, 117);
            this.requestDateDateTimePicker.Name = "requestDateDateTimePicker";
            this.requestDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.requestDateDateTimePicker.TabIndex = 28;
            // 
            // requestIDTextBox
            // 
            this.requestIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storageRequestsBindingSource, "RequestID", true));
            this.requestIDTextBox.Location = new System.Drawing.Point(139, 42);
            this.requestIDTextBox.Name = "requestIDTextBox";
            this.requestIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.requestIDTextBox.TabIndex = 26;
            // 
            // bookIDTextBox
            // 
            this.bookIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storageRequestsBindingSource, "BookID", true));
            this.bookIDTextBox.Location = new System.Drawing.Point(139, 91);
            this.bookIDTextBox.Name = "bookIDTextBox";
            this.bookIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.bookIDTextBox.TabIndex = 24;
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storageRequestsBindingSource, "UserID", true));
            this.userIDTextBox.Location = new System.Drawing.Point(139, 65);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.userIDTextBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID текущего пользователя";
            // 
            // textBoxFilterUserID
            // 
            this.textBoxFilterUserID.Location = new System.Drawing.Point(399, 65);
            this.textBoxFilterUserID.Name = "textBoxFilterUserID";
            this.textBoxFilterUserID.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilterUserID.TabIndex = 18;
            this.textBoxFilterUserID.TextChanged += new System.EventHandler(this.textBoxFilterUserID_TextChanged);
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storageRequestsBindingSource, "Status", true));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Ожидает",
            "Отменён"});
            this.statusComboBox.Location = new System.Drawing.Point(139, 161);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 21);
            this.statusComboBox.TabIndex = 29;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.libraryDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // FormAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 326);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(requestDateLabel);
            this.Controls.Add(this.requestDateDateTimePicker);
            this.Controls.Add(requestIDLabel);
            this.Controls.Add(this.requestIDTextBox);
            this.Controls.Add(bookIDLabel);
            this.Controls.Add(this.bookIDTextBox);
            this.Controls.Add(userIDLabel);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFilterUserID);
            this.Controls.Add(this.storageRequestsBindingNavigator);
            this.Name = "FormAddOrder";
            this.Text = "Сделать запрос";
            this.Load += new System.EventHandler(this.AddOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageRequestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageRequestsBindingNavigator)).EndInit();
            this.storageRequestsBindingNavigator.ResumeLayout(false);
            this.storageRequestsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource storageRequestsBindingSource;
        private LibraryDataSetTableAdapters.StorageRequestsTableAdapter storageRequestsTableAdapter;
        private LibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator storageRequestsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton storageRequestsBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker requestDateDateTimePicker;
        private System.Windows.Forms.TextBox requestIDTextBox;
        private System.Windows.Forms.TextBox bookIDTextBox;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFilterUserID;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.ToolStripButton btnDeleteCustom;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private LibraryDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
    }
}