using System;
using System.IO;


namespace TrabalhandoComArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\file1.txt"; // Sem o Arroba teria que colocar // no caminho
            string targetPath = @"c:\temp\file2.txt";

            try
            {
                FileInfo fileinfo = new FileInfo(sourcePath);
                fileinfo.CopyTo(targetPath);
                string[] linhas = File.ReadAllLines(sourcePath); // Le as linhas do arquivo

                foreach (string linha in linhas ) // Le as linhas do Vetor
                {

                    Console.WriteLine(linha);
                }


            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro: ");
                Console.WriteLine(e.Message);
            }

        }
    }
}
