using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Libro
    {
        public string _nombre;
        private string _autor;
        private int _cantidadPaginas;

        //constructor
        public Libro(string nombre, string autor, int cantidadPaginas)
        {
            _nombre = nombre;
            _autor = autor;
            _cantidadPaginas = cantidadPaginas;
        }

        //methods

        public string Descripcion()
        {
            return $"{_nombre} por {_autor} y cantidad de paginas: {_cantidadPaginas}";
        }

        //getters y setters
        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }
        public string Autor
        {
            get => _autor;
            set => _autor = value;
        }
        public int CantidadPaginas
        {
            get => _cantidadPaginas;
            set => _cantidadPaginas = value;
        }
    }
}
