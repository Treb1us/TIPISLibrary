namespace LibraryLab
{
    partial class FormAdminPanelBooks
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
            System.Windows.Forms.Label bookIDLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label authorLabel;
            System.Windows.Forms.Label cipherLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label availableCopiesLabel;
            this.buttonShowBooks = new System.Windows.Forms.Button();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.panelTovar = new System.Windows.Forms.Panel();
            this.availableCopiesTextBox = new System.Windows.Forms.TextBox();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new LibraryLab.LibraryDataSet();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.cipherTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bookIDTextBox = new System.Windows.Forms.TextBox();
            this.buttonExecuteDML = new System.Windows.Forms.Button();
            this.radioButtonDeleteBook = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdateBook = new System.Windows.Forms.RadioButton();
            this.radioButtonAddBook = new System.Windows.Forms.RadioButton();
            this.booksTableAdapter = new LibraryLab.LibraryDataSetTableAdapters.BooksTableAdapter();
            this.tableAdapterManager = new LibraryLab.LibraryDataSetTableAdapters.TableAdapterManager();
            bookIDLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            cipherLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            availableCopiesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.panelTovar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookIDLabel
            // 
            bookIDLabel.AutoSize = true;
            bookIDLabel.Location = new System.Drawing.Point(87, 60);
            bookIDLabel.Name = "bookIDLabel";
            bookIDLabel.Size = new System.Drawing.Size(49, 13);
            bookIDLabel.TabIndex = 5;
            bookIDLabel.Text = "Book ID:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(54, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Title:";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new System.Drawing.Point(43, 35);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(41, 13);
            authorLabel.TabIndex = 2;
            authorLabel.Text = "Author:";
            // 
            // cipherLabel
            // 
            cipherLabel.AutoSize = true;
            cipherLabel.Location = new System.Drawing.Point(44, 61);
            cipherLabel.Name = "cipherLabel";
            cipherLabel.Size = new System.Drawing.Size(40, 13);
            cipherLabel.TabIndex = 4;
            cipherLabel.Text = "Cipher:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(333, 9);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(51, 13);
            locationLabel.TabIndex = 6;
            locationLabel.Text = "Location:";
            // 
            // availableCopiesLabel
            // 
            availableCopiesLabel.AutoSize = true;
            availableCopiesLabel.Location = new System.Drawing.Point(498, 57);
            availableCopiesLabel.Name = "availableCopiesLabel";
            availableCopiesLabel.Size = new System.Drawing.Size(88, 13);
            availableCopiesLabel.TabIndex = 8;
            availableCopiesLabel.Text = "Available Copies:";
            // 
            // buttonShowBooks
            // 
            this.buttonShowBooks.Location = new System.Drawing.Point(232, 222);
            this.buttonShowBooks.Name = "buttonShowBooks";
            this.buttonShowBooks.Size = new System.Drawing.Size(212, 23);
            this.buttonShowBooks.TabIndex = 20;
            this.buttonShowBooks.Text = "Показать список книг";
            this.buttonShowBooks.UseVisualStyleBackColor = true;
            this.buttonShowBooks.Click += new System.EventHandler(this.buttonShowBooks_Click);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewBooks.Location = new System.Drawing.Point(0, 245);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.Size = new System.Drawing.Size(653, 344);
            this.dataGridViewBooks.TabIndex = 19;
            // 
            // panelTovar
            // 
            this.panelTovar.Controls.Add(availableCopiesLabel);
            this.panelTovar.Controls.Add(this.availableCopiesTextBox);
            this.panelTovar.Controls.Add(locationLabel);
            this.panelTovar.Controls.Add(this.locationTextBox);
            this.panelTovar.Controls.Add(cipherLabel);
            this.panelTovar.Controls.Add(this.cipherTextBox);
            this.panelTovar.Controls.Add(authorLabel);
            this.panelTovar.Controls.Add(this.authorTextBox);
            this.panelTovar.Controls.Add(titleLabel);
            this.panelTovar.Controls.Add(this.titleTextBox);
            this.panelTovar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTovar.Location = new System.Drawing.Point(0, 97);
            this.panelTovar.Name = "panelTovar";
            this.panelTovar.Size = new System.Drawing.Size(653, 122);
            this.panelTovar.TabIndex = 18;
            // 
            // availableCopiesTextBox
            // 
            this.availableCopiesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "AvailableCopies", true));
            this.availableCopiesTextBox.Location = new System.Drawing.Point(592, 54);
            this.availableCopiesTextBox.Name = "availableCopiesTextBox";
            this.availableCopiesTextBox.Size = new System.Drawing.Size(41, 20);
            this.availableCopiesTextBox.TabIndex = 9;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Location", true));
            this.locationTextBox.Location = new System.Drawing.Point(390, 6);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(243, 20);
            this.locationTextBox.TabIndex = 7;
            // 
            // cipherTextBox
            // 
            this.cipherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Cipher", true));
            this.cipherTextBox.Location = new System.Drawing.Point(90, 58);
            this.cipherTextBox.Name = "cipherTextBox";
            this.cipherTextBox.Size = new System.Drawing.Size(211, 20);
            this.cipherTextBox.TabIndex = 5;
            // 
            // authorTextBox
            // 
            this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Author", true));
            this.authorTextBox.Location = new System.Drawing.Point(90, 32);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(211, 20);
            this.authorTextBox.TabIndex = 3;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(90, 6);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(211, 20);
            this.titleTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(bookIDLabel);
            this.groupBox1.Controls.Add(this.bookIDTextBox);
            this.groupBox1.Controls.Add(this.buttonExecuteDML);
            this.groupBox1.Controls.Add(this.radioButtonDeleteBook);
            this.groupBox1.Controls.Add(this.radioButtonUpdateBook);
            this.groupBox1.Controls.Add(this.radioButtonAddBook);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 97);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операторы";
            // 
            // bookIDTextBox
            // 
            this.bookIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "BookID", true));
            this.bookIDTextBox.Location = new System.Drawing.Point(142, 57);
            this.bookIDTextBox.Name = "bookIDTextBox";
            this.bookIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.bookIDTextBox.TabIndex = 6;
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
            // radioButtonDeleteBook
            // 
            this.radioButtonDeleteBook.AutoSize = true;
            this.radioButtonDeleteBook.Location = new System.Drawing.Point(429, 20);
            this.radioButtonDeleteBook.Name = "radioButtonDeleteBook";
            this.radioButtonDeleteBook.Size = new System.Drawing.Size(99, 17);
            this.radioButtonDeleteBook.TabIndex = 2;
            this.radioButtonDeleteBook.TabStop = true;
            this.radioButtonDeleteBook.Text = "Удалить книгу";
            this.radioButtonDeleteBook.UseVisualStyleBackColor = true;
            // 
            // radioButtonUpdateBook
            // 
            this.radioButtonUpdateBook.AutoSize = true;
            this.radioButtonUpdateBook.Location = new System.Drawing.Point(200, 18);
            this.radioButtonUpdateBook.Name = "radioButtonUpdateBook";
            this.radioButtonUpdateBook.Size = new System.Drawing.Size(149, 17);
            this.radioButtonUpdateBook.TabIndex = 1;
            this.radioButtonUpdateBook.TabStop = true;
            this.radioButtonUpdateBook.Text = "Изменить данные книги";
            this.radioButtonUpdateBook.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddBook
            // 
            this.radioButtonAddBook.AutoSize = true;
            this.radioButtonAddBook.Location = new System.Drawing.Point(19, 18);
            this.radioButtonAddBook.Name = "radioButtonAddBook";
            this.radioButtonAddBook.Size = new System.Drawing.Size(107, 17);
            this.radioButtonAddBook.TabIndex = 0;
            this.radioButtonAddBook.TabStop = true;
            this.radioButtonAddBook.Text = "Добавить книги";
            this.radioButtonAddBook.UseVisualStyleBackColor = true;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookIssuesTableAdapter = null;
            this.tableAdapterManager.BooksTableAdapter = this.booksTableAdapter;
            this.tableAdapterManager.PenaltiesTableAdapter = null;
            this.tableAdapterManager.StorageRequestsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LibraryLab.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // FormAdminPanelBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 589);
            this.Controls.Add(this.buttonShowBooks);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.panelTovar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAdminPanelBooks";
            this.Text = "Управление книгами";
            this.Load += new System.EventHandler(this.FormAdminPanelBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.panelTovar.ResumeLayout(false);
            this.panelTovar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowBooks;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Panel panelTovar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonExecuteDML;
        private System.Windows.Forms.RadioButton radioButtonDeleteBook;
        private System.Windows.Forms.RadioButton radioButtonUpdateBook;
        private System.Windows.Forms.RadioButton radioButtonAddBook;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private LibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox bookIDTextBox;
        private System.Windows.Forms.TextBox availableCopiesTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox cipherTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
    }
}