using System;
using System.IO;

namespace DeserializeXML
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please enter path to directory.");
                Console.WriteLine("Usage: DeserializeXML <path>");
                return 1;
            }

            string directoryPath = args[0];
            if (!Directory.Exists(directoryPath))
            {
                Console.WriteLine("Directory does not exists.");
                return 1;
            }

            // Get files in directory(and subdirectoies) with extension .xml
            var filesToDeserialize = Directory.GetFiles(directoryPath, "*.xml", SearchOption.AllDirectories);

            ///TODO: deserialize each file
            foreach (string file in filesToDeserialize)
            {
                ProcessFile(file);
            }

            return 0;
        }

        static void ProcessFile(string file)
        {

        }
    }
}
