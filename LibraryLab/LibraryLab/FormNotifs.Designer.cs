namespace LibraryLab
{
    partial class FormNotifs
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
            this.groupBoxNotifs = new System.Windows.Forms.GroupBox();
            this.radioButtonPenalties = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.radioButtonRequests = new System.Windows.Forms.RadioButton();
            this.radioButtonRent = new System.Windows.Forms.RadioButton();
            this.libraryDataSet = new LibraryLab.LibraryDataSet();
            this.libraryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookIssuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookIssuesTableAdapter = new LibraryLab.LibraryDataSetTableAdapters.BookIssuesTableAdapter();
            this.tableAdapterManager = new LibraryLab.LibraryDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewNotifs = new System.Windows.Forms.DataGridView();
            this.groupBoxNotifs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookIssuesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotifs)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxNotifs
            // 
            this.groupBoxNotifs.Controls.Add(this.radioButtonPenalties);
            this.groupBoxNotifs.Controls.Add(this.label1);
            this.groupBoxNotifs.Controls.Add(this.textBoxUserID);
            this.groupBoxNotifs.Controls.Add(this.radioButtonRequests);
            this.groupBoxNotifs.Controls.Add(this.radioButtonRent);
            this.groupBoxNotifs.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxNotifs.Location = new System.Drawing.Point(0, 0);
            this.groupBoxNotifs.Name = "groupBoxNotifs";
            this.groupBoxNotifs.Size = new System.Drawing.Size(647, 52);
            this.groupBoxNotifs.TabIndex = 0;
            this.groupBoxNotifs.TabStop = false;
            this.groupBoxNotifs.Text = "Уведомления";
            // 
            // radioButtonPenalties
            // 
            this.radioButtonPenalties.AutoSize = true;
            this.radioButtonPenalties.Location = new System.Drawing.Point(199, 20);
            this.radioButtonPenalties.Name = "radioButtonPenalties";
            this.radioButtonPenalties.Size = new System.Drawing.Size(57, 17);
            this.radioButtonPenalties.TabIndex = 4;
            this.radioButtonPenalties.TabStop = true;
            this.radioButtonPenalties.Text = "Долги";
            this.radioButtonPenalties.UseVisualStyleBackColor = true;
            this.radioButtonPenalties.CheckedChanged += new System.EventHandler(this.radioButtonPenalties_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID пользователя";
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(307, 19);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserID.TabIndex = 2;
            // 
            // radioButtonRequests
            // 
            this.radioButtonRequests.AutoSize = true;
            this.radioButtonRequests.Location = new System.Drawing.Point(122, 20);
            this.radioButtonRequests.Name = "radioButtonRequests";
            this.radioButtonRequests.Size = new System.Drawing.Size(70, 17);
            this.radioButtonRequests.TabIndex = 1;
            this.radioButtonRequests.TabStop = true;
            this.radioButtonRequests.Text = "Запросы";
            this.radioButtonRequests.UseVisualStyleBackColor = true;
            this.radioButtonRequests.CheckedChanged += new System.EventHandler(this.radioButtonPenalties_CheckedChanged);
            // 
            // radioButtonRent
            // 
            this.radioButtonRent.AutoSize = true;
            this.radioButtonRent.Location = new System.Drawing.Point(13, 20);
            this.radioButtonRent.Name = "radioButtonRent";
            this.radioButtonRent.Size = new System.Drawing.Size(103, 17);
            this.radioButtonRent.TabIndex = 0;
            this.radioButtonRent.TabStop = true;
            this.radioButtonRent.Text = "Книги в аренде";
            this.radioButtonRent.UseVisualStyleBackColor = true;
            this.radioButtonRent.CheckedChanged += new System.EventHandler(this.radioButtonRent_CheckedChanged);
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryDataSetBindingSource
            // 
            this.libraryDataSetBindingSource.DataSource = this.libraryDataSet;
            this.libraryDataSetBindingSource.Position = 0;
            // 
            // bookIssuesBindingSource
            // 
            this.bookIssuesBindingSource.DataMember = "BookIssues";
            this.bookIssuesBindingSource.DataSource = this.libraryDataSet;
            // 
            // bookIssuesTableAdapter
            // 
            this.bookIssuesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookIssuesTableAdapter = this.bookIssuesTableAdapter;
            this.tableAdapterManager.BooksTableAdapter = null;
            this.tableAdapterManager.PenaltiesTableAdapter = null;
            this.tableAdapterManager.StorageRequestsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LibraryLab.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // dataGridViewNotifs
            // 
            this.dataGridViewNotifs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotifs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNotifs.Location = new System.Drawing.Point(0, 52);
            this.dataGridViewNotifs.Name = "dataGridViewNotifs";
            this.dataGridViewNotifs.Size = new System.Drawing.Size(647, 246);
            this.dataGridViewNotifs.TabIndex = 1;
            // 
            // FormNotifs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 298);
            this.Controls.Add(this.dataGridViewNotifs);
            this.Controls.Add(this.groupBoxNotifs);
            this.Name = "FormNotifs";
            this.Text = "Уведомления";
            this.Load += new System.EventHandler(this.FormNotifs_Load);
            this.groupBoxNotifs.ResumeLayout(false);
            this.groupBoxNotifs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookIssuesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotifs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNotifs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.RadioButton radioButtonRequests;
        private System.Windows.Forms.RadioButton radioButtonRent;
        private System.Windows.Forms.BindingSource libraryDataSetBindingSource;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource bookIssuesBindingSource;
        private LibraryDataSetTableAdapters.BookIssuesTableAdapter bookIssuesTableAdapter;
        private LibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridViewNotifs;
        private System.Windows.Forms.RadioButton radioButtonPenalties;
    }
}