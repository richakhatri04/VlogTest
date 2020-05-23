using System;
using System.Collections.Generic;

namespace QuestionClass
{
    public class Program
    {

        public static void Main()
        {
            QuestionClass.TestQuestion();

        }
    }
    public static class QuestionClass
    {
        static List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "jeffrey"
        };

        public static void TestQuestion()
        {
            //using (var enumerator = NamesList.GetEnumerator())
            //{
            //    while (enumerator.MoveNext())
            //    {
            //        Console.WriteLine(enumerator.Current);
            //    }
            //}

        // Answer to Question 8: Use for each instead of IEnumerator 
            foreach (string p in NamesList)
                Console.WriteLine(p);
        }
    }
    }

}
