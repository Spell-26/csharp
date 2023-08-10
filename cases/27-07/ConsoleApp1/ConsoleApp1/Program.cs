// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Ejercicios 1 y 2");

int eleccion;

Console.WriteLine("Menu.\n1. Ejercio 1.\n2. Ejercicio 2.");
eleccion = int.Parse(s: Console.ReadLine());

switch (eleccion)
{
    case 1:

        string nombre;
        int edad;
        char genero;

        int eleccionMenuCliente;

        Console.WriteLine("Ejercicio de personas");
        Console.WriteLine("Ingrese el nombre del cliente:");
        nombre = Console.ReadLine();
        Console.WriteLine("Ingrese la edad del cliente:");
        edad = int.Parse(s: Console.ReadLine());
        Console.WriteLine("Ingrese el genero del cliente: M para masculino y F para femenino");
        genero = char.Parse(s: Console.ReadLine());

        //instanciar una persona
        Persona persona = new Persona(nombre, edad, genero);

        Console.WriteLine("Menu del cliente:\n1.Ver informacion del cliente\n2.Ver edad convertida en dias.\n3.Salir del programa");
        eleccionMenuCliente = int.Parse(s: Console.ReadLine());

        switch (eleccionMenuCliente)
        {
            case 1:
                persona.MostrarDetalles();
                break;
            case 2:
                persona.MostrarEdadEnDias();
                break;
            case 3:
                Console.WriteLine("Has salido del programa exitosamente");
                break;
            default: break;
        }

        break;
    default:
        break;
}
