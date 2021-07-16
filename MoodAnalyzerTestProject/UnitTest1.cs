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
        //Test method for null message
        [TestMethod]
        public void TestMethodForNull()
        {
            MoodAnalyzerProgram moodNull = new MoodAnalyzerProgram(null);
            try
            {
                moodNull.MoodMessage();

            }
            catch (MoodAnalyzerCustomException ex)
            {
                string expected = "Mood cannot be null";
                Assert.AreEqual(expected, ex.Message);
            }
        }
        //test message for Empty message
        [TestMethod]
        public void TestMethodForEmpty()
        {
            string empty = "";
            MoodAnalyzerProgram moodEmpty = new MoodAnalyzerProgram(empty);
            try
            {
                string actual = moodEmpty.MoodMessage();

            }
            catch (MoodAnalyzerCustomException ex)
            {
                string expected = "Mood has empty Message";
                Assert.AreEqual(expected, ex.Message);
            }

        }
        //Test methhod to create object
        [TestMethod]
        public void TestCreateObjectWithRelections()
        {
            object expected = new MoodAnalyzerProgram();
            object actual = MoodAnalyzerFactory.CreateObjectForMoodAnalyse("MoodAnalyzer.MoodAnalyzerProgram","MoodAnalyzerProgram");
            expected.Equals(actual);

        }
        //Negative test case for no class found
        [TestMethod]
        public void NegativeTestCreateObjectWithRelections()
        {
            object expected = new MoodAnalyzerProgram();
            object actual = MoodAnalyzerFactory.CreateObjectForMoodAnalyse("MoodAnalyzer.MoodAnalyzerProgra", "MoodAnalyzerProgra");
            expected.Equals(actual);

        }
        //Negative test case for no constructor found
        [TestMethod]
        public void NegativeTestCreateObjectWithReflections1()
        {
            object expected = new MoodAnalyzerProgram();
            object actual = MoodAnalyzerFactory.CreateObjectForMoodAnalyse("MoodAnalyzer.MoodAnalyzerProgram", "MoodAnalyzerProgra");
            expected.Equals(actual);

        }
        //Test method to create parameterized contructor
        [TestMethod]
        public void TestParameterConstructor()
        {
            object expected = new MoodAnalyzerProgram("Happy");
            object actual = MoodAnalyzerFactory.CreateParameterizedConstructor("MoodAnalyzer.MoodAnalyzerProgram", "MoodAnalyzerProgram", "Happy");
            actual.Equals(expected);
        }
        //negative Test method to create parameterized contructor with improper class name
        [TestMethod]
        public void NegativeTestParameterConstructor()
        {
            object expected = new MoodAnalyzerProgram("Happy");
            object actual = MoodAnalyzerFactory.CreateParameterizedConstructor("MoodAnalyzer.MoodAnalyzerProgra", "MoodAnalyzerProgram", "Happy");
            actual.Equals(expected);
        }
        //negative Test method to create parameterized contructor with improper constructor name
        [TestMethod]
        public void NegativeTestParameterConstructor1()
        {
            object expected = new MoodAnalyzerProgram("Happy");
            object actual = MoodAnalyzerFactory.CreateParameterizedConstructor("MoodAnalyzer.MoodAnalyzerProgram", "MoodAnalyzerProgra", "Happy");
            actual.Equals(expected);
        }
        //Invoke method for happy message
        [TestMethod]
        public void TestInvokeMethodShouldReturnHappy()
        {
            string expected = "Happy";
            string actual = MoodAnalyzerFactory.InvokeMethod("MoodMessage", "Happy");
            Assert.AreEqual(expected, actual);
        }
        //Invoke method for wrong method name
        [TestMethod]
        public void NegativeTestInvokeMethodShouldReturnHappy()
        {
            string expected = "Happy";
            string actual = MoodAnalyzerFactory.InvokeMethod("MoodMessag", "Happy");
            Assert.AreEqual(expected, actual);
        }
        //test method to set fields
        [TestMethod]
        public void TestSetFields()
        {
            string expected = "Happy";
            string actual = MoodAnalyzerFactory.SetMessage("message","Happy");
            Assert.AreEqual(expected, actual);
        }
        //negative test method if no field found
        [TestMethod]
        public void NegativeTestForNoFieldFound()
        {
            string expected = "Happy";
            string actual = MoodAnalyzerFactory.SetMessage("messag", "Happy");
            Assert.AreEqual(expected, actual);

        }
        //negative test method if no null message
        [TestMethod]
        public void NegativeTestForFieldNullMessage()
        {
            string expected = "Happy";
            string actual = MoodAnalyzerFactory.SetMessage("message", null);
            Assert.AreEqual(expected, actual);

        }

    }

}
