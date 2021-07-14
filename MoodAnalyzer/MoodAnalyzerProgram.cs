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
        public string MoodMessage()
        {
            if (this.message.ToLower().Equals("sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }

    }
}
