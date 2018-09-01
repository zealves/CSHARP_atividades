using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex22
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> nomes = new List<String>();
            List<double> notas = new List<double>();
            for (int v = 0; v < 3; v++)
            {
                Console.WriteLine("Insira o nome do aluno:");
                string nome = Console.ReadLine();
                Console.WriteLine("Insira a nota:");
                double nota = double.Parse(Console.ReadLine());
                nomes.Add(nome);
                notas.Add(nota);
            }

            nomes.Sort();
            notas.Sort();
            foreach (var name in nomes)
                Console.Write("   {0}", name);
            foreach (var n in notas)
                Console.Write("   {0}", n);

            Console.ReadLine();
        }
    }
}
