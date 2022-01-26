using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubModule1
{
    public class ConsoleOperations
    {
        public static void WriteDelimiter()
        {
            Console.WriteLine("--------------------------------------------");
        }

        public static void WriteString(string outputString, bool withDelimiter = false)
        {

            if (withDelimiter)
            {
                WriteDelimiter();
            }

            Console.WriteLine(outputString);

            if (withDelimiter)
            {
                WriteDelimiter();
            }
        }

        public static string AskUser(string question, string defaultValue = "")
        {
            Console.WriteLine(question);

            string answer = Console.ReadLine() ?? "";

            return answer == "" ? defaultValue : answer;
        }
    }
}
