using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int I = 0, N;
            int[] A = new int[100];

            Console.Write("Digite um nr (999 para terminar)");
            int Numero = Convert.ToInt32(Console.ReadLine());

            while (Numero != 999)
            {
                A[I] = Numero;
                I++;
                Console.Write("Digite um nr (999 para terminar)");
                Numero = Convert.ToInt32(Console.ReadLine());
            }
            N = I - 1;
            for (I = 0; I <= N; I++)
                Console.Write("{0,3}", A[I]);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
