using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    internal class Television : Electrodomestico
    {
        private double _resolucion;
        private bool _TDT;
        public double Resolucion { get => _resolucion; set => _resolucion = value; }
        public bool TDT { get => _TDT; set => _TDT = value; }

        public Television() {
            Resolucion = 20;
            TDT = false;
        }
        public Television(double precio, double peso) : base(precio, peso)
        {
            Resolucion = 20;
            TDT = false;
        }
        public Television(double resolucion, bool tDT, double precio_base, double peso, char consumo, string color)
            : base(precio_base, peso, consumo, color)
        {
            Resolucion = resolucion;
            TDT = tDT;
        }

        public double Precio()
        {
            double precioFinal;

            double precioParcial;

            precioParcial = base.PrecioFinal();
            precioFinal = precioParcial;

            if (Resolucion > 40)
            {
                precioFinal += (precioParcial * 30) / 100;
            }
            else if (TDT)
            {
                precioFinal += 50;
            }

            return precioFinal;
        }
    }
}
