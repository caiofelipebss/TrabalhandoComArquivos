using System;
using System.IO;

namespace TrabalhandoComArquivos_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"d:\temp\file1.txt";
            string targetPath = @"d:\temp\file2.txt";

            try
            {
                File.Copy(sourcePath, targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("OPS! Um erro aconteceu!! ");
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
        
    }
}
