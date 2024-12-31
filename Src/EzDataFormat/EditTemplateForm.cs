using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace EzDataFormat
{
    public partial class EditTemplateForm : Form
    {
        public const string TemplateFolder = "Templates";
        public const string TemplateListFile = "TemplateList.txt";
        public const string DefaultTemplateFile = "Default Template File";
        public const string TemplateFileExt = ".xml";
        public const char TemplateDelimeter = '|';

        /// <summary>
        /// Initializes a new instance of the <see cref="EditTemplateForm"/> class.
        /// </summary>
        public EditTemplateForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the EditTemplateForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void EditTemplateForm_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the Click event of the buttonExit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            WriteTemplate();
            WriteTemplateList();
            this.Hide();
        }

        /// <summary>
        /// Handles the FormClosing event of the EditTemplateForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.FormClosingEventArgs"/> instance containing the event data.</param>
        private void EditTemplateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteTemplate();
            WriteTemplateList();
            this.Hide();
        }

        /// <summary>
        /// Handles the Click event of the buttonNew control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonNew_Click(object sender, EventArgs e)
        {
            try
            {
                GetTemplateNameForm getName = new GetTemplateNameForm();
                getName.ShowDialog();
                string tempname = getName.textBoxTemplateName.Text.Trim();
                if (getName.isOK && tempname != "")
                {
                    AddNewTemplate(tempname);
                }
                else
                {
                    tempname = this.listBoxTemplates.SelectedItem.ToString();
                }
            }
            catch (Exception Ex)
            {
                Trace.WriteLine("Error: " + Ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the buttonDelete control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.listBoxTemplates.SelectedItem != null)
                {
                    if (MessageBox.Show("Are you sure?", "Delete " + this.listBoxTemplates.SelectedItem.ToString() + "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        if (File.Exists(this.listBoxTemplates.SelectedItem.ToString() + TemplateFileExt))
                        {
                            File.Delete(this.listBoxTemplates.SelectedItem.ToString() + TemplateFileExt);
                        }
                        this.listBoxTemplates.Items.RemoveAt(this.listBoxTemplates.SelectedIndex);
                        WriteTemplateList();
                    }
                }
            }
            catch (Exception Ex)
            {
                Trace.WriteLine("Error: " + Ex.Message);
            }

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
                // Open Reference File and load combo
                openFileDialogReference.RestoreDirectory = true;
                openFileDialogReference.ShowDialog();
                if (openFileDialogReference.FileName != "")
                {
                    LoadReferenceFile(openFileDialogReference.FileName);
                }
            }
            catch (Exception Ex)
            {
                Trace.WriteLine("Error: " + Ex.Message);
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the listBoxTemplates control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void listBoxTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBoxTemplates.SelectedItem != null)
                {
                    ReadTemplate(listBoxTemplates.SelectedItem.ToString().Trim() + TemplateFileExt);
                }
            }
            catch (Exception Ex)
            {
                Trace.WriteLine("Error: " + Ex.Message);
            }
        }

        /// <summary>
        /// Handles the Leave event of the dataGridViewTemplate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void dataGridViewTemplate_Leave(object sender, EventArgs e)
        {
            WriteTemplate();
        }

        /// <summary>
        /// Loads the reference file.
        /// </summary>
        /// <param name="FileName">Name of the file.</param>
        private void LoadReferenceFile(string FileName)
        {
            try
            {
                using (StreamReader rdr = new StreamReader(FileName))
                {
                    bool IsTableReady = false;
                    //rownum = 0;
                    dataSetReference.Tables[0].Clear();
                    DataRow row;
                    while (!rdr.EndOfStream)
                    {
                        string rawdata = rdr.ReadLine();
                        rawdata = rawdata.Replace(",", " ");
                        string[] Cols = rawdata.Split('\t');

                        if (!IsTableReady)
                        {
                            for (int ColNum = 0; ColNum < Cols.Length; ColNum++)
                            {
                                dataSetReference.Tables[0].Columns.Add(ColNum.ToString());
                            }
                            IsTableReady = true;
                        }

                        row = dataSetReference.Tables[0].NewRow();

                        for (int ColNum = 0; ColNum < Cols.Length; ColNum++)
                        {
                            row[ColNum] = Cols[ColNum];

                        }
                        dataSetReference.Tables[0].Rows.Add(row);

                        Application.DoEvents();
                    }
                    this.textSourceFile.Text = FileName;
                    dataGridViewReference.AutoGenerateColumns = true;
                    dataGridViewReference.DataSource = dataSetReference.Tables[0];
                    dataGridViewReference.Refresh();
                }
            }
            catch (Exception Ex)
            {
                Trace.WriteLine("Error: " + Ex.Message);
            }
        }


        /// <summary>
        /// Clears the data grid.
        /// </summary>
        private void ClearDataGrid()
        {
            try
            {
                // |||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
                // BEGIN SPECIAL CODE SECTION
                // DO NOT CHANGE THE ORDER OF THE FOLLOWING LINES - THE EXTRA STEP/SEED CODE
                // IS NEEDED DUE TO A BUG IN THE .NET FRAMEWORK!  THE AUTOINCREMENT COLUMN VALUE
                // WILL NOT RESET UNLESS THE STEP/SEED PROPERTIES ARE CHANGED TWICE AFTER CLEARING
                // THE ROWS IN THE DATATABLE!
                dataSet.Tables[0].Rows.Clear();
                dataSet.Tables[0].AcceptChanges();
                dataSet.Tables[0].Columns[0].AutoIncrementStep = -1;
                dataSet.Tables[0].Columns[0].AutoIncrementSeed = -1;
                dataSet.Tables[0].Columns[0].AutoIncrementStep = 1;
                dataSet.Tables[0].Columns[0].AutoIncrementSeed = 1;
                // END SPECIAL CODE SECTION
                // |||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
            }
            catch (Exception Ex)
            {
                Trace.WriteLine("Error: " + Ex.Message);
            }
        }

        /// <summary>
        /// Adds the new template.
        /// </summary>
        /// <param name="TemplateName">Name of the template.</param>
        private void AddNewTemplate(string TemplateName)
        {
            try
            {
                this.listBoxTemplates.Items.Add(TemplateName);
                ClearDataGrid();
                this.listBoxTemplates.SelectedItem = TemplateName;
                WriteTemplate();
                dataGridViewTemplate.Refresh();
                this.WriteTemplateList();
            }
            catch (Exception Ex)
            {
                Trace.WriteLine("Error: " + Ex.Message);
            }
        }

        /// <summary>
        /// Reads the template list.
        /// </summary>
        public void ReadTemplateList()
        {
            try
            {
                this.listBoxTemplates.Items.Clear();
                if (File.Exists(GetFolder() + TemplateListFile))
                {
                    string[] items = File.ReadAllText(GetFolder() + TemplateListFile).Split(TemplateDelimeter);
                    if (items.Length > 0)
                    {
                        for (int i = 0; i < items.Length; i++)
                        {
                            if (items[i].Length > 0)
                                this.listBoxTemplates.Items.Add(items[i]);
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Trace.WriteLine("Error: " + Ex.Message);
            }
        }

        /// <summary>
        /// Writes the template list.
        /// </summary>
        public void WriteTemplateList()
        {
            try
            {
                string outtext = "";
                for (int i = 0; i < this.listBoxTemplates.Items.Count; i++)
                    outtext = outtext + this.listBoxTemplates.Items[i].ToString() + TemplateDelimeter;
                if (File.Exists(GetFolder() + TemplateListFile))
                {
                    File.Delete(GetFolder() + TemplateListFile);
                }
                File.WriteAllText(GetFolder() + TemplateListFile, outtext);
            }
            catch (Exception Ex)
            {
                Trace.WriteLine("Error: " + Ex.Message);
            }
        }

        /// <summary>
        /// Reads the template.
        /// </summary>
        /// <param name="FileName">Name of the file.</param>
        public void ReadTemplate(string FileName)
        {
            try
            {
                if (File.Exists(GetFolder() + FileName))
                {
                    ClearDataGrid();
                    dataSet.Tables[0].ReadXml(GetFolder() + FileName);
                    this.dataGridViewTemplate.Refresh();
                }
            }
            catch (Exception Ex)
            {
                Trace.WriteLine("Error: " + Ex.Message);
            }
        }

        /// <summary>
        /// Writes the template.
        /// </summary>
        public void WriteTemplate()
        {
            try
            {
                if (listBoxTemplates.SelectedItem != null)
                {
                    dataSet.Tables[0].WriteXml(GetFolder() + this.listBoxTemplates.SelectedItem + TemplateFileExt);
                }
            }
            catch (Exception Ex)
            {
                Trace.WriteLine("Error: " + Ex.Message);
            }
        }

        /// <summary>
        /// Setup this instance.
        /// </summary>
        public void Setup()
        {
            try
            {
                // Create the application folder if it does not exist
                if (!Directory.Exists(GetFolder()))
                {
                    Directory.CreateDirectory(GetFolder());
                }

                ReadTemplateList();

                // Create the Default template file if it does not exist
                if (!File.Exists(GetFolder() + DefaultTemplateFile + TemplateFileExt))
                {
                    AddNewTemplate(DefaultTemplateFile);
                }
            }
            catch (Exception Ex)
            {
                Trace.WriteLine("Error: " + Ex.Message);
            }
        }

        /// <summary>
        /// Gets the folder.
        /// </summary>
        /// <returns></returns>
        public string GetFolder()
        {
            return (TemplateFolder + @"\");
        }

    }
}
