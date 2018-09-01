using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App26
{
    class Program
    {
        static void Main(string[] args)
        {

            //2.6
            float firstVal = 0;
            float secondVal = 0;
            float result = 0;
            string operador = "";
            Console.WriteLine("Insira um valor");
            firstVal = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira um operador");
            operador = Console.ReadLine();
            Console.WriteLine("Insira outro valor");
            secondVal = float.Parse(Console.ReadLine());

            switch (operador)
            {
                case "+":
                    result = firstVal + secondVal;
                    break;
                case "-":
                    result = firstVal - secondVal;
                    break;
                case "*":
                    result = firstVal * secondVal;
                    break;
                case "/":
                    result = firstVal / secondVal;
                    break;
                default:
                    break;
            }
           
            //float result = firs
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
