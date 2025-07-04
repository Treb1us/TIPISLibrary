namespace LibraryLab
{
    partial class FormAdminPanelPenalties
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
            System.Windows.Forms.Label penaltyIDLabel;
            System.Windows.Forms.Label issueIDLabel;
            System.Windows.Forms.Label penaltyAmountLabel;
            System.Windows.Forms.Label calculatedOnLabel;
            this.buttonShowPenalties = new System.Windows.Forms.Button();
            this.dataGridViewPenalties = new System.Windows.Forms.DataGridView();
            this.panelTovar = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonExecuteDML = new System.Windows.Forms.Button();
            this.radioButtonDeletePenalty = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdatePenalty = new System.Windows.Forms.RadioButton();
            this.radioButtonAddPenalty = new System.Windows.Forms.RadioButton();
            this.libraryDataSet = new LibraryLab.LibraryDataSet();
            this.penaltiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.penaltiesTableAdapter = new LibraryLab.LibraryDataSetTableAdapters.PenaltiesTableAdapter();
            this.tableAdapterManager = new LibraryLab.LibraryDataSetTableAdapters.TableAdapterManager();
            this.penaltyIDTextBox = new System.Windows.Forms.TextBox();
            this.issueIDTextBox = new System.Windows.Forms.TextBox();
            this.penaltyAmountTextBox = new System.Windows.Forms.TextBox();
            this.calculatedOnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            penaltyIDLabel = new System.Windows.Forms.Label();
            issueIDLabel = new System.Windows.Forms.Label();
            penaltyAmountLabel = new System.Windows.Forms.Label();
            calculatedOnLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPenalties)).BeginInit();
            this.panelTovar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penaltiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonShowPenalties
            // 
            this.buttonShowPenalties.Location = new System.Drawing.Point(229, 224);
            this.buttonShowPenalties.Name = "buttonShowPenalties";
            this.buttonShowPenalties.Size = new System.Drawing.Size(212, 23);
            this.buttonShowPenalties.TabIndex = 24;
            this.buttonShowPenalties.Text = "Показать список пени";
            this.buttonShowPenalties.UseVisualStyleBackColor = true;
            this.buttonShowPenalties.Click += new System.EventHandler(this.buttonShowPenalties_Click);
            // 
            // dataGridViewPenalties
            // 
            this.dataGridViewPenalties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPenalties.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewPenalties.Location = new System.Drawing.Point(0, 253);
            this.dataGridViewPenalties.Name = "dataGridViewPenalties";
            this.dataGridViewPenalties.Size = new System.Drawing.Size(651, 344);
            this.dataGridViewPenalties.TabIndex = 23;
            // 
            // panelTovar
            // 
            this.panelTovar.Controls.Add(calculatedOnLabel);
            this.panelTovar.Controls.Add(this.calculatedOnDateTimePicker);
            this.panelTovar.Controls.Add(penaltyAmountLabel);
            this.panelTovar.Controls.Add(this.penaltyAmountTextBox);
            this.panelTovar.Controls.Add(issueIDLabel);
            this.panelTovar.Controls.Add(this.issueIDTextBox);
            this.panelTovar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTovar.Location = new System.Drawing.Point(0, 104);
            this.panelTovar.Name = "panelTovar";
            this.panelTovar.Size = new System.Drawing.Size(651, 114);
            this.panelTovar.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(penaltyIDLabel);
            this.groupBox1.Controls.Add(this.penaltyIDTextBox);
            this.groupBox1.Controls.Add(this.buttonExecuteDML);
            this.groupBox1.Controls.Add(this.radioButtonDeletePenalty);
            this.groupBox1.Controls.Add(this.radioButtonUpdatePenalty);
            this.groupBox1.Controls.Add(this.radioButtonAddPenalty);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 104);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операторы";
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
            // radioButtonDeletePenalty
            // 
            this.radioButtonDeletePenalty.AutoSize = true;
            this.radioButtonDeletePenalty.Location = new System.Drawing.Point(429, 20);
            this.radioButtonDeletePenalty.Name = "radioButtonDeletePenalty";
            this.radioButtonDeletePenalty.Size = new System.Drawing.Size(95, 17);
            this.radioButtonDeletePenalty.TabIndex = 2;
            this.radioButtonDeletePenalty.TabStop = true;
            this.radioButtonDeletePenalty.Text = "Удалить пени";
            this.radioButtonDeletePenalty.UseVisualStyleBackColor = true;
            // 
            // radioButtonUpdatePenalty
            // 
            this.radioButtonUpdatePenalty.AutoSize = true;
            this.radioButtonUpdatePenalty.Location = new System.Drawing.Point(200, 18);
            this.radioButtonUpdatePenalty.Name = "radioButtonUpdatePenalty";
            this.radioButtonUpdatePenalty.Size = new System.Drawing.Size(144, 17);
            this.radioButtonUpdatePenalty.TabIndex = 1;
            this.radioButtonUpdatePenalty.TabStop = true;
            this.radioButtonUpdatePenalty.Text = "Изменить данные пени";
            this.radioButtonUpdatePenalty.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddPenalty
            // 
            this.radioButtonAddPenalty.AutoSize = true;
            this.radioButtonAddPenalty.Location = new System.Drawing.Point(19, 18);
            this.radioButtonAddPenalty.Name = "radioButtonAddPenalty";
            this.radioButtonAddPenalty.Size = new System.Drawing.Size(102, 17);
            this.radioButtonAddPenalty.TabIndex = 0;
            this.radioButtonAddPenalty.TabStop = true;
            this.radioButtonAddPenalty.Text = "Добавить пени";
            this.radioButtonAddPenalty.UseVisualStyleBackColor = true;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // penaltiesBindingSource
            // 
            this.penaltiesBindingSource.DataMember = "Penalties";
            this.penaltiesBindingSource.DataSource = this.libraryDataSet;
            // 
            // penaltiesTableAdapter
            // 
            this.penaltiesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookIssuesTableAdapter = null;
            this.tableAdapterManager.BooksTableAdapter = null;
            this.tableAdapterManager.PenaltiesTableAdapter = this.penaltiesTableAdapter;
            this.tableAdapterManager.StorageRequestsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LibraryLab.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // penaltyIDLabel
            // 
            penaltyIDLabel.AutoSize = true;
            penaltyIDLabel.Location = new System.Drawing.Point(98, 59);
            penaltyIDLabel.Name = "penaltyIDLabel";
            penaltyIDLabel.Size = new System.Drawing.Size(59, 13);
            penaltyIDLabel.TabIndex = 5;
            penaltyIDLabel.Text = "Penalty ID:";
            // 
            // penaltyIDTextBox
            // 
            this.penaltyIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.penaltiesBindingSource, "PenaltyID", true));
            this.penaltyIDTextBox.Location = new System.Drawing.Point(163, 56);
            this.penaltyIDTextBox.Name = "penaltyIDTextBox";
            this.penaltyIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.penaltyIDTextBox.TabIndex = 6;
            // 
            // issueIDLabel
            // 
            issueIDLabel.AutoSize = true;
            issueIDLabel.Location = new System.Drawing.Point(77, 21);
            issueIDLabel.Name = "issueIDLabel";
            issueIDLabel.Size = new System.Drawing.Size(49, 13);
            issueIDLabel.TabIndex = 0;
            issueIDLabel.Text = "Issue ID:";
            // 
            // issueIDTextBox
            // 
            this.issueIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.penaltiesBindingSource, "IssueID", true));
            this.issueIDTextBox.Location = new System.Drawing.Point(132, 18);
            this.issueIDTextBox.Name = "issueIDTextBox";
            this.issueIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.issueIDTextBox.TabIndex = 1;
            // 
            // penaltyAmountLabel
            // 
            penaltyAmountLabel.AutoSize = true;
            penaltyAmountLabel.Location = new System.Drawing.Point(326, 24);
            penaltyAmountLabel.Name = "penaltyAmountLabel";
            penaltyAmountLabel.Size = new System.Drawing.Size(84, 13);
            penaltyAmountLabel.TabIndex = 2;
            penaltyAmountLabel.Text = "Penalty Amount:";
            // 
            // penaltyAmountTextBox
            // 
            this.penaltyAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.penaltiesBindingSource, "PenaltyAmount", true));
            this.penaltyAmountTextBox.Location = new System.Drawing.Point(416, 21);
            this.penaltyAmountTextBox.Name = "penaltyAmountTextBox";
            this.penaltyAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.penaltyAmountTextBox.TabIndex = 3;
            // 
            // calculatedOnLabel
            // 
            calculatedOnLabel.AutoSize = true;
            calculatedOnLabel.Location = new System.Drawing.Point(333, 68);
            calculatedOnLabel.Name = "calculatedOnLabel";
            calculatedOnLabel.Size = new System.Drawing.Size(77, 13);
            calculatedOnLabel.TabIndex = 4;
            calculatedOnLabel.Text = "Calculated On:";
            // 
            // calculatedOnDateTimePicker
            // 
            this.calculatedOnDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.penaltiesBindingSource, "CalculatedOn", true));
            this.calculatedOnDateTimePicker.Location = new System.Drawing.Point(416, 64);
            this.calculatedOnDateTimePicker.Name = "calculatedOnDateTimePicker";
            this.calculatedOnDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.calculatedOnDateTimePicker.TabIndex = 5;
            // 
            // FormAdminPanelPenalties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 597);
            this.Controls.Add(this.buttonShowPenalties);
            this.Controls.Add(this.dataGridViewPenalties);
            this.Controls.Add(this.panelTovar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAdminPanelPenalties";
            this.Text = "Пени";
            this.Load += new System.EventHandler(this.FormAdminPanelPenalties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPenalties)).EndInit();
            this.panelTovar.ResumeLayout(false);
            this.panelTovar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penaltiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowPenalties;
        private System.Windows.Forms.DataGridView dataGridViewPenalties;
        private System.Windows.Forms.Panel panelTovar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonExecuteDML;
        private System.Windows.Forms.RadioButton radioButtonDeletePenalty;
        private System.Windows.Forms.RadioButton radioButtonUpdatePenalty;
        private System.Windows.Forms.RadioButton radioButtonAddPenalty;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource penaltiesBindingSource;
        private LibraryDataSetTableAdapters.PenaltiesTableAdapter penaltiesTableAdapter;
        private LibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker calculatedOnDateTimePicker;
        private System.Windows.Forms.TextBox penaltyAmountTextBox;
        private System.Windows.Forms.TextBox issueIDTextBox;
        private System.Windows.Forms.TextBox penaltyIDTextBox;
    }
}