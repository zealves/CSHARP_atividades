using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            for (int v = 0; v < 10; v++)
            {
                Console.WriteLine("Insira um valor:");
                int val1 = int.Parse(Console.ReadLine());
                array1[v] = val1;
                Console.WriteLine("Insira um valor:");
                int val2 = int.Parse(Console.ReadLine());
                array2[v] = val2;
            }

            for (int o = 0; o < array1.Length; o++)
            {
                if (o % 2 == 0)
                    Console.WriteLine(array1[o]);
            }

            for (int oo = 0; oo < array1.Length; oo++)
            {
                if (oo % 2 != 0)
                    Console.WriteLine(array2[oo]);
            }
            Console.ReadLine();
        }
    }
}
