using System;
using System.IO;
using System.Linq;

namespace AddLineNumberAndReverseContent
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversedContentWithAddedLineNumbers = "";

            using (StreamReader streamReader = new StreamReader(@"C:\Users\vasil\source\repos\Streams-and-files-system-IO-demo\FilesForTheExcersizes\text.txt"))
            {
                int lineNumber = 0;

                string line = streamReader.ReadLine();

                while (line != null)
                {
                    lineNumber++;

                    reversedContentWithAddedLineNumbers += $"{lineNumber}: {string.Join("", line.Reverse().ToArray())}\n";

                    line = streamReader.ReadLine();
                }
            }

            Console.WriteLine(reversedContentWithAddedLineNumbers);
        }
    }
}
