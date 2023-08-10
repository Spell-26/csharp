using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    internal class Electrodomestico
    {
        private double _precio_base, _peso;
        private char _consumo;
        private string _color;
        private double _precioFinal;

        public double Precio_base { get => _precio_base; set => _precio_base = value; }
        public double Peso { get => _peso; set => _peso = value; }
        public char Consumo { get => _consumo; set => _consumo = value; }
        public string Color { get => _color; set => _color = value; }

        public Electrodomestico(double precio_base, double peso, char consumo, string color)
        {
            _precio_base = precio_base;
            _peso = peso;
            ComprobarColor(color);
            ComprobarConsumoEnergetico(consumo);
        }
        public Electrodomestico() {
            _precio_base = 100;
            _peso = 5;
            ComprobarColor();
            ComprobarConsumoEnergetico();
        }
        public Electrodomestico(double precio_base, double peso)
        {
            _precio_base=precio_base;
            _peso=peso;
            ComprobarColor();
            ComprobarConsumoEnergetico();
        }

        private void ComprobarConsumoEnergetico(char letra)
        {
            char[] consumos = { 'A', 'B', 'C', 'D', 'E', 'F', 'a', 'b', 'c', 'd', 'e', 'f' };

            if(consumos.Contains(letra))
            {
                Consumo = letra;
            }
            else {
                Console.WriteLine("Consumo especificado no existe, añadiendo consumo por defecto (F)");
                Consumo = 'F';
            }
        }
        private void ComprobarConsumoEnergetico()
        {
             Consumo = 'F';
        }

        private void ComprobarColor(string color)
        {
            string[] colores = { "Blanco", "Negro", "Rojo", "Azul", "Gris" };

            if(colores.Contains(color))
            {
                Color = color;
            }
            else
            {
                Color= "Blanco";
            }
        }
        private void ComprobarColor()
        {
            Color = "Blanco";
        }
        public double PrecioFinal()
        {
            if(Consumo == 'A' || Consumo == 'a')
            {
                _precioFinal = Precio_base + 100;
            }
            else if(Consumo == 'B' || Consumo == 'b') {
                _precioFinal=Precio_base + 80;
            }

            else if (Consumo == 'C' || Consumo == 'c')
            {
                _precioFinal = Precio_base + 60;
            }

            else if (Consumo == 'D' || Consumo == 'd')
            {
                _precioFinal = Precio_base + 50;
            }
            else if (Consumo == 'E' || Consumo == 'e')
            {
                _precioFinal = Precio_base + 30;
            }
            else if (Consumo == 'F' || Consumo == 'f')
            {
                _precioFinal = Precio_base + 10;
            }

            if (Peso >= 0 && Peso < 20)
            {
                _precioFinal += 10;
            }
            else if (Peso >= 20 && Peso < 50) {
                _precioFinal += 50;
            }
            else if (Peso >= 50 && Peso < 80)
            {
                _precioFinal += 80;
            }
            else if (Peso >= 80)
            {
                _precioFinal += 100;
            }

            return _precioFinal;
        }
    }
}
