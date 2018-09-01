using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App21
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3;
            float media;
            string nome;
            //2.1
            Console.WriteLine("Isira o nome do aluno: ");
            nome = Console.ReadLine();
            Console.WriteLine("nota 1:");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("nota 2:");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("nota 3:");
            nota3 = int.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine("Media:" + media);

        }
    }
}
