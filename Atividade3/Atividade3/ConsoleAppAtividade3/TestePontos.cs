using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAtividade3
{
    class TestePontos
    {
        static void Main(string[] args)
        {
            //Criar objetos - Pontos
            Ponto p1 = new Ponto();
            Ponto p2 = new Ponto(2, -1);
            Ponto p3 = new Ponto(0, 2);

            //imprimir os pontos p1,p2,p3
            Console.WriteLine("--------- Pontos iniciais-------");
            Console.WriteLine("Ponto p1:({0},{1}) ", p1.X, p1.Y);
            Console.WriteLine("Ponto p2:({0},{1}) ", p2.X, p2.Y);
            Console.WriteLine("Ponto p3:({0},{1}) ", p3.X, p3.Y);

            p1.incCoordenadas(5,10);
            p2.incCoordenadas(15,4);
            p3.incCoordenadas(3,8);

            Console.WriteLine(" ------------ Pontos alterados ----------");
            Console.WriteLine("Ponto p1:({0}) ", p1.ToString());
            Console.WriteLine("Ponto p2:({0}) ", p2.ToString());
            Console.WriteLine("Ponto p3:({0}) ", p3.ToString());

            Console.WriteLine(" ------------ Soma de coordenadas pi e p2 ----------");
            Console.WriteLine("Soma das coordenadas X: {0} ", p1.X + p2.X);
            Console.WriteLine("Soma das coordenadas Y: {0} ", p1.Y + p2.Y);

            Console.WriteLine("O Ponto p1 tem coordenadas Negativas?: {0} ", p1.positivas());
            Console.WriteLine("O Ponto p2 tem coordenadas Negativas?: {0} ", p2.positivas());
            Console.WriteLine("O Ponto p3 tem coordenadas Negativas?: {0} ", p3.positivas());
            Console.WriteLine(" -------- Total de pontos -----------");
            Console.WriteLine(" Total de pontos: {0}", Ponto.TotalPontos);

            Console.ReadKey();
        }
    }
}
