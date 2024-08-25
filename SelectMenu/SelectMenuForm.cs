using MyPrototype.CountdownTimer.view;
using MyPrototype.PDFViewer;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPrototype.SelectMenu
{
    /// <summary>
    /// select menu form
    /// </summary>
    public sealed partial class SelectMenuForm : Form
    {
        /// <summary>
        /// timer view instance (singleton pattern)
        /// </summary>
        private static CountdownTimer.view.CountdownTimerForm _countdownTimerForm;

        /// <summary>
        /// select menu form constructor
        /// </summary>
        public SelectMenuForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// timer view property
        /// </summary>
        public CountdownTimer.view.CountdownTimerForm CountdownTimerInstance
        {
            get
            {
                if (!_IsValidFormInstance(_countdownTimerForm))
                {
                    _countdownTimerForm = new MyPrototype.CountdownTimer.view.CountdownTimerForm();
                }
                return _countdownTimerForm;
            }
        }

        /// <summary>
        /// determine if form instance is valid
        /// </summary>
        /// <param name="form"></param>
        /// <returns>Instance startup status(true or false)</returns>
        private bool _IsValidFormInstance(Form form)
        {
            if (form == null || form.IsDisposed)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// activate the pomodoro timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void RunPomodoroButton_Click(object sender, EventArgs e)
        {
            if (_IsValidFormInstance(_countdownTimerForm))
            {
                Debug.WriteLine("The Pomodoro timer has already been activated.");
                return;
            }

            await Task.Run(() =>
            {
                Application.Run(CountdownTimerInstance);
            });
        }

        /// <summary>
        /// activate the pdf viewer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RunPDFViewerButtion_Click(object sender, EventArgs e)
        {
            using (var f = new PDFViewer.PDFViewerForm())
            {
                f.ShowDialog();
            }
        }
    }
}
