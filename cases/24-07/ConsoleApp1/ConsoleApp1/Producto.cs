using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Producto
    {
        private string _nombre;
        private double _precio;
        private int _stock;

        public Producto(string nombre, double precio, int stock)
        {
            _nombre = nombre;
            _precio = precio;
            _stock = stock;
            Validar();
        }

        //validators
        //cada validador devuelve un estado, si al final de la validacion el numero es negativo ese terminará la ejecucion
        //del programa
        private void Validar()
        {
            int res = 0;
            res += ValidarPrecio();
            res += ValidarStock();
            if (res <= 0)
            {
                System.Environment.Exit(0);
            }
        }
        private int ValidarPrecio()
        {
            if (_precio < 0)
            {
                Console.WriteLine("El precio no puede ser negativo.");
                return -1;
            }
            return 1;
        }
        private int ValidarStock()
        {
            if(_stock < 0)
            {
                Console.WriteLine("EL stock no puede ser negativo");
                return -1;
            }
            return 1;
        }

        public string MostrarInformacion()
        {
            return $"Nombre del producto: {_nombre}\nPrecio del producto: {_precio}\nExistencias: {_stock}";
        }

        //getters y setters
        public string Nombre { get => _nombre; set => _nombre = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public int Stock { get => _stock; set => _stock = value; }

        

    }
}
