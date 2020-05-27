using System;
using System.IO;

namespace ReadingTextFromFileAndPrintingOddLinenumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader streamReader = new StreamReader(@"C:\Users\vasil\source\repos\Streams-and-files-system-IO-demo\FilesForTheExcersizes\text.txt"))
            {
                int lineNumber = 0;

                string line = streamReader.ReadLine();

                while (line != null)
                {
                    lineNumber++;

                    if (!(lineNumber % 2 == 0))
                    {
                        Console.WriteLine($"Line {lineNumber}: {line}");
                    }

                    line = streamReader.ReadLine();
                }
            }
        }
    }
}
