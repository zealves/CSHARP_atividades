using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoContasBancarias
{
    class Prazo : Normal
    {
        public double TaxaJuroAnual { get; set; }
        public double JuroAnual { get; set; }

        public Prazo(double tja,double ja,long nc, DateTime dc, double s, string nib, List<Titular> t) : base(nc, dc, s, nib, t)
        {
            TaxaJuroAnual = tja;
            JuroAnual = ja;
        }

        public void Deposito(double valor)
        {
            Saldo = Saldo + valor;
        }


        public override string ToString()
        {
            return "taxa de juro anual:" + TaxaJuroAnual + " JuroAnual: " + JuroAnual;
        }
    }
}
