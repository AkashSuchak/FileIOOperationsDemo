using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIOOperationsDemo
{
    public class StreamWriterOp
    {
        public void WriteUsingStreamWrite()
        {
            //FilePath
            string path = @"C:\Users\DELL\source\repos\FileIOOperationsDemo\FileIOOperationsDemo\Example.txt";
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Hello World - .net is Awesome ");
                sw.Close();

                Console.WriteLine(File.ReadAllText(path));
            }
            Console.ReadKey();
        }
        //FilePath
        public void ReadFromStreamReader()
        {
            string path = @"C:\Users\DELL\source\repos\FileIOOperationsDemo\FileIOOperationsDemo\Example.txt";
            using (StreamReader sr = File.OpenText(path))
            {                
                string s = "";

                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }                
            }
            Console.ReadKey();
        }
    }
}
