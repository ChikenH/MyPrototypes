using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyPrototype.CountdownTimer.model;

namespace MyPrototype.CountdownTimer.WorkingTimerTest
{
    [TestClass]
    public class WorkingTimerTest
    {
        [TestMethod]
        public void GetTimeText1_NoSetTime()
        {
            string expected = "--:--";
            
            WorkingTimerModel timer = new WorkingTimerModel((short)0);
            string actual = timer.GetTimeText();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetTimeText2_Within1Hour()
        {
            string expected = "59:59";

            WorkingTimerModel timer = new WorkingTimerModel((short)3599);
            string actual = timer.GetTimeText();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetTimeText3_Over1Hour()
        {
            string expected = "120:00";

            WorkingTimerModel timer = new WorkingTimerModel((short)7200);
            string actual = timer.GetTimeText();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountdownTime1_Zero()
        {
            short expected = 0;

            WorkingTimerModel timer = new WorkingTimerModel((short)0);
            timer.CountdownTime();
            short actual = timer.RemainingTimeSeconds;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountdownTime2_Minus()
        {
            short expected = 0;

            WorkingTimerModel timer = new WorkingTimerModel((short)-1);
            timer.CountdownTime();
            short actual = timer.RemainingTimeSeconds;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountdownTime3_One()
        {
            short expected = 0;

            WorkingTimerModel timer = new WorkingTimerModel((short)1);
            timer.CountdownTime();
            short actual = timer.RemainingTimeSeconds;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountdownTime4_etc()
        {
            short expected = 59;

            WorkingTimerModel timer = new WorkingTimerModel((short)60);
            timer.CountdownTime();
            short actual = timer.RemainingTimeSeconds;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetRemainingTimeProgressBar1_Zero()
        {
            int expected = 0;

            WorkingTimerModel timer = new WorkingTimerModel((short)0);
            int actualMinimum = timer.TimeProgressBar.MinValue;
            int actualMaximum = timer.TimeProgressBar.MaxValue;
            int actualProgress = timer.TimeProgressBar.ProgressValue;

            Assert.AreEqual(expected, actualMinimum);
            Assert.AreEqual(expected, actualMaximum);
            Assert.AreEqual(expected, actualProgress);
        }

        [TestMethod]
        public void GetRemainingTimeProgressBar2_Minus()
        {
            int expected = 0;

            WorkingTimerModel timer = new WorkingTimerModel((short)-1);
            int actualMinimum = timer.TimeProgressBar.MinValue;
            int actualMaximum = timer.TimeProgressBar.MaxValue;
            int actualProgress = timer.TimeProgressBar.ProgressValue;

            Assert.AreEqual(expected, actualMinimum);
            Assert.AreEqual(expected, actualMaximum);
            Assert.AreEqual(expected, actualProgress);
        }

        [TestMethod]
        public void GetRemainingTimeProgressBar3_Ten()
        {
            int expectedMin = 0;
            int expectedMax = 10;
            int expectedOne = 1;

            // initial
            WorkingTimerModel timer = new WorkingTimerModel((short)10);
            timer.CountdownTime();
            int actualMinimum = timer.TimeProgressBar.MinValue;
            int actualMaximum = timer.TimeProgressBar.MaxValue;
            int actualProgress1 = timer.TimeProgressBar.ProgressValue;

            Assert.AreEqual(expectedMin, actualMinimum);
            Assert.AreEqual(expectedMax, actualMaximum);
            Assert.AreEqual(expectedOne, actualProgress1);

            // minutes elapsed (to maximum)
            for (int i = 0; i < expectedMax; i++)
            {
                timer.CountdownTime();
            }
            int actualProgress2 = timer.TimeProgressBar.ProgressValue;

            Assert.AreEqual(expectedMax, actualProgress2);

            // over maximum
            timer.CountdownTime();
            int actualProgress3 = timer.TimeProgressBar.ProgressValue;

            Assert.AreEqual(expectedMax, actualProgress3);
        }
    }
}
