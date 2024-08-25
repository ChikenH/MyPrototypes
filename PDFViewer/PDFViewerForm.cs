using Microsoft.Web.WebView2.Core;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace MyPrototype.PDFViewer
{
    /// <summary>
    /// pdf viewer form
    /// </summary>
    public sealed partial class PDFViewerForm : Form
    {
        /// <summary>
        /// pdf viewer constructor
        /// </summary>
        public PDFViewerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// view button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WebView2Button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "PDFファイル(*.pdf)|*.pdf";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    this.ViewerWebView2.Source = new Uri(ofd.FileName);
                }
            }
        }
    }
}
