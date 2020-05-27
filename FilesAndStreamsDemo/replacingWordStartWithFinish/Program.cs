using System;
using System.IO;
using System.Text.RegularExpressions;

namespace replacingWordStartWithFinish
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText(@"C:\Users\vasil\source\repos\Streams-and-files-system-IO-demo\FilesForTheExcersizes\startText.txt");
            string pattern = @"\bstart\b"; //If you want, that not only the whole words would change, you can use the pattern @"\Bstart\B|\bstart\b|\bstart\B|\Bstart\b" 
            string replace = "finish";
            string result = Regex.Replace(input, pattern, replace);

            using (StreamWriter streamWriter = new StreamWriter(@"C:\Users\vasil\source\repos\Streams-and-files-system-IO-demo\FilesForTheExcersizes\startToFinishText.txt"))
            {
                streamWriter.Write(result);
            }
        }
    }
}
