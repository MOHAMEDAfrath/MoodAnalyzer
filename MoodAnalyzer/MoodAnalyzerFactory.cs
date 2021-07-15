using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyzerFactory
    {
        public static object CreateObjectForMoodAnalyse(string classname,string constructorname)
        {
            string pattern = @"."+constructorname+"$";
            Match result = Regex.Match(classname , pattern);
            if(result.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type type = assembly.GetType(classname);
                    return Activator.CreateInstance(type);
                }
                catch(ArgumentNullException ex)
                {
                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NO_SUCH_CLASS, "No class Found");
                }
            }
            else
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NO_CONSTRUCTOR_FOUND, "No constructor found");
            }
        }
    }
}
