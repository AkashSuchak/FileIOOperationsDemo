using System;
using System.IO;

namespace FileIOOperationsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("Welcome To FileIo Program!");
            Console.WriteLine("--------------------------");
            
            //Functions Calling
            FileExists();
            ReadAllLines();
            ReadAllText();

            //Using Strem
            StreamWriterOp streamWriterOp = new StreamWriterOp();
            streamWriterOp.WriteUsingStreamWrite();
            streamWriterOp.ReadFromStreamReader();
        }

        //Checking File Exists
        public static void FileExists()
        {
            string path = @"C:\Users\DELL\source\repos\FileIOOperationsDemo\FileIOOperationsDemo\Example.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists : ");
            }
            //Console.ReadKey();
        }

        //Read File using ReadAllLines
        public static void ReadAllLines()
        {
            string path = @"C:\Users\DELL\source\repos\FileIOOperationsDemo\FileIOOperationsDemo\Example.txt";

            string[] lines;
            lines = File.ReadAllLines(path);
            int count = lines.Length;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(lines[i]);
            }                        
            //Console.ReadKey();
        }
        //Read File using ReadAllText
        public static void ReadAllText()
        {
            string path = @"C:\Users\DELL\source\repos\FileIOOperationsDemo\FileIOOperationsDemo\Example.txt";

            string lines;
            lines = File.ReadAllText(path);            
            Console.WriteLine(lines);            
            //Console.ReadKey();
        }

        public static void DeleteFile()
        {
            string path = @"C:\Users\DELL\source\repos\FileIOOperationsDemo\FileIOOperationsDemo\Example.txt";

            File.Delete(path);
            Console.ReadKey();
        }

    }
}
