﻿using System;
using System.Diagnostics;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPrototype.CountdownTimer.view
{
    /// <summary>
    /// timer view
    /// </summary>
    public partial class CountdownTimerForm : Form
    {
        /// <summary>
        /// timer
        /// </summary>
        private static System.Timers.Timer _pomodoroTimer;

        /// <summary>
        /// number of executions
        /// </summary>
        private static short _executionCount = 0;

        /// <summary>
        /// timer view model
        /// </summary>
        private viewmodel.CountdownTimerFormViewModel _countdownTimerFormViewModel = null;

        /// <summary>
        /// timer view constructor
        /// </summary>
        public CountdownTimerForm()
        {
            InitializeComponent();
            ActiveControl = PomodoroButton;

            _countdownTimerFormViewModel = new viewmodel.CountdownTimerFormViewModel(0);

            // Re-creating an instance of CountdownTimerFormViewModel breaks data binding
            RemainingTimeText.DataBindings.Add("Text", _countdownTimerFormViewModel, "RemainingTimeText");
        }

        /// <summary>
        /// pomodoro start or resume button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PomodoroButton_Click(object sender, EventArgs e)
        {
            if (_pomodoroTimer != null)
            {
                Debug.WriteLine("The timer has already started.");
                _pomodoroTimer.Start();
                return;
            }

            _pomodoroTimer = new System.Timers.Timer(1000);
            _pomodoroTimer.Elapsed += PomodoroTimer_Elapsed;
            _pomodoroTimer.AutoReset = true;
            _pomodoroTimer.Enabled = true;
        }

        /// <summary>
        /// processing when an interval elapses
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void PomodoroTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (RemainingTimeText.Text == "--:--")
            {
                Debug.WriteLine($"{_executionCount} -> {_executionCount % 2}");
                // pomodoro loop (25 -> 5 -> 25 -> ...)
                short times = _executionCount % 2 == 0 ? (short)(60 * 25) : (short)(60 * 5);

                await Task.Run(() =>
                {
                    Action<short> method = new Action<short>(delegate (short x) { _countdownTimerFormViewModel.SetTime(x); });
                    return Invoke(method, times);
                });

                _executionCount++;
                if (_executionCount <= 1)
                {
                    return;
                }

                PlaySimpleSound();
                MessageBox.Show("It's time.", "Pomodoro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                await Task.Run(() => Invoke(new Action(_countdownTimerFormViewModel.DecrementByOneSecond)));
            }
        }

        /// <summary>
        /// pause the timer countdown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (_pomodoroTimer == null)
            {
                Debug.WriteLine("The timer has not started.");
                return;
            }

            _pomodoroTimer.Stop();
        }

        /// <summary>
        /// reset the remaining time and stop the timer countdown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (_pomodoroTimer != null)
            {
                _pomodoroTimer.Stop();
                _pomodoroTimer.Dispose();
                _pomodoroTimer = null;
            }

            _countdownTimerFormViewModel.SetTime(0);
            _executionCount = 0;
        }

        /// <summary>
        /// sounds a notification
        /// </summary>
        private void PlaySimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            simpleSound.Play();
        }

        /// <summary>
        /// reflects the time set in the DataTimePicker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimeSetButton_Click(object sender, EventArgs e)
        {
            string customTime = CustomTimePicker.Text;
            string[] timeSplit = customTime.Split(':');
            short setTime = (short)((Convert.ToInt32(timeSplit[0]) * 60) + Convert.ToInt32(timeSplit[1]));

            _countdownTimerFormViewModel.SetTime(setTime);
        }

        /// <summary>
        /// start the timer countdown (synchronous mode)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (RemainingTimeText.Text == "--:--")
            {
                return;
            }

            while (RemainingTimeText.Text != "--:--")
            {
                System.Threading.Thread.Sleep(1000);
                _countdownTimerFormViewModel.DecrementByOneSecond();

                // immediate reflection in GUI
                RemainingTimeText.Update();
            }

            PlaySimpleSound();
            MessageBox.Show("It's time.", "synchronous mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
