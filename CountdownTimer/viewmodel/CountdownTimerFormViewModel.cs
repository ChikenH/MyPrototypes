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
        private model.WorkingTimer _workingTimer;

        /// <summary>
        /// remaining time (in mm:ss format)
        /// </summary>
        private string _remainingTimeSecondsText = string.Empty;

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

                RaisePropertyChanged("RemainingTimeText");
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
        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                Debug.WriteLine($"PropertyChanged : {propertyName} by \"{RemainingTimeText}\"");
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /// <summary>
        /// set the remaining time (in seconds) in the view model
        /// </summary>
        /// <param name="time">remaining time (in mm:ss format)</param>
        internal void SetTime(short time)
        {
            _workingTimer = new model.WorkingTimer(time);

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
        }
    }
}
