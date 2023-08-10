using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    internal class Lavadora : Electrodomestico
    {
        private double _carga;
        public Lavadora() {
            Carga = 5;
        }
        public Lavadora(double precio, double peso):base(precio, peso) {
            Carga = 5;
        }
        public Lavadora(double carga, double precio_base, double peso, char consumo, string color)
            :base(precio_base, peso, consumo, color)
        {
            Carga = carga;
        }
 

        public double Carga { get => _carga; set => _carga = value; }

        //metodos

        public double Precio()
        {
            double precioFinal;

            double precioParcial;

            precioParcial = base.PrecioFinal();
            precioFinal = precioParcial;

            if(Carga > 30)
            {
                precioFinal += 50;
            }

            return precioFinal;
        }
    }
}
