using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App25
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.5
            int val = 0; int count = 0;
            float somaTudo = 0; float mediaTudo = 0;
            float maximo = 0;
            float minimo = float.MaxValue;
            do
            {
                Console.WriteLine("Insira um numero:");
                val = int.Parse(Console.ReadLine());
                somaTudo = somaTudo + val;
                count = count + 1;
                if (val >= maximo)
                    maximo = val;
                if (val <= minimo && val != 0)
                    minimo = val;
            } while (val != 0);


            Console.WriteLine("Soma" + somaTudo);
            mediaTudo = somaTudo / count;
            Console.WriteLine("Media" + mediaTudo);
            Console.WriteLine("Minimo" + minimo);
            Console.WriteLine("Maximo" + maximo);
            Console.ReadLine();
            
        }
    }
}
