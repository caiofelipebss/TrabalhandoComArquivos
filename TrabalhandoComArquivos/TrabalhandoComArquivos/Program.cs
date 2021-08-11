using System;
using System.IO;

namespace TrabalhandoComArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\temp\MyTest.txt";

            try
            {
                if (!File.Exists(path))
                {
                    // Cria um arquivo para escrever.
                    using (StreamWriter sw = File.CreateText(path))  // O StreamWriter implementa um TextWriter para gravar caracteres em um fluxo em uma codificação específica.
                    {
                        sw.WriteLine("Hello");
                        sw.WriteLine("and");
                        sw.WriteLine("Welcome");
                    }
                }
                else
                // Abre e ler o arquivo.
                {
                    using (StreamReader sr = File.OpenText(path)) // O StreamReader implementa um TextReader que lê caracteres de um fluxo de bytes em uma codificação específica.
                    {
                        string s;
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }

                        // Também poderia ser:  while (!sr.EndOfStream) { string s = sr.ReadLine(); Console.WriteLine(s);} 
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("OPS! Um erro occoreu! ");
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}

// Mais detalhes em: https://docs.microsoft.com/en-us/dotnet/api/system.io.file?redirectedfrom=MSDN&view=net-5.0