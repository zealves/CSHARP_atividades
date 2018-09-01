using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoContasBancarias
{
    class Program
    {
        static void Main(string[] args)
        {
            Titular t;
            t = new Titular(1233,"Alves");
            DateTime dt = new DateTime(2008, 3, 9, 16, 5, 7, 123);
            List<Titular> titulares = new List<Titular>();
            titulares.Add(t);
            Vencimento v;
            v = new Vencimento("xpto","2465876",3.1,13.2,1234,dt,432.2,"312312", titulares);

            Console.WriteLine("Saldo atual: {0}",v.Saldo);
            v.Deposito(54);
            Console.WriteLine("Saldo atual(deposito):{0}",v.Saldo);
            v.Levantamento(10);
            Console.WriteLine("Saldo atual(levantamento):{0}",v.Saldo);


            // ...
            Console.ReadKey();

        }
    }
}
