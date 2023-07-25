using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Vuelo
    {
        private string _aerolinea;
        private DateTime _fechaSalida;
        private int _asientosDisponibles;
        private string  _destino;
        private DateTime  _horaSalida;

        public Vuelo(string aerolinea, DateTime fechaSalida, int asientosDisponibles)
        {
            _aerolinea = aerolinea;
            _fechaSalida = fechaSalida;
            _asientosDisponibles = asientosDisponibles;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Aerolinea: {_aerolinea}\nDestino: {_destino}\nHora de salida: {_horaSalida}\nAsientos disponibles {_asientosDisponibles}");
        }
        public void ReservarAsiento()
        {
            if(_asientosDisponibles > 0)
            {
                _asientosDisponibles -= 1;
                Console.WriteLine($"Asiento asignado exitosamente. Número de asientos restantes: {_asientosDisponibles}");
            }
            else
            {
                Console.WriteLine($"Limite de asientos excedido, no se ha podido reservar.");
            }
        }


        public string Aerolinea { get => _aerolinea; set => _aerolinea = value; }
        public DateTime FechaSalida { get => _fechaSalida; set => _fechaSalida = value; }
        public int AsientosDisponibles { get => _asientosDisponibles; set => _asientosDisponibles = value; }
        public string Destino { get => _destino; set => _destino = value; }
        public DateTime HoraSalida { get => _horaSalida; set => _horaSalida = value; }
    }
}
