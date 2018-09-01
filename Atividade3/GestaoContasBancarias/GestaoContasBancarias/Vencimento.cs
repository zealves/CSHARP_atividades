using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoContasBancarias
{
    class Vencimento : Normal
    {
        public string EntidadeEmpregadora { get; set; }
        public string NibEntidade { get; set; }
        public double LimiteNegativo { get; set; }
        public double TaxaJuro { get; set; }

        public Vencimento(string ee,string ne,double ln,double tj,long nc, DateTime dc, double s, string nib, List<Titular> t) : base(nc, dc, s, nib, t)
        {
            EntidadeEmpregadora = ee;
            NibEntidade = ne;
            LimiteNegativo = ln;
            TaxaJuro = tj;
        }

        public void Deposito(double valor)
        {
            Saldo = Saldo + valor;
        }

        public void Levantamento(double valor)
        {
            double temp = 0;
            temp = Saldo - valor;
            if (temp >= LimiteNegativo)
                Saldo = temp;

        }

        public override string ToString()
        {
            return "EntidadeEmpregadora: " + EntidadeEmpregadora + " NibEntidade: " + NibEntidade;
        }
    }
}
