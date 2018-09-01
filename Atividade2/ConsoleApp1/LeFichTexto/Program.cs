using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LeFichTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader("TestFile.txt"))
                {
                    String linha = sr.ReadToEnd();
                    Console.WriteLine(linha);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("O ficheiro não pode ser lido!");
                Console.WriteLine(e.Message);
            }
            Console.Read();
        }
    }
}
