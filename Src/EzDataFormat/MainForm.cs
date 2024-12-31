using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using EzDataFormat.Properties;

namespace EzDataFormat
{
    /// <summary>
    /// This is the main form for the application.
    /// </summary>
    public partial class MainForm : Form
    {
        private bool IsCancelled = false;                       // Flag to handle cancel button and Escape Key
        private TextBoxTraceListener listen;                    // ServiceUtilities
        private EditTemplateForm TemplateForm = new EditTemplateForm(); // Form to edit templates
        Settings set = Settings.Default;

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="FileLoadMain"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            listen = new TextBoxTraceListener(textBoxMessages);
            Trace.Listeners.Add(listen);
        }
        #endregion

        #region Events
        /// <summary>
        /// Handles the Load event of the FileLoadMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            checkedListFiles.Items.Clear();
            this.Text = "EzDataFormat v" + Application.ProductVersion;
            TemplateForm.Setup();
            this.textFolderName.Text = GetCurrentPath();
            LoadFileList();
        }

        /// <summary>
        /// Handles the Activated event of the MainForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void MainForm_Activated(object sender, EventArgs e)
        {
            string CurItem = "";
            if (comboBoxTemplates.SelectedItem != null) CurItem = comboBoxTemplates.SelectedItem.ToString();
            comboBoxTemplates.Items.Clear();
            for (int i = 0; i < TemplateForm.listBoxTemplates.Items.Count; i++)
            {
                comboBoxTemplates.Items.Add(TemplateForm.listBoxTemplates.Items[i]);
            }
            comboBoxTemplates.Refresh();
            if (CurItem != "") comboBoxTemplates.SelectedItem = CurItem;
            else
            {
                if (comboBoxTemplates.Items.Count > 0) comboBoxTemplates.SelectedItem = comboBoxTemplates.Items[0].ToString();
            }
        }

        /// <summary>
        /// Handles the Click event of the exitToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit program", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Application.Exit();
        }

        /// <summary>
        /// Handles the Click event of the buttonSelect control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            try
            {
                folderBrowserDialogMain.SelectedPath = GetCurrentPath();
                folderBrowserDialogMain.ShowDialog();
                if (folderBrowserDialogMain.SelectedPath != "")
                {
                    this.textFolderName.Text = folderBrowserDialogMain.SelectedPath;
                    LoadFileList();
                }
            }
            catch (Exception ex) { Trace.WriteLine(ex.Message); }
        }

        /// <summary>
        /// Handles the Click event of the buttonLoadTables control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonLoadTables_Click(object sender, EventArgs e)
        {
            LoadFilesIntoDataTable();
        }

        /// <summary>
        /// Handles the Click event of the buttonSaveToFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            // SaveDataTableToFile();
        }

        /// <summary>
        /// Handles the Click event of the buttonSaveToDatabase control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonSaveToDatabase_Click(object sender, EventArgs e)
        {
            SaveDataTableToDatabase();
        }

        /// <summary>
        /// Handles the Click event of the buttonEditTemplates control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonEditTemplates_Click(object sender, EventArgs e)
        {
            TemplateForm.ShowDialog();
        }


        /// <summary>
        /// Handles the Click event of the buttonCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            IsCancelled = true;
        }

        /// <summary>
        /// Handles the Validated event of the textFolderName control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void textFolderName_Validated(object sender, EventArgs e)
        {
            LoadFileList();
        }

        /// <summary>
        /// Handles the Click event of the buttonSelectAll control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            for (int itm = 0; itm < checkedListFiles.Items.Count; itm++)
                checkedListFiles.SetItemChecked(itm, true);
        }

        /// <summary>
        /// Handles the Click event of the buttonSelectNone control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonSelectNone_Click(object sender, EventArgs e)
        {
            for (int itm = 0; itm < checkedListFiles.Items.Count; itm++)
                checkedListFiles.SetItemChecked(itm, false);
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Loads the files into data table.
        /// </summary>
        private void LoadFilesIntoDataTable()
        {
            int LoadedFiles = 0;
            int CurFile = 0;

            this.textBoxMessages.Text = "";

            // Validate the current template
            if (comboBoxTemplates.SelectedItem == null)
            {
                MessageBox.Show("Please select a template.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Set the current template
            TemplateForm.listBoxTemplates.SelectedItem = this.comboBoxTemplates.SelectedItem;

            if (TemplateForm.dataSet.Tables[0].Rows.Count < 1)
            {
                MessageBox.Show("The template columns are not defined.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                DirectoryInfo dir = new DirectoryInfo(this.textFolderName.Text);
                progressBarLoad.Minimum = 0;
                progressBarLoad.Visible = true;
                progressBarLoad.Value = 0;
                progressBarLoad.Maximum = checkedListFiles.Items.Count;
                IsCancelled = false;
                buttonCancel.Visible = true;

                Trace.WriteLine("Starting conversion on " + checkedListFiles.Items.Count.ToString().Trim() + " files.");

                this.SetCurrentPath(this.textFolderName.Text);

                foreach (FileInfo fil in dir.GetFiles("*" + textFileExtension.Text))
                {
                    CurFile++;
                    progressBarLoad.Value = CurFile;
                    labelProgramStatus.Text = LoadedFiles.ToString() + " / " + CurFile.ToString() + " files loaded. " + dataTableVar.Rows.Count.ToString() + " Rows added.";
                    checkedListFiles.SetSelected(CurFile - 1, true);
                    if (checkedListFiles.GetItemChecked(CurFile - 1) == true)
                    {
                        ConvertDataFile(fil);
                        LoadedFiles++;
                    }
                    if (IsCancelled)
                    {
                        if (MessageBox.Show("Are you sure?", "CANCEL", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            break;
                    }
                }

                MessageBox.Show("The process completed.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } catch (Exception ex) 
            {
                Trace.WriteLine("Error: " + ex.Message);
            }

            progressBarLoad.Visible = false;
            buttonCancel.Visible = false;
        }

        /// <summary>
        /// Converts the data file.
        /// </summary>
        /// <param name="fil">The fil.</param>
        private void ConvertDataFile(FileInfo fil)
        {
            try
            {
                int rownum = 0;
                bool IsTableReady = false;
                DataRow newrow;
                dataTableVar = null;
                dataTableVar = new DataTable();

                Trace.WriteLine("========================================");
                Trace.WriteLine("Converting: " + fil.FullName);
                Trace.Indent();
                Trace.WriteLine("Template: " + this.comboBoxTemplates.SelectedItem.ToString());
                using (StreamReader rdr = new StreamReader(fil.FullName))
                {
                    rownum = 0;
                    while (!rdr.EndOfStream)
                    {
                        bool AddRow = false;
                        string rawdata = rdr.ReadLine();
                        rawdata = rawdata.Replace(",", " ");
                        string[] Cols = rawdata.Split('\t');
                        Application.DoEvents();

                        if ((rownum == 0) && (!IsTableReady))         // The first row is assumed to be a header row
                        {
                            // Add Columns and headers based on selected template
                            for (int colnum = 0; colnum <= TemplateForm.dataSet.Tables[0].Rows.Count - 1; colnum++)
                                dataTableVar.Columns.Add(TemplateForm.dataSet.Tables[0].Rows[colnum].ItemArray[1].ToString().Trim());
                            IsTableReady = true;
                        }

                        newrow = dataTableVar.NewRow();

                        // Process each column according to template
                        for (int colnum = 0; colnum <= TemplateForm.dataSet.Tables[0].Rows.Count - 1; colnum++)
                        {
                            int SourceCol = 0;
                            if (TemplateForm.dataSet.Tables[0].Rows[colnum].ItemArray[4].ToString() != "")
                            {
                                int result = 0;
                                if (int.TryParse(TemplateForm.dataSet.Tables[0].Rows[colnum].ItemArray[4].ToString(), out result))
                                    SourceCol = int.Parse(TemplateForm.dataSet.Tables[0].Rows[colnum].ItemArray[4].ToString());
                            }

                            switch (TemplateForm.dataSet.Tables[0].Rows[colnum].ItemArray[3].ToString())
                            {
                                case "Place holder":
                                    break;
                                case "Copy Field":
                                    {
                                        if (Cols[SourceCol].Length > 254) Cols[SourceCol] = Cols[SourceCol].Substring(0, 254);
                                        newrow[colnum] = Cols[SourceCol];
                                        break;
                                    }
                                case "Copy Primary Key":
                                    {
                                        if (Cols[SourceCol].Length > 1)
                                        {
                                            newrow[colnum] = Cols[SourceCol];
                                            AddRow = true;
                                        }
                                        break;
                                    }
                                case "Fixed Text":
                                    {
                                        string FixedText = TemplateForm.dataSet.Tables[0].Rows[colnum].ItemArray[4].ToString();
                                        switch (FixedText.ToUpper())
                                        {
                                            case "[FILE TAG]":
                                                newrow[colnum] = this.textBoxTag.Text.Trim();
                                                break;
                                            case "[FILE NAME]":
                                                newrow[colnum] = fil.Name;
                                                break;
                                            case "[FILE TIME]":
                                                newrow[colnum] = fil.CreationTime.ToShortTimeString();
                                                break;
                                            case "[FILE PATH]":
                                                newrow[colnum] = fil.DirectoryName;
                                                break;
                                            case "[FILE FULLNAME]":
                                                newrow[colnum] = fil.FullName;
                                                break;
                                            case "[FILE LENGTH]":
                                                newrow[colnum] = fil.Length.ToString();
                                                break;
                                            case "[DATE]":
                                                newrow[colnum] = System.DateTime.Now.ToShortDateString();
                                                break;
                                            case "[TIME]":
                                                newrow[colnum] = System.DateTime.Now.ToShortTimeString();
                                                break;
                                            case "[DATETIME]":
                                                newrow[colnum] = System.DateTime.Now.ToLongTimeString();
                                                break;
                                            case "[YEAR]":
                                                newrow[colnum] = System.DateTime.Now.Year.ToString();
                                                break;
                                            case "[RECORD NUMBER]":
                                                newrow[colnum] = rownum.ToString().Trim();
                                                break;
                                            case "[ROW NUMBER]":
                                                newrow[colnum] = rownum.ToString().Trim();
                                                break;
                                            case "[TEMPLATE]":
                                                newrow[colnum] = this.comboBoxTemplates.SelectedItem.ToString();
                                                break;
                                            default:
                                                newrow[colnum] = FixedText;
                                                break;
                                        }
                                        break;
                                    }
                                case "Nickname Conversion":
                                    {
                                        // If the nickname column is empty, copy the first name column into it
                                        if (SourceCol >= Cols.Length)
                                        {
                                            Trace.WriteLine("Error on record# " + rownum.ToString() + " NickName column not in source.");
                                        }
                                        else
                                        {
                                            if (Cols[SourceCol] == "")
                                            {
                                                // Get the source column with the "First Name" caption
                                                int FirstNameCol = 0;
                                                for (int fncolnum = 0; fncolnum <= TemplateForm.dataSet.Tables[0].Rows.Count - 1; fncolnum++)
                                                {
                                                    if (TemplateForm.dataSet.Tables[0].Rows[fncolnum].ItemArray[1].ToString().Trim() == "First Name")
                                                    {
                                                        if (TemplateForm.dataSet.Tables[0].Rows[fncolnum].ItemArray[4].ToString() != "")
                                                        {
                                                            int result = 0;
                                                            if (int.TryParse(TemplateForm.dataSet.Tables[0].Rows[fncolnum].ItemArray[4].ToString(), out result))
                                                                FirstNameCol = int.Parse(TemplateForm.dataSet.Tables[0].Rows[fncolnum].ItemArray[4].ToString());
                                                        }
                                                    }
                                                }
                                                newrow[colnum] = Cols[FirstNameCol].Trim();
                                            }
                                            else
                                            {
                                                newrow[colnum] = Cols[SourceCol];
                                            }
                                        }
                                        break;
                                    }
                                case "Package Conversion - P0 Option":
                                    {
                                        string PackageOptionString = "P0";
                                        string PackageOptionStringAdd = "0-1;";
                                        string[] pkgs = Cols[SourceCol].Split('/');
                                        string newpkg = string.Empty;
                                        if (pkgs.Length > 0)
                                        {
                                            for (int pkgnum = 0; pkgnum < pkgs.Length; pkgnum++)
                                            {
                                                if (pkgs[pkgnum].Length > 0)
                                                {
                                                    if (pkgs[pkgnum] == PackageOptionString)   // If next pkg is starts with a "P" - add option to the last package
                                                    {
                                                        newpkg = newpkg.Substring(0, newpkg.Length - 3) + PackageOptionStringAdd;
                                                    }
                                                    else
                                                    {
                                                        newpkg += pkgs[pkgnum].Substring(1) + "-1;";
                                                    }
                                                }
                                            }
                                        }
                                        newrow[colnum] = newpkg;

                                        // Put X in Custom8 column if there is an X in the package string
                                        if (Cols[SourceCol].IndexOf("X") > 0)
                                        {
                                            int Cust8col = GetCustom8Col();
                                            if (Cust8col > 0)
                                                newrow[Cust8col] = "X";
                                        }

                                        break;
                                    }
                                case "Package Conversion - P9 Option":
                                    {
                                        string PackageOptionString = "P9";
                                        string PackageOptionStringAdd = "9-1;";
                                        string[] pkgs = Cols[SourceCol].Split('/');
                                        string newpkg = string.Empty;
                                        if (pkgs.Length > 0)
                                        {
                                            for (int pkgnum = 0; pkgnum < pkgs.Length; pkgnum++)
                                            {
                                                if (pkgs[pkgnum].Length > 0)
                                                {
                                                    if (pkgs[pkgnum] == PackageOptionString)   // If next pkg is starts with a "P" - add option to the last package
                                                    {
                                                        newpkg = newpkg.Substring(0, newpkg.Length - 3) + PackageOptionStringAdd;
                                                    }
                                                    else
                                                    {
                                                        newpkg += pkgs[pkgnum].Substring(1) + "-1;";
                                                    }
                                                }
                                            }
                                        }
                                        newrow[colnum] = newpkg;

                                        // Put X in Custom8 column if there is an X in the package string
                                        if (Cols[SourceCol].IndexOf("X") > 0)
                                        {
                                            int Cust8col = GetCustom8Col();
                                            if (Cust8col > 0)
                                                newrow[Cust8col] = "X";
                                        }

                                        break;
                                    }
                                default:
                                    {
                                        break;
                                    }
                            }
                        }


                        // If there is a primary key
                        if (AddRow)
                        {
                            dataTableVar.Rows.Add(newrow);
                        }
                    EXIT_LOOP:
                        rownum++;
                    }
                }

                dataGridResults.AutoGenerateColumns = true;
                dataGridResults.DataSource = dataTableVar;

                // Sort the data grid
                string SortCol = "";
                for (int colnum = 0; colnum <= TemplateForm.dataSet.Tables[0].Rows.Count - 1; colnum++)
                {
                    if (TemplateForm.dataSet.Tables[0].Rows[colnum].ItemArray[5].ToString().Trim() == "1")
                        SortCol = TemplateForm.dataSet.Tables[0].Rows[colnum].ItemArray[1].ToString().Trim();
                }

                if (SortCol != "")
                {
                    Trace.WriteLine("Sort Column: " + SortCol);
                    dataGridResults.Sort(dataGridResults.Columns[SortCol], ListSortDirection.Ascending);
                }
                SaveDataTableToFile(fil.FullName + ".csv", SortCol);

                Trace.Unindent();
                Trace.WriteLine("========================================");
            }
            catch (Exception Ex)
            {
                Trace.WriteLine("Error: " + Ex.Message);
            }
        }

        /// <summary>
        /// Saves the data table to file.
        /// </summary>
        private void SaveDataTableToFile(string sFileName, string SortCol)
        {
            Trace.WriteLine("Saving To: " + sFileName);
            try
            {
                // saveFile.ShowDialog();
                if (sFileName != "")
                {
                    //progressBarLoad.Visible = true;
                    buttonCancel.Visible = true;

                    DataRow[] rows;

                    rows = dataTableVar.Select("", SortCol);


                    using (StreamWriter wrt = new StreamWriter(sFileName))
                    {
                        string outstring = string.Empty;
                        //progressBarLoad.Value = 0;
                        //progressBarLoad.Maximum = rows.Length;
                        int CurRow = 0;
                        IsCancelled = false;

                        // Write the row headers
                        for (int Colnum = 0; Colnum < dataTableVar.Columns.Count; Colnum++)
                            wrt.Write(dataTableVar.Columns[Colnum].Caption + ",");
                        wrt.Write(Environment.NewLine);


                        foreach (DataRow Row in rows)
                        {
                            outstring = string.Empty;
                            for (int col = 0; col < Row.ItemArray.Length; col++)
                                outstring += Row[col].ToString().Trim() + (col < Row.ItemArray.Length - 1 ? "," : "");
                            wrt.Write(outstring + Environment.NewLine);
                            if (CurRow % 10 == 0) labelProgramStatus.Text = CurRow.ToString() + " Rows saved.";
                            //progressBarLoad.Value = ++CurRow;
                            Application.DoEvents();
                            if (IsCancelled)
                            {
                                if (MessageBox.Show("Are you sure?", "CANCEL", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                                    break;
                            }
                        }
                    }
                    // MessageBox.Show("The process completed.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } 
            catch (Exception ex) 
            {
                Trace.WriteLine("Error: " + ex.Message);
            }
           // progressBarLoad.Visible = false;
            buttonCancel.Visible = false;
        }

        /// <summary>
        /// Saves the data table to database.
        /// </summary>
        private void SaveDataTableToDatabase()
        {
            SqlConnectionStringBuilder bld = new SqlConnectionStringBuilder();
            bld.DataSource = textDatabaseServer.Text.Trim();
            bld.UserID = textDatabaseUser.Text.Trim();
            bld.Password = textDatabasePassword.Text.Trim();
            bld.InitialCatalog = textInitialCatalog.Text.Trim();

            progressBarLoad.Visible = true;
            buttonCancel.Visible = true;
            using (SqlConnection cnn = new SqlConnection(bld.ConnectionString))
            {
                Application.DoEvents();
                try
                {
                    cnn.Open();
                } catch (Exception ex) { labelProgramStatus.Text = "Error: " + ex.Message; }
                // Create the destination table
                string cmd = "CREATE TABLE " + textTableName.Text.Trim() + " (";
                foreach (DataColumn col in dataTableVar.Columns)
                    cmd += col.ColumnName + " nvarchar(255) null,";
                cmd = cmd.Substring(0, cmd.Length - 1) + ")";

                try
                {
                    new SqlCommand(cmd, cnn).ExecuteNonQuery();
                } catch (Exception ex) { labelProgramStatus.Text = "Error: " + ex.Message; }
                progressBarLoad.Value = 0;
                progressBarLoad.Maximum = dataTableVar.Rows.Count;
                IsCancelled = false;
                Application.DoEvents();
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(bld.ConnectionString))
                {
                    bulkCopy.BatchSize = 500;
                    bulkCopy.NotifyAfter = 1000;
                    bulkCopy.SqlRowsCopied += new SqlRowsCopiedEventHandler(s_SqlRowsCopied);
                    bulkCopy.DestinationTableName = textTableName.Text.Trim();
                    try
                    {
                        bulkCopy.WriteToServer(dataTableVar);
                    }
                    catch (Exception ex) { labelProgramStatus.Text = "Error: " + ex.Message; }
                }
                buttonCancel.Visible = false;
                progressBarLoad.Visible = false;
                MessageBox.Show("The process completed.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Handles the SqlRowsCopied event of the ADO SQL Bulk Copy Object
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Data.SqlClient.SqlRowsCopiedEventArgs"/> instance containing the event data.</param>
        void s_SqlRowsCopied(object sender, SqlRowsCopiedEventArgs e)
        { 
            Application.DoEvents();
            progressBarLoad.Value = (int)e.RowsCopied;
            labelProgramStatus.Text = e.RowsCopied.ToString() + " Rows copied.";
            if (IsCancelled)
            {
                if (MessageBox.Show("Are you sure?", "CANCEL", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    e.Abort = true;
            }
        }

        /// <summary>
        /// Loads the file list.
        /// </summary>
        private void LoadFileList()
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(this.textFolderName.Text);
                checkedListFiles.Items.Clear();
                checkedListFiles.Items.AddRange(dir.GetFiles("*" + textFileExtension.Text));

                for (int i = 0; i < checkedListFiles.Items.Count; i++)
                {
                    checkedListFiles.SetItemChecked(i, true);
                }

            }
            catch (Exception ex) 
            {
                Trace.WriteLine("Error: " + ex.Message);
            }
        }

        private string GetCurrentPath()
        {
            string PathName = @"C:\";
            try
            {
                PathName = set.CurrentPath;
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Error: " + ex.Message);
            }
            return (PathName);
        }

        private void SetCurrentPath(string PathName)
        {
            try
            {
                set.CurrentPath = PathName;
                set.Save();
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Error: " + ex.Message);
            }
        }

        private int GetCustom8Col()
        {
            // Get the source column with the "First Name" caption
            int Custom8Col = 0;
            for (int fncolnum = 0; fncolnum <= TemplateForm.dataSet.Tables[0].Rows.Count - 1; fncolnum++)
            {
                if (TemplateForm.dataSet.Tables[0].Rows[fncolnum].ItemArray[1].ToString().Trim() == "Custom8")
                {
                    Custom8Col = fncolnum;
                }
            }
            return (Custom8Col);
        }

        #endregion
    }
}