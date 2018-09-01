using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App22
{
    class Program
    {
        static void Main(string[] args)
        {
            int int1, int2, int3;
            //2.2
            Console.WriteLine("1º numero inteiro:");
            int1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2º numero inteiro:");
            int2 = int.Parse(Console.ReadLine());
            Console.WriteLine("3º numero inteiro:");
            int3 = int.Parse(Console.ReadLine());
            int maior = 0;
            if ((int1 > int2) && (int1 > int3))
                maior = int1;
            else if ((int2 > int1) && (int2 > int3))
                maior = int2;
            else if((int3 > int1) && (int3 > int2)) 
                maior = int3;
            else
            {
                if ((int1 == int2) && (int2 == int3))
                    maior = int1;
                else if ((int1 == int2) && (int1 > int3))
                    maior = int1;
                else if ((int1 == int3) && (int1 > int2))
                    maior = int1;
                else if ((int2 == int3) && (int2 > int1))
                    maior = int2;
                else
                    maior = int3;

            }
            Console.WriteLine("maior:" + maior);
            

        }
    }
}
