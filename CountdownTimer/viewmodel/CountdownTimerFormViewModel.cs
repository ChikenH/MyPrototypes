using System.ComponentModel;
using System.Diagnostics;

namespace MyPrototype.CountdownTimer.viewmodel
{
    /// <summary>
    /// timer view model
    /// </summary>
    internal sealed class CountdownTimerFormViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// timer model
        /// </summary>
        private model.WorkingTimerModel _workingTimer;

        /// <summary>
        /// remaining time (in mm:ss format)
        /// </summary>
        private string _remainingTimeSecondsText = string.Empty;

        /// <summary>
        /// remaining time progressbar maximum
        /// </summary>
        private int _remainingTimeProgressBarMax = 0;

        /// <summary>
        /// remaining time progressbar value
        /// </summary>
        private int _remainingTimeProgressBarValue = 0;

        /// <summary>
        /// timer view model constructor
        /// </summary>
        /// <param name="time">time (in seconds)</param>
        public CountdownTimerFormViewModel(short time)
        {
            SetTime(time);
        }

        /// <summary>
        /// remaining time (in mm:ss format)
        /// </summary>
        public string RemainingTimeText
        {
            get
            {
                return _remainingTimeSecondsText;
            }
            private set
            {
                _remainingTimeSecondsText = value;

                RaisePropertyChanged("RemainingTimeText", value);
            }
        }

        /// <summary>
        /// remaining time progressbar maximum
        /// </summary>
        public int RemainingTimeProgressBarMax
        {
            get
            {
                return _remainingTimeProgressBarMax;
            }
            private set
            {
                _remainingTimeProgressBarMax = value;

                RaisePropertyChanged("RemainingTimeProgressBarMax", value.ToString());
            }
        }

        /// <summary>
        /// remaining time progressbar value
        /// </summary>
        public int RemainingTimeProgressBarValue
        {
            get
            {
                return _remainingTimeProgressBarValue;
            }
            private set
            {
                _remainingTimeProgressBarValue = value;

                RaisePropertyChanged("RemainingTimeProgressBarValue", value.ToString());
            }
        }

        /// <summary>
        /// events for Data Binding (PropertyChanged)
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// notify property changed
        /// </summary>
        /// <param name="propertyName">property name</param>
        /// <param name="debugValue">value (for debugging)</param>
        public void RaisePropertyChanged(string propertyName, string debugValue)
        {
            if (PropertyChanged != null)
            {
                Debug.WriteLine($"PropertyChanged : {propertyName} by \"{debugValue}\"");
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /// <summary>
        /// set the remaining time (in seconds) in the view model
        /// </summary>
        /// <param name="time">remaining time (in mm:ss format)</param>
        internal void SetTime(short time)
        {
            _workingTimer = new model.WorkingTimerModel(time);

            _InitializeProgressBar();
            _DisplayRemainingTime();
        }

        /// <summary>
        /// decrement for countdown
        /// </summary>
        internal void DecrementByOneSecond()
        {
            _workingTimer.CountdownTime();

            _DisplayRemainingTime();
        }

        /// <summary>
        /// obtain and display remaining time
        /// </summary>
        private void _DisplayRemainingTime()
        {
            RemainingTimeText = _workingTimer.GetTimeText();
            RemainingTimeProgressBarValue = _workingTimer.TimeProgressBar.ProgressValue;
        }

        /// <summary>
        /// Initialize the maximum value and progress value of the progress bar
        /// </summary>
        private void _InitializeProgressBar()
        {
            // set the maximum value after initializing the value first, since the value may be out of range
            RemainingTimeProgressBarValue = _workingTimer.TimeProgressBar.ProgressValue;
            RemainingTimeProgressBarMax = _workingTimer.TimeProgressBar.MaxValue;
        }
    }
}
