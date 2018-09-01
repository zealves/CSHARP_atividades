using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoContasBancarias
{
    public abstract class Normal
    {
        public long NumeroConta { get; set; }
        public DateTime DataCriacao { get; set; }
        public double Saldo { get; set; }
        public string NIB { get; set; }
        public List<Titular> Titulares { get; set; }

        public Normal(long nc,DateTime dc,double s,string nib,List<Titular> t)
        {
            NumeroConta = nc;
            DataCriacao = dc;
            Saldo = s;
            NIB = nib;
            Titulares = t;
        }

        public void Deposito(double valor)
        {
            Saldo = Saldo + valor;
        }

        public void Levantamento(double valor)
        {
            double temp = 0;
            temp = Saldo - valor;
            if (temp > 0)
                Saldo = temp;

        }

        public override string ToString()
        {
            return "NumeroConta: " + NumeroConta + " DataCriacao: " + DataCriacao;
        }
    }
}
