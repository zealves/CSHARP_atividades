using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProj2
{
    public abstract class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public Departamento DEpartamento { get; set; }

        public Funcionario(int i,string n, double s,Departamento d)
        {
            Id = i;
            Nome = n;
            Salario = s;
            DEpartamento = d;
        }

        public override string ToString()
        {
            return "id: " + Id + "  Nome: " + Nome + " Salario: " + Salario;
        }

        public abstract double CalculaSalario();
        public abstract string FuncInfo();
    }
}
