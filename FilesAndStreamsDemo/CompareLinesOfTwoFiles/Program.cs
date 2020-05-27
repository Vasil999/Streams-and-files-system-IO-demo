using System;
using System.IO;

namespace CompareLinesOfTwoFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text1 = File.ReadAllLines(@"C:\Users\vasil\source\repos\Streams-and-files-system-IO-demo\FilesForTheExcersizes\text1.txt");

            string[] text3 = File.ReadAllLines(@"C:\Users\vasil\source\repos\Streams-and-files-system-IO-demo\FilesForTheExcersizes\text3.txt");

            int equals = 0;
            int notEquals = 0;

            for (int i = 0; i < Math.Max(text1.Length, text3.Length); i++)
            {
                if(text1[i].Equals(text3[i]))
                {
                    equals++;
                }
                else
                {
                    notEquals++;
                }

            }

            Console.WriteLine(equals);
            Console.WriteLine(notEquals);
        }
    }
}
