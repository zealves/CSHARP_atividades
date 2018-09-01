using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App24
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.4
            int somaImpares = 0;
            float multPares = 0;
            for(var i = 1;i <= 30; i++)
            {
                if (i % 2 == 0)
                {
                    if(multPares == 0)
                        multPares = i;
                    else
                        multPares = i * multPares;
                }
                else
                    somaImpares += i;
            }

            Console.WriteLine("Soma dos impares:" + somaImpares);
            Console.WriteLine("Multiplicação dos pares:" + multPares);
            Console.ReadLine();
            
        }
    }
}
