using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Aplicacion del banco");
            //int eleccionMenuInicial;
            //Console.WriteLine("¿Que desea realizar hoy?");
            //eleccionMenuInicial = int.Parse(Console.ReadLine());

            //Libro donQuijote = new Libro("Don quijote de la mancha", "Miguel de Servantes", 2700);

            //Producto producto1 = new Producto("Blusa dama", 50000, 10);
            //Producto producto2 = new Producto("Zapatillas oficina", 85000, 11);

            //Console.WriteLine(producto1.MostrarInformacion());
            //Console.WriteLine(producto2.MostrarInformacion());


            // VUELOS

            Console.WriteLine("Sistema de reserva de vuelos");
            int eleccion;

            Console.WriteLine("Fecha del primer vuelo");
            DateTime fechaVuelo1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la aerolinea operadora");
            string aerolinea1 = Console.ReadLine();
            Console.WriteLine("Destino del vuelo: ");
            string destino1 = Console.ReadLine();
            Console.WriteLine("Ingrese los asientos disponibles");
            int asientos1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Fecha del segundo vuelo");
            DateTime fechaVuelo2 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la aerolinea operadora");
            string aerolinea2 = Console.ReadLine();
            Console.WriteLine("Destino del vuelo: ");
            string destino2 = Console.ReadLine();
            Console.WriteLine("Ingrese los asientos disponibles");
            int asientos2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Fecha del tercer vuelo");
            DateTime fechaVuelo3 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la aerolinea operadora");
            string aerolinea3 = Console.ReadLine();
            Console.WriteLine("Destino del vuelo: ");
            string destino3 = Console.ReadLine();
            Console.WriteLine("Ingrese los asientos disponibles");
            int asientos3 = int.Parse(Console.ReadLine());


            Vuelo vuelo1 = new Vuelo(aerolinea1, fechaVuelo1, asientos1);
            vuelo1.Destino = destino1;
            Vuelo vuelo2 = new Vuelo(aerolinea2, fechaVuelo2, asientos2);
            vuelo2.Destino = destino2;  
            Vuelo vuelo3 = new Vuelo(aerolinea3, fechaVuelo3, asientos3);
            vuelo3.Destino = destino3;

            do
            {
                Console.WriteLine("Que deseas hacer hoy?");
                Console.WriteLine("1. Reservar asiento\n2. Mostrar información de vuelos\n3. Salir");
                
                eleccion = int.Parse(Console.ReadLine());

                switch (eleccion)
                {
                    case 1:
                        Console.WriteLine($"Vuelos disponibles a reservar\n1. {vuelo1.Destino}\n2. {vuelo2.Destino}\n3. {vuelo3.Destino}");
                        int eleccionReserva;
                        Console.WriteLine("Seleccione una opcion:");
                        eleccionReserva = int.Parse(Console.ReadLine());
                        switch (eleccionReserva)
                        {
                            //aqui quede
                        }
                    default:
                        Console.WriteLine("Eleccion no valida");
                        break;
                }
            }

        }
        //public static int Menu(int eleccion)
        //{
        //    switch (eleccion)
        //    {
        //        case 0:
        //            Console.WriteLine("Nuevo cliente.");
        //            return 0;
        //        case 1:
        //            Console.WriteLine("Fundar banco");
        //            return 1;
        //        default:
        //            Console.WriteLine("Opcion no valida");
        //            return -1;
        //    }

                
        //}
        //public static void MostrarOpciones1()
        //{
        //    Console.WriteLine("1. Nuevo cliente.\n2. Fundar banco\n3.")
        //}
    }
}
