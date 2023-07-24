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
            Console.WriteLine("Aplicacion del banco");
            int eleccionMenuInicial;
            Console.WriteLine("¿Que desea realizar hoy?");
            eleccionMenuInicial = int.Parse(Console.ReadLine());

        }
        public static int Menu(int eleccion)
        {
            switch (eleccion)
            {
                case 0:
                    Console.WriteLine("Nuevo cliente.");
                    return 0;
                case 1:
                    Console.WriteLine("Fundar banco");
                    return 1;
                default:
                    Console.WriteLine("Opcion no valida");
                    return -1;
            }

                
        }
        public static void MostrarOpciones1()
        {
            Console.WriteLine("1. Nuevo cliente.\n2. Fundar banco\n3.")
        }
    }
}
