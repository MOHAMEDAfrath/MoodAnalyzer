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
        [TestMethod]
        public void TestMethodForNull()
        {
            MoodAnalyzerProgram moodNull = new MoodAnalyzerProgram(null);
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
            string empty = "";
           MoodAnalyzerProgram moodEmpty = new MoodAnalyzerProgram(empty);
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
