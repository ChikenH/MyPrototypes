using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPrototype.Browser
{
    /// <summary>
    /// browser form
    /// </summary>
    public sealed partial class BrowserForm : Form
    {
        /// <summary>
        /// browser constructor
        /// </summary>
        public BrowserForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// start button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartBrowserButton_Click(object sender, EventArgs e)
        {
            string target = "http://example.com";
            try
            {
                System.Diagnostics.Process.Start(target);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                {
                    MessageBox.Show(noBrowser.Message);
                }
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }
    }
}
