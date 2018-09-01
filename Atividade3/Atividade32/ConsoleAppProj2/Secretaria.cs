using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProj2
{
    class Secretaria : Funcionario
    {
        
        public int HorasTrabalho { get; set; }
        public bool FalaIngles { get; set; }

        public Secretaria(int horas, bool fala,int i, string n, double s, Departamento d) : base(i, n, s, d)
        {
            HorasTrabalho = horas;
            FalaIngles = fala;
        }

        public override string ToString()
        {
            return "Horas de trab: " + HorasTrabalho + "  FalaIngles: " + FalaIngles;
        }

        public int getHorasTrabalho()
        {
            return HorasTrabalho;
        }

        public bool getFalaIngles()
        {
            return FalaIngles;
        }

        public override double CalculaSalario()
        {
            return Salario;
        }

        public override string FuncInfo()
        {
            return HorasTrabalho.ToString();
        }
    }
}
