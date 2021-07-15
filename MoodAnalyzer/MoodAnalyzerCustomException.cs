using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyzerCustomException:Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE,EMPTY_MESSAGE,NO_SUCH_METHOD,NO_SUCH_CLASS,NO_CONSTRUCTOR_FOUND
        }
        ExceptionType exceptiontype;
        public MoodAnalyzerCustomException(ExceptionType exception,string message) : base(message)
        {
            this.exceptiontype = exception;
        }
    }
}
