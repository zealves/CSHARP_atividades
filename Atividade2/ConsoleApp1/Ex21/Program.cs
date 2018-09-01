using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            int somaPares = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Insira um numero real:");
                int numero = int.Parse(Console.ReadLine());
                array[i] = numero;
            }

            for (int o = 0; o < array.Length; o++)
            {
                if (o % 2 == 0)
                    Console.WriteLine(array[o]);
                else
                    somaPares = array[o] + somaPares;
            }
            Console.WriteLine(somaPares);
            Console.ReadLine();
        }
    }
}
