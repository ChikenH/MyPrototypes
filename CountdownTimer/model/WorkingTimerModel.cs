using System;

namespace MyPrototype.CountdownTimer.model
{
    /// <summary>
    /// timer model
    /// </summary>
    internal sealed class WorkingTimerModel
    {
        /// <summary>
        /// remaining time (in seconds)
        /// </summary>
        private short _remainingTimeSeconds;

        /// <summary>
        /// timer model constructor
        /// </summary>
        /// <param name="remainingTimeSeconds">remaining time (in seconds)</param>
        internal WorkingTimerModel(short remainingTimeSeconds)
        {
            RemainingTimeSeconds = remainingTimeSeconds;
            TimeProgressBar = new TimeProgressBarModel(RemainingTimeSeconds);
        }

        /// <summary>
        /// remaining time (in seconds)
        /// </summary>
        internal short RemainingTimeSeconds
        {
            get
            {
                return _remainingTimeSeconds;
            }
            set
            {
                if (value < 0)
                {
                    _remainingTimeSeconds = 0;
                }
                else
                {
                    _remainingTimeSeconds = value;
                }
            }
        }

        /// <summary>
        /// remaining time progress
        /// </summary>
        internal TimeProgressBarModel TimeProgressBar
        {
            get;
            private set;
        }

        /// <summary>
        /// get the remaining time (in mm:ss format)
        /// </summary>
        /// <returns>remaining time (in mm:ss format)</returns>
        internal string GetTimeText()
        {
            if (_remainingTimeSeconds == 0)
            {
                return "--:--";
            }

            // 2 decimal digits
            return String.Format($"{_remainingTimeSeconds / 60:D2}:{_remainingTimeSeconds % 60:D2}");
        }

        /// <summary>
        /// count down by 1 second
        /// </summary>
        internal void CountdownTime()
        {
            RemainingTimeSeconds -= 1;

            TimeProgressBar.CalculateProgress(RemainingTimeSeconds);
        }
    }

    /// <summary>
    /// progress bar model
    /// </summary>
    internal sealed class TimeProgressBarModel
    {
        /// <summary>
        /// value
        /// </summary>
        private int _progressValue;

        /// <summary>
        /// progress bar model constructor
        /// </summary>
        /// <param name="remainingTimeSeconds">remaining time (in seconds)</param>
        internal TimeProgressBarModel(short remainingTimeSeconds)
        {
            MaxValue = remainingTimeSeconds;
            MinValue = 0;
            StepValue = 1;
            ProgressValue = 0;
        }

        /// <summary>
        /// maximum
        /// </summary>
        internal int MaxValue { get; }

        /// <summary>
        /// minimum
        /// </summary>
        internal int MinValue { get; }

        /// <summary>
        /// step
        /// </summary>
        internal int StepValue { get; }

        /// <summary>
        /// value
        /// </summary>
        internal int ProgressValue
        {
            get
            {
                return _progressValue;
            }
            private set
            {
                if (value < MinValue)
                {
                    _progressValue = MinValue;
                }
                else if (value > MaxValue)
                {
                    _progressValue = MaxValue;
                }
                else
                {
                    _progressValue = value;
                }
            }
        }

        /// <summary>
        /// calculate progress based on time remaining
        /// </summary>
        /// <param name="remainingTimeSeconds">remaining time (in seconds)</param>
        internal void CalculateProgress(short remainingTimeSeconds)
        {
            ProgressValue = MaxValue - remainingTimeSeconds;
        }
    }
}
