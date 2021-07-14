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
        //using try catch to catch null reference exception
        public string MoodMessage()
        {
            try
            {
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
                return "Happy";
            }
        }

    }
}
