using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Banco
    {
        private Cliente _cliente1;
        private Cliente _cliente2;
        private Cliente _cliente3;

        public Banco(Cliente cliente1, Cliente cliente2, Cliente cliente3)
        {
            _cliente1 = cliente1;
            _cliente2 = cliente2;
            _cliente3 = cliente3;
        }

        public double DepositosTotales()
        {
            double result = _cliente1.Monto + _cliente2.Monto + _cliente3.Monto;

            return result;
        }

        public Cliente Cliente1
        {
            get { return _cliente1; }
            set { _cliente1 = value; }
        }
        public Cliente Cliente2
        {
            get { return _cliente2; }
            set { _cliente2 = value; }
        }
        public Cliente Cliente3
        {
            get { return _cliente3; }
            set { _cliente3 = value; }
        }
    }
}
