using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Persona
    {
        private string _nombre;
        private int _edad;
        private char _genero;

        //constructor

        public Persona()
        {

        }

        public Persona(string nombre, int edad, char genero)
        {
            _edad = edad;
            _genero = genero;
            _nombre = nombre;

            Console.WriteLine("Cliente creado exitosamente.\n\n");
        }

        //metodos
        public void MostrarDetalles()
        {
            Console.WriteLine($"Nombre: {_nombre}\nEdad: {_edad}");
            if(_genero == char.Parse("M"))
            {
                Console.WriteLine("Genero: Masculino");
            }
            else
            {
                Console.WriteLine("Genero: Femenino");
            }
        }
        
        public void MostrarEdadEnDias()
        {
            Console.WriteLine($"La edad de este usuario es: {_edad}, esta convertida en dias es: {_edad * 365}");
        }

        //getters y setters
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Edad { get => _edad; set => _edad = value; }
        public char Genero { get => _genero; set => _genero = value; }
    }
}
