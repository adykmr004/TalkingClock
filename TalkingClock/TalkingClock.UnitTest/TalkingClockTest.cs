using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TalkingClock.UnitTest
{
    [TestClass]
    public class TalkingClockTest
    {
        [TestMethod]
        public void MinuteEqualToZero()
        {
            var clock = new TalkingClock();
            var result = clock.GetTimeToHumanFriendlyText("1:00");
            Assert.AreEqual(result, "One o'clock");
        }
        [TestMethod]
        public void MinuteLessThanTen()
        {
            var clock = new TalkingClock();
            var result = clock.GetTimeToHumanFriendlyText("1:09");
            Assert.AreEqual(result, "Nine past One");
        }

        [TestMethod]
        public void MinuteLessThan20()
        {
            var clock = new TalkingClock();
            var result = clock.GetTimeToHumanFriendlyText("1:18");
            Assert.AreEqual(result, "Eighteen past One");
        }

        [TestMethod]
        public void MinuteLessThan30()
        {
            var clock = new TalkingClock();
            var result = clock.GetTimeToHumanFriendlyText("1:27");
            Assert.AreEqual(result, "Twenty Seven past One");
        }
        [TestMethod]
        public void MinuteEquals30()
        {
            var clock = new TalkingClock();
            var result = clock.GetTimeToHumanFriendlyText("1:30");
            Assert.AreEqual(result, "Half past One");
        }

        [TestMethod]
        public void MinuteGraterThan30()
        {
            var clock = new TalkingClock();
            var result = clock.GetTimeToHumanFriendlyText("13:35");
            Assert.AreEqual(result, "Twenty Five to Two");
        }

        [TestMethod]
        public void MinuteToLessThan10()
        {
            var clock = new TalkingClock();
            var result = clock.GetTimeToHumanFriendlyText("13:55");
            Assert.AreEqual(result, "Five to Two");
        }
        [TestMethod]
        public void MinuteToLessThan20()
        {
            var clock = new TalkingClock();
            var result = clock.GetTimeToHumanFriendlyText("13:45");
            Assert.AreEqual(result, "Fifteen to Two");
        }


        [TestMethod]
        public void MinutesTo()
        {
            var clock = new TalkingClock();
            var result = clock.GetTimeToHumanFriendlyText("13:32");
            Assert.AreEqual(result, "Twenty Eight to Two");
        }
    }
}
