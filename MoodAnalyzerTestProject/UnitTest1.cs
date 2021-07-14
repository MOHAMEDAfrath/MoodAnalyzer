using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyzerTestProject
{
    [TestClass]
    public class UnitTest1
    {
        MoodAnalyzerProgram mood;
        MoodAnalyzerProgram mood1;
        [TestInitialize]
        public void SetUp()
        {
            string message = "I am in any Mood";
            string[] moodMessage = message.Split(" ");
            mood = new MoodAnalyzerProgram(moodMessage[3]);
            moodMessage[3] = "Sad";
            mood1 = new MoodAnalyzerProgram(moodMessage[3]);
        }
        [TestMethod]
        public void TestMethodForSad()
        {
            string expected = "Sad";
            string actual = mood1.MoodMessage();
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestMethodForHappy()
        {
            string expected = "Happy";
            string actual = mood.MoodMessage();
            Assert.AreEqual(expected, actual);
        }
    }
}
