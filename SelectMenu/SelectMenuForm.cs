using MyPrototype.CountdownTimer.view;
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
                if (!_isValidFormInstance())
                {
                    _countdownTimerForm = new MyPrototype.CountdownTimer.view.CountdownTimerForm();
                }
                return _countdownTimerForm;
            }
        }

        /// <summary>
        /// determine if the timer view instance is valid
        /// </summary>
        /// <returns>Instance startup status(true or false)</returns>
        private bool _isValidFormInstance()
        {
            if (_countdownTimerForm == null || _countdownTimerForm.IsDisposed)
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
            if (_isValidFormInstance())
            {
                Debug.WriteLine("The Pomodoro timer has already been activated.");
                return;
            }

            await Task.Run(() =>
            {
                Application.Run(CountdownTimerInstance);
            });
        }
    }
}
