using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cliente
    {
        private string _nombre;
        private double _monto;

        public Cliente(string nombre, double monto)
        {
            _nombre = nombre;
            _monto = monto;
        }

        public void Depositar(double deposito)
        {
            _monto += deposito;
            Console.WriteLine($"Deposito de: {deposito} realizado con exito\nSaldo actual: {_monto}");
        }
        public void Extraer(double retiro)
        {
            if(retiro > _monto)
            {
                Console.WriteLine("ERROR: Saldo insuficiente.");
            }
            else
            {
                _monto -= retiro;
                Console.WriteLine($"Retiro exitoso!\nSaldo disponible: {_monto}");
            }
        }
        public double RetornarMonto()
        {
            return _monto;
        }

        //getters y setters
        public double Monto
        {
            get => _monto;
            set { _monto = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
    }
}
