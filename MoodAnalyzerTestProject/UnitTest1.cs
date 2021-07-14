using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyzerTestProject
{
    [TestClass]
    public class UnitTest1
    {
        MoodAnalyzerProgram moodSad;
        MoodAnalyzerProgram moodHappy;
        MoodAnalyzerProgram moodNull;
        [TestInitialize]
        public void SetUp()
        {
            string message = "I am in any Mood";
            string[] moodMessage = message.Split(" ");
            moodHappy = new MoodAnalyzerProgram(moodMessage[3]);
            moodMessage[3] = "Sad";
            moodSad = new MoodAnalyzerProgram(moodMessage[3]);
            moodNull = new MoodAnalyzerProgram(null);
            
        }
        [TestMethod]
        public void TestMethodForSad()
        {
            string expected = "Sad";
            string actual = moodSad.MoodMessage();
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestMethodForHappy()
        {
            string expected = "Happy";
            string actual = moodHappy.MoodMessage();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodForNull()
        {
            string expected = "Happy";
            string actual = moodNull.MoodMessage();
            Assert.AreEqual(expected, actual);
        }
    }
}
