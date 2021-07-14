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
        MoodAnalyzerProgram moodEmpty;
        [TestInitialize]
        public void SetUp()
        {
            string message = "I am in any Mood";
            string[] moodMessage = message.Split(" ");
            moodHappy = new MoodAnalyzerProgram(moodMessage[3]);
            moodMessage[3] = "Sad";
            moodSad = new MoodAnalyzerProgram(moodMessage[3]);
            moodNull = new MoodAnalyzerProgram(null);
            string empty = "";
            moodEmpty = new MoodAnalyzerProgram(empty);
            
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
            try
            { 
                 moodNull.MoodMessage();
               
            }catch(MoodAnalyzerCustomException ex)
            {
                string expected = "Mood cannot be null";
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        public void TestMethodForEmpty()
        {
            try
            {
                string actual = moodEmpty.MoodMessage();

            }catch(MoodAnalyzerCustomException ex)
            {
                string expected = "Mood has empty Message";
                Assert.AreEqual(expected,ex.Message);
            }

        }
    }
}
