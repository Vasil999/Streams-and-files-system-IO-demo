using System;
using System.IO;

namespace FilesAndStreamsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\vasil\source\repos\Streams-and-files-system-IO-demo\FilesForTheExcersizes\text.txt");

            int lineNumber = 0;

            string line = streamReader.ReadLine();

            while (line != null)
            {
                lineNumber++;
                Console.WriteLine($"Line {lineNumber}: {line}");
                line = streamReader.ReadLine();
            }

            streamReader.Close(); //Closing is very, very important

            using (StreamWriter writer = new StreamWriter(@"C:\Users\vasil\source\repos\Streams-and-files-system-IO-demo\FilesForTheExcersizes\text.txt", true)) //true for the 4. overload: bool append
            {
                writer.WriteLine("new line");
            } //using instead of close

            string path = @"C:\Users\vasil\source\repos\Streams-and-files-system-IO-demo\FilesForTheExcersizes\text.txt";

            if (!File.Exists(path))
            {
                File.Create(path);
            }

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine("New line new file new life");
            }

            System.Diagnostics.Process.Start("notepad", path);
        }
    }
}
 