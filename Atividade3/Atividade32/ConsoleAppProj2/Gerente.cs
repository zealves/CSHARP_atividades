using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProj2
{
    class Gerente : Funcionario , IGeradorJSON
    {
        public int NumSubordinados { get; set; }
        public int TempoGerencia { get; set; }
        public double Bonus { get; set; }

        public string GeraJSON()
        {
            return "12";
        }

        public Gerente(int num,int tempo, double bonus,int i, string n, double s, Departamento d) : base(i, n, s, d)
        {
            NumSubordinados = num;
            TempoGerencia = tempo;
            Bonus = bonus;
        }
        public override string ToString()
        {
            return "NumSubordinados: " + NumSubordinados + "  TempoGerencia: " + TempoGerencia + " Bonus: " + Bonus;
        }

        public int getNumeroSubordinados()
        {
            return NumSubordinados;
        }

        public int getTempoGerencia()
        {
            return TempoGerencia;
        }
        public double getBonus()
        {
            return Bonus;
        }

        public override double CalculaSalario()
        {
            return Salario + (Salario * Bonus);
        }

        public override string FuncInfo()
        {
            return TempoGerencia.ToString();
        }

       
    }
}
