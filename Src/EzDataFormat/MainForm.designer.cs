namespace EzDataFormat
{
    partial class MainForm
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
            this.folderBrowserDialogMain = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxDatabaseSettings = new System.Windows.Forms.GroupBox();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.buttonSaveToDatabase = new System.Windows.Forms.Button();
            this.labelFileExtension = new System.Windows.Forms.Label();
            this.textFileExtension = new System.Windows.Forms.TextBox();
            this.labelSQLTableName = new System.Windows.Forms.Label();
            this.textTableName = new System.Windows.Forms.TextBox();
            this.labelSQLDatabase = new System.Windows.Forms.Label();
            this.textInitialCatalog = new System.Windows.Forms.TextBox();
            this.labelColumnDelimeter = new System.Windows.Forms.Label();
            this.textColDelimeter = new System.Windows.Forms.TextBox();
            this.labelSQLPassword = new System.Windows.Forms.Label();
            this.labelSQLUser = new System.Windows.Forms.Label();
            this.labelSQLServer = new System.Windows.Forms.Label();
            this.textDatabasePassword = new System.Windows.Forms.TextBox();
            this.textDatabaseUser = new System.Windows.Forms.TextBox();
            this.textDatabaseServer = new System.Windows.Forms.TextBox();
            this.groupBoxDataDirectory = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonLoadTables = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonSelectNone = new System.Windows.Forms.Button();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.checkedListFiles = new System.Windows.Forms.CheckedListBox();
            this.textFolderName = new System.Windows.Forms.TextBox();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.dataGridResults = new System.Windows.Forms.DataGridView();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.labelProgramStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBarLoad = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEditTemplates = new System.Windows.Forms.Button();
            this.comboBoxTemplates = new System.Windows.Forms.ComboBox();
            this.groupBoxMessages = new System.Windows.Forms.GroupBox();
            this.textBoxMessages = new System.Windows.Forms.TextBox();
            this.textBoxTag = new System.Windows.Forms.TextBox();
            this.labelFileTag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableVar)).BeginInit();
            this.menuStripMain.SuspendLayout();
            this.groupBoxDatabaseSettings.SuspendLayout();
            this.groupBoxDataDirectory.SuspendLayout();
            this.groupBoxResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).BeginInit();
            this.statusStripMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxMessages.SuspendLayout();
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
            this.dataTableVar.TableName = "TableVar";
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1018, 24);
            this.menuStripMain.TabIndex = 10;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBoxDatabaseSettings
            // 
            this.groupBoxDatabaseSettings.Controls.Add(this.buttonSaveToFile);
            this.groupBoxDatabaseSettings.Controls.Add(this.buttonSaveToDatabase);
            this.groupBoxDatabaseSettings.Controls.Add(this.labelFileExtension);
            this.groupBoxDatabaseSettings.Controls.Add(this.textFileExtension);
            this.groupBoxDatabaseSettings.Controls.Add(this.labelSQLTableName);
            this.groupBoxDatabaseSettings.Controls.Add(this.textTableName);
            this.groupBoxDatabaseSettings.Controls.Add(this.labelSQLDatabase);
            this.groupBoxDatabaseSettings.Controls.Add(this.textInitialCatalog);
            this.groupBoxDatabaseSettings.Controls.Add(this.labelColumnDelimeter);
            this.groupBoxDatabaseSettings.Controls.Add(this.textColDelimeter);
            this.groupBoxDatabaseSettings.Controls.Add(this.labelSQLPassword);
            this.groupBoxDatabaseSettings.Controls.Add(this.labelSQLUser);
            this.groupBoxDatabaseSettings.Controls.Add(this.labelSQLServer);
            this.groupBoxDatabaseSettings.Controls.Add(this.textDatabasePassword);
            this.groupBoxDatabaseSettings.Controls.Add(this.textDatabaseUser);
            this.groupBoxDatabaseSettings.Controls.Add(this.textDatabaseServer);
            this.groupBoxDatabaseSettings.Enabled = false;
            this.groupBoxDatabaseSettings.Location = new System.Drawing.Point(7, 121);
            this.groupBoxDatabaseSettings.Name = "groupBoxDatabaseSettings";
            this.groupBoxDatabaseSettings.Size = new System.Drawing.Size(297, 220);
            this.groupBoxDatabaseSettings.TabIndex = 18;
            this.groupBoxDatabaseSettings.TabStop = false;
            this.groupBoxDatabaseSettings.Text = "Settings";
            this.groupBoxDatabaseSettings.Visible = false;
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Enabled = false;
            this.buttonSaveToFile.Location = new System.Drawing.Point(154, 106);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(119, 46);
            this.buttonSaveToFile.TabIndex = 33;
            this.buttonSaveToFile.Text = "Save To File";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            // 
            // buttonSaveToDatabase
            // 
            this.buttonSaveToDatabase.Enabled = false;
            this.buttonSaveToDatabase.Location = new System.Drawing.Point(154, 158);
            this.buttonSaveToDatabase.Name = "buttonSaveToDatabase";
            this.buttonSaveToDatabase.Size = new System.Drawing.Size(119, 46);
            this.buttonSaveToDatabase.TabIndex = 32;
            this.buttonSaveToDatabase.Text = "Save To Database";
            this.buttonSaveToDatabase.UseVisualStyleBackColor = true;
            // 
            // labelFileExtension
            // 
            this.labelFileExtension.AutoSize = true;
            this.labelFileExtension.Location = new System.Drawing.Point(6, 184);
            this.labelFileExtension.Name = "labelFileExtension";
            this.labelFileExtension.Size = new System.Drawing.Size(72, 13);
            this.labelFileExtension.TabIndex = 31;
            this.labelFileExtension.Text = "File Extension";
            // 
            // textFileExtension
            // 
            this.textFileExtension.Location = new System.Drawing.Point(101, 181);
            this.textFileExtension.Name = "textFileExtension";
            this.textFileExtension.Size = new System.Drawing.Size(47, 20);
            this.textFileExtension.TabIndex = 30;
            this.textFileExtension.Text = ".TXT";
            // 
            // labelSQLTableName
            // 
            this.labelSQLTableName.AutoSize = true;
            this.labelSQLTableName.Location = new System.Drawing.Point(6, 130);
            this.labelSQLTableName.Name = "labelSQLTableName";
            this.labelSQLTableName.Size = new System.Drawing.Size(89, 13);
            this.labelSQLTableName.TabIndex = 29;
            this.labelSQLTableName.Text = "SQL Table Name";
            // 
            // textTableName
            // 
            this.textTableName.Location = new System.Drawing.Point(101, 127);
            this.textTableName.Name = "textTableName";
            this.textTableName.Size = new System.Drawing.Size(175, 20);
            this.textTableName.TabIndex = 28;
            this.textTableName.Text = "Test";
            // 
            // labelSQLDatabase
            // 
            this.labelSQLDatabase.AutoSize = true;
            this.labelSQLDatabase.Location = new System.Drawing.Point(6, 104);
            this.labelSQLDatabase.Name = "labelSQLDatabase";
            this.labelSQLDatabase.Size = new System.Drawing.Size(77, 13);
            this.labelSQLDatabase.TabIndex = 27;
            this.labelSQLDatabase.Text = "SQL Database";
            // 
            // textInitialCatalog
            // 
            this.textInitialCatalog.Location = new System.Drawing.Point(101, 101);
            this.textInitialCatalog.Name = "textInitialCatalog";
            this.textInitialCatalog.Size = new System.Drawing.Size(175, 20);
            this.textInitialCatalog.TabIndex = 26;
            this.textInitialCatalog.Text = "Test";
            // 
            // labelColumnDelimeter
            // 
            this.labelColumnDelimeter.AutoSize = true;
            this.labelColumnDelimeter.Location = new System.Drawing.Point(6, 158);
            this.labelColumnDelimeter.Name = "labelColumnDelimeter";
            this.labelColumnDelimeter.Size = new System.Drawing.Size(89, 13);
            this.labelColumnDelimeter.TabIndex = 25;
            this.labelColumnDelimeter.Text = "Column Delimeter";
            // 
            // textColDelimeter
            // 
            this.textColDelimeter.Location = new System.Drawing.Point(101, 155);
            this.textColDelimeter.Name = "textColDelimeter";
            this.textColDelimeter.Size = new System.Drawing.Size(47, 20);
            this.textColDelimeter.TabIndex = 24;
            this.textColDelimeter.Text = ",";
            // 
            // labelSQLPassword
            // 
            this.labelSQLPassword.AutoSize = true;
            this.labelSQLPassword.Location = new System.Drawing.Point(6, 76);
            this.labelSQLPassword.Name = "labelSQLPassword";
            this.labelSQLPassword.Size = new System.Drawing.Size(77, 13);
            this.labelSQLPassword.TabIndex = 23;
            this.labelSQLPassword.Text = "SQL Password";
            // 
            // labelSQLUser
            // 
            this.labelSQLUser.AutoSize = true;
            this.labelSQLUser.Location = new System.Drawing.Point(6, 49);
            this.labelSQLUser.Name = "labelSQLUser";
            this.labelSQLUser.Size = new System.Drawing.Size(53, 13);
            this.labelSQLUser.TabIndex = 22;
            this.labelSQLUser.Text = "SQL User";
            // 
            // labelSQLServer
            // 
            this.labelSQLServer.AutoSize = true;
            this.labelSQLServer.Location = new System.Drawing.Point(6, 22);
            this.labelSQLServer.Name = "labelSQLServer";
            this.labelSQLServer.Size = new System.Drawing.Size(62, 13);
            this.labelSQLServer.TabIndex = 21;
            this.labelSQLServer.Text = "SQL Server";
            // 
            // textDatabasePassword
            // 
            this.textDatabasePassword.Location = new System.Drawing.Point(101, 73);
            this.textDatabasePassword.Name = "textDatabasePassword";
            this.textDatabasePassword.PasswordChar = '*';
            this.textDatabasePassword.Size = new System.Drawing.Size(175, 20);
            this.textDatabasePassword.TabIndex = 20;
            // 
            // textDatabaseUser
            // 
            this.textDatabaseUser.Location = new System.Drawing.Point(101, 46);
            this.textDatabaseUser.Name = "textDatabaseUser";
            this.textDatabaseUser.Size = new System.Drawing.Size(175, 20);
            this.textDatabaseUser.TabIndex = 19;
            this.textDatabaseUser.Text = "sa";
            // 
            // textDatabaseServer
            // 
            this.textDatabaseServer.Location = new System.Drawing.Point(101, 19);
            this.textDatabaseServer.Name = "textDatabaseServer";
            this.textDatabaseServer.Size = new System.Drawing.Size(175, 20);
            this.textDatabaseServer.TabIndex = 18;
            this.textDatabaseServer.Text = "(local)";
            // 
            // groupBoxDataDirectory
            // 
            this.groupBoxDataDirectory.Controls.Add(this.buttonCancel);
            this.groupBoxDataDirectory.Controls.Add(this.buttonLoadTables);
            this.groupBoxDataDirectory.Controls.Add(this.buttonSelect);
            this.groupBoxDataDirectory.Controls.Add(this.buttonSelectNone);
            this.groupBoxDataDirectory.Controls.Add(this.buttonSelectAll);
            this.groupBoxDataDirectory.Controls.Add(this.checkedListFiles);
            this.groupBoxDataDirectory.Controls.Add(this.textFolderName);
            this.groupBoxDataDirectory.Location = new System.Drawing.Point(7, 114);
            this.groupBoxDataDirectory.Name = "groupBoxDataDirectory";
            this.groupBoxDataDirectory.Size = new System.Drawing.Size(421, 592);
            this.groupBoxDataDirectory.TabIndex = 19;
            this.groupBoxDataDirectory.TabStop = false;
            this.groupBoxDataDirectory.Text = "Data Directory";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(303, 546);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(91, 39);
            this.buttonCancel.TabIndex = 31;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonLoadTables
            // 
            this.buttonLoadTables.Location = new System.Drawing.Point(204, 546);
            this.buttonLoadTables.Name = "buttonLoadTables";
            this.buttonLoadTables.Size = new System.Drawing.Size(91, 39);
            this.buttonLoadTables.TabIndex = 13;
            this.buttonLoadTables.Text = "Convert Files";
            this.buttonLoadTables.UseVisualStyleBackColor = true;
            this.buttonLoadTables.Click += new System.EventHandler(this.buttonLoadTables_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(372, 15);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(45, 23);
            this.buttonSelect.TabIndex = 12;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonSelectNone
            // 
            this.buttonSelectNone.Location = new System.Drawing.Point(105, 546);
            this.buttonSelectNone.Name = "buttonSelectNone";
            this.buttonSelectNone.Size = new System.Drawing.Size(91, 39);
            this.buttonSelectNone.TabIndex = 11;
            this.buttonSelectNone.Text = "Select None";
            this.buttonSelectNone.UseVisualStyleBackColor = true;
            this.buttonSelectNone.Click += new System.EventHandler(this.buttonSelectNone_Click);
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Location = new System.Drawing.Point(6, 546);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(91, 39);
            this.buttonSelectAll.TabIndex = 10;
            this.buttonSelectAll.Text = "Select All";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // checkedListFiles
            // 
            this.checkedListFiles.FormattingEnabled = true;
            this.checkedListFiles.Location = new System.Drawing.Point(6, 43);
            this.checkedListFiles.Name = "checkedListFiles";
            this.checkedListFiles.Size = new System.Drawing.Size(409, 499);
            this.checkedListFiles.TabIndex = 9;
            // 
            // textFolderName
            // 
            this.textFolderName.Location = new System.Drawing.Point(6, 17);
            this.textFolderName.Name = "textFolderName";
            this.textFolderName.Size = new System.Drawing.Size(360, 20);
            this.textFolderName.TabIndex = 8;
            this.textFolderName.Text = "C:\\";
            this.textFolderName.Validated += new System.EventHandler(this.textFolderName_Validated);
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Controls.Add(this.dataGridResults);
            this.groupBoxResults.Location = new System.Drawing.Point(434, 27);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(572, 386);
            this.groupBoxResults.TabIndex = 20;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Results";
            // 
            // dataGridResults
            // 
            this.dataGridResults.AutoGenerateColumns = false;
            this.dataGridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResults.DataMember = "TableVar";
            this.dataGridResults.DataSource = this.dataSet;
            this.dataGridResults.Location = new System.Drawing.Point(5, 17);
            this.dataGridResults.Name = "dataGridResults";
            this.dataGridResults.Size = new System.Drawing.Size(559, 360);
            this.dataGridResults.TabIndex = 1;
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelProgramStatus,
            this.progressBarLoad});
            this.statusStripMain.Location = new System.Drawing.Point(0, 714);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1018, 22);
            this.statusStripMain.TabIndex = 31;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // labelProgramStatus
            // 
            this.labelProgramStatus.AutoSize = false;
            this.labelProgramStatus.Name = "labelProgramStatus";
            this.labelProgramStatus.Size = new System.Drawing.Size(770, 17);
            this.labelProgramStatus.Text = "Ready.";
            this.labelProgramStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBarLoad
            // 
            this.progressBarLoad.AutoSize = false;
            this.progressBarLoad.Name = "progressBarLoad";
            this.progressBarLoad.Size = new System.Drawing.Size(200, 16);
            this.progressBarLoad.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelFileTag);
            this.groupBox1.Controls.Add(this.textBoxTag);
            this.groupBox1.Controls.Add(this.buttonEditTemplates);
            this.groupBox1.Controls.Add(this.comboBoxTemplates);
            this.groupBox1.Location = new System.Drawing.Point(7, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 84);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Template";
            // 
            // buttonEditTemplates
            // 
            this.buttonEditTemplates.Location = new System.Drawing.Point(371, 18);
            this.buttonEditTemplates.Name = "buttonEditTemplates";
            this.buttonEditTemplates.Size = new System.Drawing.Size(45, 25);
            this.buttonEditTemplates.TabIndex = 34;
            this.buttonEditTemplates.Text = "Edit";
            this.buttonEditTemplates.UseVisualStyleBackColor = true;
            this.buttonEditTemplates.Click += new System.EventHandler(this.buttonEditTemplates_Click);
            // 
            // comboBoxTemplates
            // 
            this.comboBoxTemplates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTemplates.FormattingEnabled = true;
            this.comboBoxTemplates.Location = new System.Drawing.Point(8, 20);
            this.comboBoxTemplates.Name = "comboBoxTemplates";
            this.comboBoxTemplates.Size = new System.Drawing.Size(360, 21);
            this.comboBoxTemplates.TabIndex = 0;
            // 
            // groupBoxMessages
            // 
            this.groupBoxMessages.Controls.Add(this.textBoxMessages);
            this.groupBoxMessages.Location = new System.Drawing.Point(434, 420);
            this.groupBoxMessages.Name = "groupBoxMessages";
            this.groupBoxMessages.Size = new System.Drawing.Size(572, 286);
            this.groupBoxMessages.TabIndex = 35;
            this.groupBoxMessages.TabStop = false;
            this.groupBoxMessages.Text = "Messages";
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.BackColor = System.Drawing.Color.White;
            this.textBoxMessages.Location = new System.Drawing.Point(7, 18);
            this.textBoxMessages.Multiline = true;
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.ReadOnly = true;
            this.textBoxMessages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMessages.Size = new System.Drawing.Size(557, 259);
            this.textBoxMessages.TabIndex = 0;
            this.textBoxMessages.WordWrap = false;
            // 
            // textBoxTag
            // 
            this.textBoxTag.Location = new System.Drawing.Point(57, 47);
            this.textBoxTag.Name = "textBoxTag";
            this.textBoxTag.Size = new System.Drawing.Size(360, 20);
            this.textBoxTag.TabIndex = 35;
            // 
            // labelFileTag
            // 
            this.labelFileTag.AutoSize = true;
            this.labelFileTag.Location = new System.Drawing.Point(6, 50);
            this.labelFileTag.Name = "labelFileTag";
            this.labelFileTag.Size = new System.Drawing.Size(48, 13);
            this.labelFileTag.TabIndex = 36;
            this.labelFileTag.Text = "File Tag:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 736);
            this.Controls.Add(this.groupBoxMessages);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.groupBoxResults);
            this.Controls.Add(this.groupBoxDataDirectory);
            this.Controls.Add(this.groupBoxDatabaseSettings);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EzDataFormat";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableVar)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.groupBoxDatabaseSettings.ResumeLayout(false);
            this.groupBoxDatabaseSettings.PerformLayout();
            this.groupBoxDataDirectory.ResumeLayout(false);
            this.groupBoxDataDirectory.PerformLayout();
            this.groupBoxResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).EndInit();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxMessages.ResumeLayout(false);
            this.groupBoxMessages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.DataSet dataSet;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogMain;
        private System.Data.DataTable dataTableVar;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.GroupBox groupBoxDatabaseSettings;
        private System.Windows.Forms.Label labelSQLDatabase;
        private System.Windows.Forms.TextBox textInitialCatalog;
        private System.Windows.Forms.Label labelColumnDelimeter;
        private System.Windows.Forms.TextBox textColDelimeter;
        private System.Windows.Forms.Label labelSQLPassword;
        private System.Windows.Forms.Label labelSQLUser;
        private System.Windows.Forms.Label labelSQLServer;
        private System.Windows.Forms.TextBox textDatabasePassword;
        private System.Windows.Forms.TextBox textDatabaseUser;
        private System.Windows.Forms.TextBox textDatabaseServer;
        private System.Windows.Forms.Label labelSQLTableName;
        private System.Windows.Forms.TextBox textTableName;
        private System.Windows.Forms.GroupBox groupBoxDataDirectory;
        private System.Windows.Forms.CheckedListBox checkedListFiles;
        private System.Windows.Forms.TextBox textFolderName;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.DataGridView dataGridResults;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel labelProgramStatus;
        private System.Windows.Forms.ToolStripProgressBar progressBarLoad;
        private System.Windows.Forms.Label labelFileExtension;
        private System.Windows.Forms.TextBox textFileExtension;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.Button buttonSelectNone;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.Button buttonSaveToDatabase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxTemplates;
        private System.Windows.Forms.Button buttonEditTemplates;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.GroupBox groupBoxMessages;
        private System.Windows.Forms.TextBox textBoxMessages;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonLoadTables;
        private System.Windows.Forms.Label labelFileTag;
        private System.Windows.Forms.TextBox textBoxTag;
    }
}

