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
            
            WorkingTimer timer = new WorkingTimer((short)0);
            string actual = timer.GetTimeText();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetTimeText2_Within1Hour()
        {
            string expected = "59:59";

            WorkingTimer timer = new WorkingTimer((short)3599);
            string actual = timer.GetTimeText();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetTimeText3_Over1Hour()
        {
            string expected = "120:00";

            WorkingTimer timer = new WorkingTimer((short)7200);
            string actual = timer.GetTimeText();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountdownTime1_Zero()
        {
            short expected = 0;

            WorkingTimer timer = new WorkingTimer((short)0);
            timer.CountdownTime();
            short actual = timer.RemainingTimeSeconds;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountdownTime2_Minus()
        {
            short expected = 0;

            WorkingTimer timer = new WorkingTimer((short)-1);
            timer.CountdownTime();
            short actual = timer.RemainingTimeSeconds;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountdownTime3_One()
        {
            short expected = 0;

            WorkingTimer timer = new WorkingTimer((short)1);
            timer.CountdownTime();
            short actual = timer.RemainingTimeSeconds;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountdownTime4_etc()
        {
            short expected = 59;

            WorkingTimer timer = new WorkingTimer((short)60);
            timer.CountdownTime();
            short actual = timer.RemainingTimeSeconds;

            Assert.AreEqual(expected, actual);
        }
    }
}
