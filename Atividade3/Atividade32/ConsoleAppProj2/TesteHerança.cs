using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProj2
{
    class TesteHerança
    {
        static void Main(string[] args)
        {
            Departamento d1;
            d1 = new Departamento(2,"asd");
            d1.DepartId = 2;
            d1.Designacao = "IT";

            Secretaria sec;
            sec = new Secretaria(2,true,2,"nn",2.3,d1);

            Gerente ger;
            ger = new Gerente(2,2,3.2,3,"e",3.2,d1);

            Console.WriteLine("Secretária fala Inglês?:{0}",sec.getFalaIngles());
            Console.WriteLine("Horas de trabalho:{0}", sec.getHorasTrabalho());

            Console.WriteLine("Nº de subordinados:{0}", ger.getNumeroSubordinados());
            Console.WriteLine("Tempo de gerencia:{0}", ger.getTempoGerencia());
            Console.WriteLine("Bonus:{0}", ger.getBonus());

            Console.WriteLine("Salário secretária:{0}", sec.CalculaSalario());
            Console.WriteLine("Departamento:{0}", sec.DEpartamento.Designacao);
            Console.WriteLine("Salário gerente:{0}", ger.CalculaSalario());
            Console.WriteLine("Departamento:{0}", ger.DEpartamento.Designacao);
            Console.ReadKey();

        }
    }
}
