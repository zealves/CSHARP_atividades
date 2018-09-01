using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAtividade3
{
    class Ponto
    {
        //Var. de classe
        static int totalPontos = 0;
        //Var. de Instância
        private int x;
        private int y;
     
        //Propriedades
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        //Metodo de Classe
        public static int TotalPontos
        {
            get { return totalPontos; }
        }
        //Construtor
        public Ponto() { x = 0; y = 0; incPontos(); }
        public Ponto(int x,int y)
        {
            this.x = x;
            this.y = y;
            incPontos();
        }

        //Método Classe
        public static void incPontos()
        {
            totalPontos++;
        }

        //Métodos Instância
        public void decCoordenadas(int deltaX,int deltaY)
        {
            x = x + deltaX;
            y = y - deltaY;
        }
        public void incCoordenadas(int deltaX, int deltaY)
        {
            x = x + deltaX;
            y = y - deltaY;
        }

        //determinar se ambas as coordenadas sao positivas
        public bool positivas()
        {
            return x > 0 && y > 0;
        }
        //Reescrever o método ToString da class Object
        public override string ToString()
        {
            string s;
            s = "(" + x + "," + y + ")";
            return s;
        }
    }
}
