using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App23
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2, nome3, apelido1, apelido2, apelido3;

            //2.3
            Console.WriteLine("1º nome:");
            nome1 = Console.ReadLine();
            Console.WriteLine("apelido:");
            apelido1 = Console.ReadLine();
            Console.WriteLine("2º nome:");
            nome2 = Console.ReadLine();
            Console.WriteLine("apelido:");
            apelido2 = Console.ReadLine();
            Console.WriteLine("3º nome:");
            nome3 = Console.ReadLine();
            Console.WriteLine("apelido:");
            apelido3 = Console.ReadLine();

            Console.Write(nome1 + ',' + apelido1 + '\n');
            Console.Write(nome2 + ',' + apelido2 + '\n');
            Console.Write(nome3 + ',' + apelido3 + '\n');
            Console.ReadLine();
            
        }
    }
}
