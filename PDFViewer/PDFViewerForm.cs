using Microsoft.Web.WebView2.Core;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace MyPrototype.PDFViewer
{
    /// <summary>
    /// pdf viewer
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
        /// Web2View showDialog
        /// </summary>
        private void _StartViewer()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "PDFファイル(*.pdf)|*.pdf";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // FixMe: System.InvalidOperationException 'The method EnsureCoreWebView2Async can be invoked only from the UI thread.'
                    this.ViewerWebView2.Source = new Uri(ofd.FileName);
                }
            }
        }

        /// <summary>
        /// view button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WebView2Button_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(_StartViewer);
            t.TrySetApartmentState(ApartmentState.STA);
            t.Start();
        }
    }
}
