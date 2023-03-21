using System;

namespace MyPrototype.CountdownTimer.model
{
    /// <summary>
    /// timer model
    /// </summary>
    internal sealed class WorkingTimer
    {
        /// <summary>
        /// remaining time (in seconds)
        /// </summary>
        private short _remainingTimeSeconds;

        /// <summary>
        /// timer model constructor
        /// </summary>
        /// <param name="remainingTimeSeconds">remaining time (in seconds)</param>
        internal WorkingTimer(short remainingTimeSeconds)
        {
            RemainingTimeSeconds = remainingTimeSeconds;
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
        }
    }
}
