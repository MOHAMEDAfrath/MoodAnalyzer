using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyzerTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodForSad()
        {
            MoodAnalyzerProgram moodSad = new MoodAnalyzerProgram("Sad");
            string expected = "Sad";
            string actual = moodSad.MoodMessage();
            Assert.AreEqual(expected, actual);

        }
        //Negative test Method to print sad mood
        [TestMethod]
        public void NegativeTestMethodForSad()
        {
            MoodAnalyzerProgram moodSad = new MoodAnalyzerProgram("Happy");
            string expected = "Sad";
            string actual = moodSad.MoodMessage();
            Assert.AreEqual(expected, actual);

        }
        //positive test Method to print Happy mood
        [TestMethod]
        public void TestMethodForHappy()
        {
            MoodAnalyzerProgram moodHappy = new MoodAnalyzerProgram("Happy");
            string expected = "Happy";
            string actual = moodHappy.MoodMessage();
            Assert.AreEqual(expected, actual);
        }
        //Negative test Method to print Happy mood
        [TestMethod]
        public void NegativeTestMethodForHappy()
        {
            MoodAnalyzerProgram moodHappy = new MoodAnalyzerProgram("Sad");
            string expected = "Happy";
            string actual = moodHappy.MoodMessage();
            Assert.AreEqual(expected, actual);
        }
        //Test method for null
        [TestMethod]
        public void TestMethodForNull()
        {
            MoodAnalyzerProgram moodNull = new MoodAnalyzerProgram(null);
            string expected = "Happy";
            string actual = moodNull.MoodMessage();
            Assert.AreEqual(expected, actual);
        }
    }
}
