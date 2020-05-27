using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SortNamesAlphabetical
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = File.ReadAllLines(@"C:\Users\vasil\source\repos\Streams-and-files-system-IO-demo\FilesForTheExcersizes\names.txt").ToList().OrderBy(n => n).ToList();

            File.WriteAllLines(@"C:\Users\vasil\source\repos\Streams-and-files-system-IO-demo\FilesForTheExcersizes\orderedNames.txt", names);
        }
    }
}
