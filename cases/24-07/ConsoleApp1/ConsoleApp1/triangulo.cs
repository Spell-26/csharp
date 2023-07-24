using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Triangulo
    {
        private double _lado1, _lado2, _lado3;
        public Triangulo(double lado1, double lado2, double lado3)
        {
            _lado1 = lado1;
            _lado2 = lado2;
            _lado3 = lado3;
        }
        public string LadoMayor()
        {
            string result;
                    
            if(_lado1 > _lado2 && _lado1 > _lado3)
            {
                result = "El lado 1 es el mayor con una longitud de: " + _lado1;
            }
            else if(_lado2 > _lado1 && _lado2 > _lado3)
            {
                result = "El lado 2 es el mayor con una longitud de: " + _lado2;
            }
            else
            {
                result = "El lado 3 es el mayor con una longitud de: " + _lado3;
            }

            return result;
        }
        public string IsEquilatero()
        {
            string result;

            if(_lado1 == _lado2 && _lado1 == _lado3)
            {
                result = "El triangulo es equilatero con una longitud de: " + _lado1 + " por lado.";
            }
            else
            {
                result = "El triangulo no es equilatero, medidas por lado: \nLado 1: "+_lado1
                    +"\nLado 2: "+_lado2+"\nLado 3: "+_lado3;
            }

            return result;
        }

        //getters y setters

    }
}
