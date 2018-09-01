using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, nome1, nome2, nome3, apelido1, apelido2, apelido3;
            int nota1, nota2, nota3, int1, int2, int3;
            float media;

            
            //2
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

            

            //2.2
            /*
            Console.WriteLine("1К numero inteiro:");
            int1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2К numero inteiro:");
            int2 = int.Parse(Console.ReadLine());
            Console.WriteLine("3К numero inteiro:");
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
            */


            //2.3
            /*
            Console.WriteLine("1К nome:");
            nome1 = Console.ReadLine();
            Console.WriteLine("apelido:");
            apelido1 = Console.ReadLine();
            Console.WriteLine("2К nome:");
            nome2 = Console.ReadLine();
            Console.WriteLine("apelido:");
            apelido2 = Console.ReadLine();
            Console.WriteLine("3К nome:");
            nome3 = Console.ReadLine();
            Console.WriteLine("apelido:");
            apelido3 = Console.ReadLine();

            Console.Write(nome1 + ',' + apelido1 + '\n');
            Console.Write(nome2 + ',' + apelido2 + '\n');
            Console.Write(nome3 + ',' + apelido3 + '\n');
            Console.ReadLine();
            */

            //2.4
            /*
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
            Console.WriteLine("Multiplicaчуo dos pares:" + multPares);
            Console.ReadLine();
            */

            //2.5
            /*
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
            */

            //2.6
            /*
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
                default:
                    break;
            }
            */
            //float result = firs
            //Console.WriteLine(result);
        }
    }
}
