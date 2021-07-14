using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyzerProgram
    {
        string message;
        public MoodAnalyzerProgram(string message)
        {
            this.message = message;
        }
        //using try catch to catch exceptions
        public string MoodMessage()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.EMPTY_MESSAGE, "Mood has empty Message");
                }
                if (this.message.ToLower().Equals("sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }catch(NullReferenceException ex)
            {

                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NULL_MESSAGE, "Mood cannot be null");
               

                
            }
        }

    }
}
