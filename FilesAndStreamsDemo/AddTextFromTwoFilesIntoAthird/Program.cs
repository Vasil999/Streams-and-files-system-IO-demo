using System;
using System.IO;

namespace AddTextFromTwoFilesIntoAthird
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text1 = "", text2 = "", text3;

            //StreamReader streamReader = new StreamReader(@"C:\Users\vasil\source\repos\Streams-and-files-system-IO-demo\FilesForTheExcersizes\text1.txt");

            //string line = streamReader.ReadLine();

            //while (line != null)
            //{
            //    text1 = line + "\n";
            //    line = streamReader.ReadLine();
            //}

            //streamReader.Close();


            //StreamReader streamReader2 = new StreamReader(@"C:\Users\vasil\source\repos\Streams-and-files-system-IO-demo\FilesForTheExcersizes\text2.txt");

            //string line2 = streamReader2.ReadLine();

            //while (line2 != null)
            //{
            //    text2 = line2 + "\n";
            //    line2 = streamReader2.ReadLine();
            //}

            //streamReader2.Close();

            //text3 = text1 + text2;

            //using (StreamWriter streamWriter = new StreamWriter(@"C:\Users\vasil\source\repos\Streams-and-files-system-IO-demo\FilesForTheExcersizes\text3.txt"))
            //{
            //    streamWriter.WriteLine(text3);
            //}

            //System.Diagnostics.Process.Start("notepad", @"C:\Users\vasil\source\repos\Streams-and-files-system-IO-demo\FilesForTheExcersizes\text3.txt");

            //better solution:

            string txt1 = File.ReadAllText(@"C:\Users\vasil\source\repos\Streams-and-files-system-IO-demo\FilesForTheExcersizes\text1.txt");

            string txt2 = File.ReadAllText(@"C:\Users\vasil\source\repos\Streams-and-files-system-IO-demo\FilesForTheExcersizes\text2.txt");

            File.WriteAllText(@"C:\Users\vasil\source\repos\Streams-and-files-system-IO-demo\FilesForTheExcersizes\text3.txt", txt1 + Environment.NewLine + txt2);
        }
    }
}
