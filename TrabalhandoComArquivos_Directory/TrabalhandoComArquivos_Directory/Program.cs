using System;
using System.IO;

namespace TrabalhandoComArquivos_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"d:\temp\myFolder";

            try
            {
                // Listar todas as subpastas a partir da pasta myFolder.
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);    // "*.*" significa QUALQUER NOME DE ARQUIVO E QUALQUER EXTENSÃO. Ex: fulano.txt, arquivoSecreto.zip etc.
                Console.WriteLine("FOLDERS: ");

                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                // Listar todos os arquivos a partir de uma pasta informada.
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);    // "*.*" significa QUALQUER NOME DE ARQUIVO E QUALQUER EXTENSÃO. Ex: fulano.txt, arquivoSecreto.zip etc.
                Console.WriteLine("FILES: ");

                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                // Criar uma pasta "newFolder" a partir da pasta "myFolder".
                Directory.CreateDirectory(path + @"\newFolder");

            }            
            catch (IOException e)
            {
                Console.WriteLine("OPS! Um erro encontrado: ");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
