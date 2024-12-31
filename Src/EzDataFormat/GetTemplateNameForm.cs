using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EzDataFormat
{
    /// <summary>
    /// 
    /// </summary>
    public partial class GetTemplateNameForm : Form
    {
        public bool isOK = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTemplateNameForm"/> class.
        /// </summary>
        public GetTemplateNameForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the GetTemplateName control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void GetTemplateName_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the buttonOK control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            isOK = true;
            this.Hide();
        }

        /// <summary>
        /// Handles the Click event of the buttonCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            isOK = false;
            this.Hide();
        }
    }
}
