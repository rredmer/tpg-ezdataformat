namespace EzDataFormat
{
    partial class EditTemplateForm
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
            this.dataSet = new System.Data.DataSet();
            this.dataTableVar = new System.Data.DataTable();
            this.dataColumnColNum = new System.Data.DataColumn();
            this.dataColumnName = new System.Data.DataColumn();
            this.dataColumnDataType = new System.Data.DataColumn();
            this.dataColumnConversion = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxTemplateList = new System.Windows.Forms.GroupBox();
            this.listBoxTemplates = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTemplate = new System.Windows.Forms.DataGridView();
            this.openFileDialogReference = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxReferenceFile = new System.Windows.Forms.GroupBox();
            this.dataGridViewReference = new System.Windows.Forms.DataGridView();
            this.dataSetReference = new System.Data.DataSet();
            this.dataTableRef = new System.Data.DataTable();
            this.textBoxDelimeter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.textSourceFile = new System.Windows.Forms.TextBox();
            this.colNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colConversionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableVar)).BeginInit();
            this.groupBoxTemplateList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemplate)).BeginInit();
            this.groupBoxReferenceFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableRef)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "NewDataSet";
            this.dataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTableVar});
            // 
            // dataTableVar
            // 
            this.dataTableVar.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumnColNum,
            this.dataColumnName,
            this.dataColumnDataType,
            this.dataColumnConversion,
            this.dataColumn1,
            this.dataColumn2});
            this.dataTableVar.TableName = "TableVar";
            // 
            // dataColumnColNum
            // 
            this.dataColumnColNum.AutoIncrement = true;
            this.dataColumnColNum.AutoIncrementSeed = ((long)(1));
            this.dataColumnColNum.Caption = "Col#";
            this.dataColumnColNum.ColumnName = "ColNum";
            this.dataColumnColNum.DataType = typeof(int);
            // 
            // dataColumnName
            // 
            this.dataColumnName.Caption = "Column Name";
            this.dataColumnName.ColumnName = "ColName";
            // 
            // dataColumnDataType
            // 
            this.dataColumnDataType.Caption = "Data Type";
            this.dataColumnDataType.ColumnName = "ColDataType";
            // 
            // dataColumnConversion
            // 
            this.dataColumnConversion.Caption = "Conversion Method";
            this.dataColumnConversion.ColumnName = "ColConversion";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "Source";
            this.dataColumn1.ColumnName = "ColSource";
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "Sort Order";
            this.dataColumn2.ColumnName = "ColSort";
            this.dataColumn2.DataType = typeof(short);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(4, 678);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(85, 46);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(95, 678);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(85, 46);
            this.buttonNew.TabIndex = 8;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(186, 678);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(85, 46);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxTemplateList
            // 
            this.groupBoxTemplateList.Controls.Add(this.listBoxTemplates);
            this.groupBoxTemplateList.Location = new System.Drawing.Point(4, 3);
            this.groupBoxTemplateList.Name = "groupBoxTemplateList";
            this.groupBoxTemplateList.Size = new System.Drawing.Size(239, 665);
            this.groupBoxTemplateList.TabIndex = 10;
            this.groupBoxTemplateList.TabStop = false;
            this.groupBoxTemplateList.Text = "Templates";
            // 
            // listBoxTemplates
            // 
            this.listBoxTemplates.FormattingEnabled = true;
            this.listBoxTemplates.Location = new System.Drawing.Point(7, 17);
            this.listBoxTemplates.Name = "listBoxTemplates";
            this.listBoxTemplates.Size = new System.Drawing.Size(225, 641);
            this.listBoxTemplates.TabIndex = 1;
            this.listBoxTemplates.SelectedIndexChanged += new System.EventHandler(this.listBoxTemplates_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewTemplate);
            this.groupBox1.Location = new System.Drawing.Point(250, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 354);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Template Definition";
            // 
            // dataGridViewTemplate
            // 
            this.dataGridViewTemplate.AutoGenerateColumns = false;
            this.dataGridViewTemplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTemplate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumDataGridViewTextBoxColumn,
            this.colNameDataGridViewTextBoxColumn,
            this.colDataTypeDataGridViewTextBoxColumn,
            this.colConversionDataGridViewTextBoxColumn,
            this.ColSource,
            this.ColSort});
            this.dataGridViewTemplate.DataMember = "TableVar";
            this.dataGridViewTemplate.DataSource = this.dataSet;
            this.dataGridViewTemplate.Location = new System.Drawing.Point(9, 19);
            this.dataGridViewTemplate.Name = "dataGridViewTemplate";
            this.dataGridViewTemplate.Size = new System.Drawing.Size(749, 329);
            this.dataGridViewTemplate.TabIndex = 12;
            this.dataGridViewTemplate.Leave += new System.EventHandler(this.dataGridViewTemplate_Leave);
            // 
            // groupBoxReferenceFile
            // 
            this.groupBoxReferenceFile.Controls.Add(this.dataGridViewReference);
            this.groupBoxReferenceFile.Controls.Add(this.textBoxDelimeter);
            this.groupBoxReferenceFile.Controls.Add(this.label2);
            this.groupBoxReferenceFile.Controls.Add(this.label1);
            this.groupBoxReferenceFile.Controls.Add(this.buttonSelect);
            this.groupBoxReferenceFile.Controls.Add(this.textSourceFile);
            this.groupBoxReferenceFile.Location = new System.Drawing.Point(250, 2);
            this.groupBoxReferenceFile.Name = "groupBoxReferenceFile";
            this.groupBoxReferenceFile.Size = new System.Drawing.Size(764, 304);
            this.groupBoxReferenceFile.TabIndex = 13;
            this.groupBoxReferenceFile.TabStop = false;
            this.groupBoxReferenceFile.Text = "Reference File";
            // 
            // dataGridViewReference
            // 
            this.dataGridViewReference.AutoGenerateColumns = false;
            this.dataGridViewReference.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReference.DataMember = "TabeRef";
            this.dataGridViewReference.DataSource = this.dataSetReference;
            this.dataGridViewReference.Location = new System.Drawing.Point(8, 69);
            this.dataGridViewReference.Name = "dataGridViewReference";
            this.dataGridViewReference.Size = new System.Drawing.Size(744, 228);
            this.dataGridViewReference.TabIndex = 23;
            // 
            // dataSetReference
            // 
            this.dataSetReference.DataSetName = "NewDataSet";
            this.dataSetReference.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTableRef});
            // 
            // dataTableRef
            // 
            this.dataTableRef.TableName = "TabeRef";
            // 
            // textBoxDelimeter
            // 
            this.textBoxDelimeter.Location = new System.Drawing.Point(123, 43);
            this.textBoxDelimeter.Name = "textBoxDelimeter";
            this.textBoxDelimeter.Size = new System.Drawing.Size(100, 20);
            this.textBoxDelimeter.TabIndex = 22;
            this.textBoxDelimeter.Text = "\\t";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Source Delimeter:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Reference Source File:";
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(707, 18);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(45, 23);
            this.buttonSelect.TabIndex = 19;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // textSourceFile
            // 
            this.textSourceFile.Location = new System.Drawing.Point(123, 19);
            this.textSourceFile.Name = "textSourceFile";
            this.textSourceFile.Size = new System.Drawing.Size(578, 20);
            this.textSourceFile.TabIndex = 18;
            // 
            // colNumDataGridViewTextBoxColumn
            // 
            this.colNumDataGridViewTextBoxColumn.DataPropertyName = "ColNum";
            this.colNumDataGridViewTextBoxColumn.HeaderText = "Col#";
            this.colNumDataGridViewTextBoxColumn.Name = "colNumDataGridViewTextBoxColumn";
            this.colNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.colNumDataGridViewTextBoxColumn.Width = 50;
            // 
            // colNameDataGridViewTextBoxColumn
            // 
            this.colNameDataGridViewTextBoxColumn.DataPropertyName = "ColName";
            this.colNameDataGridViewTextBoxColumn.HeaderText = "Column Name";
            this.colNameDataGridViewTextBoxColumn.Name = "colNameDataGridViewTextBoxColumn";
            this.colNameDataGridViewTextBoxColumn.Width = 175;
            // 
            // colDataTypeDataGridViewTextBoxColumn
            // 
            this.colDataTypeDataGridViewTextBoxColumn.DataPropertyName = "ColDataType";
            this.colDataTypeDataGridViewTextBoxColumn.HeaderText = "Data Type";
            this.colDataTypeDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Text",
            "Integer",
            "Decimal",
            "Currency",
            "Date",
            "Date+Time",
            "Time"});
            this.colDataTypeDataGridViewTextBoxColumn.Name = "colDataTypeDataGridViewTextBoxColumn";
            this.colDataTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDataTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colConversionDataGridViewTextBoxColumn
            // 
            this.colConversionDataGridViewTextBoxColumn.DataPropertyName = "ColConversion";
            this.colConversionDataGridViewTextBoxColumn.HeaderText = "Conversion Method";
            this.colConversionDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Copy Field",
            "Copy Primary Key",
            "Fixed Text",
            "Nickname Conversion",
            "Package Conversion - P0 Option",
            "Package Conversion - P9 Option",
            "Place holder"});
            this.colConversionDataGridViewTextBoxColumn.Name = "colConversionDataGridViewTextBoxColumn";
            this.colConversionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colConversionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colConversionDataGridViewTextBoxColumn.Width = 200;
            // 
            // ColSource
            // 
            this.ColSource.DataPropertyName = "ColSource";
            this.ColSource.HeaderText = "Source Column";
            this.ColSource.Name = "ColSource";
            this.ColSource.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColSort
            // 
            this.ColSort.DataPropertyName = "ColSort";
            this.ColSort.HeaderText = "Sort";
            this.ColSort.Name = "ColSort";
            this.ColSort.Width = 50;
            // 
            // EditTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 733);
            this.Controls.Add(this.groupBoxReferenceFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxTemplateList);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonExit);
            this.Name = "EditTemplateForm";
            this.Text = "Edit Templates";
            this.Load += new System.EventHandler(this.EditTemplateForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditTemplateForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableVar)).EndInit();
            this.groupBoxTemplateList.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemplate)).EndInit();
            this.groupBoxReferenceFile.ResumeLayout(false);
            this.groupBoxReferenceFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableRef)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonDelete;
        private System.Data.DataTable dataTableVar;
        private System.Data.DataColumn dataColumnColNum;
        private System.Data.DataColumn dataColumnName;
        private System.Data.DataColumn dataColumnDataType;
        private System.Data.DataColumn dataColumnConversion;
        public System.Data.DataSet dataSet;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.GroupBox groupBoxTemplateList;
        public System.Windows.Forms.ListBox listBoxTemplates;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewTemplate;
        private System.Windows.Forms.OpenFileDialog openFileDialogReference;
        private System.Windows.Forms.GroupBox groupBoxReferenceFile;
        private System.Windows.Forms.DataGridView dataGridViewReference;
        private System.Windows.Forms.TextBox textBoxDelimeter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.TextBox textSourceFile;
        private System.Data.DataSet dataSetReference;
        private System.Data.DataTable dataTableRef;
        private System.Data.DataColumn dataColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn colDataTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn colConversionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSort;
    }
}