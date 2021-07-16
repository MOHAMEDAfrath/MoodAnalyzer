﻿using System;
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
        public static object CreateParameterizedConstructor(string classname,string constructorname,string message)
        {
            Type type = typeof(MoodAnalyzerProgram);
            if(type.Name.Equals(classname) || type.FullName.Equals(classname))
            {
                if (type.Name.Equals(constructorname))
                {
                    ConstructorInfo constructorInfo = type.GetConstructor(new[] { typeof(string)});
                    object objectConstructor = constructorInfo.Invoke(new object[] { message });
                    return objectConstructor;
                }
                else
                {
                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NO_CONSTRUCTOR_FOUND, "No constructor found");
                }
            }
            else
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NO_SUCH_CLASS, "No class found");
            }

        }
        public static string InvokeMethod(string methodname ,string message)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyzer.MoodAnalyzerProgram");
                object methodObject = MoodAnalyzerFactory.CreateParameterizedConstructor("MoodAnalyzer.MoodAnalyzerProgram", "MoodAnalyzerProgram", message);
                MethodInfo methodInfo = type.GetMethod(methodname);
                object method = methodInfo.Invoke(methodObject,null);
                return method.ToString();


            }
            catch(NullReferenceException)
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NO_METHOD_FOUND, "No method found");
            }
        }
    }
}
