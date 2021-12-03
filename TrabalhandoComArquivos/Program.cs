using System;
using System.IO;


namespace TrabalhandoComArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\file1.txt"; // Sem o Arroba teria que colocar // no caminho

            // FileStream fs = null;
            StreamReader sr = null;

            try
            {
                //fs = new FileStream(sourcePath, FileMode.Open); // Abri o arquivo
                // sr = new StreamReader(fs);

                sr = File.OpenText(sourcePath); // Tem a mesma função do FileStram 


                while (!sr.EndOfStream)
                {
                    string linha = sr.ReadLine();
                    Console.WriteLine(linha);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro: ");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();

            }

        }
    }
}
