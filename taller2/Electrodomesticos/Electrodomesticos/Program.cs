using System;

namespace Electrodomesticos // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa electrodomesticos: ");

            Console.WriteLine("Debes ingresar 10 electrodomesticos, puedes elegir entre las siguientes categorias:\n" +
                "Electrodomestico, Lavadoras o Televisores.");

            int contador = 0;

            do 
            {

                int case1;
                Console.WriteLine("Ingresando el Electrodomestico: " + contador + 1);
                Console.WriteLine("Seleccione un producto a registrar:\n" +
                    "1. Electrodomesticos.\n2. Lavadoras.\n3. Televisores.");
                Console.WriteLine("Ingrese su eleccion:");
                case1 = int.Parse(Console.ReadLine());

                switch (case1)
                {
                    case 1:
                        int case2;
                        Console.WriteLine("Sub-menú electrodomesticos:");
                        Console.WriteLine("1. Deseo ingresar manualmente el precio, peso, consumo electrico y color del producto.\n" +
                            "2. Deseo ingresar el precio y el peso de mi producto.\n3. Dejar que el sistema elija por mi.");
                        case2 = int.Parse(Console.ReadLine());
                        switch (case2)
                        {
                            case 1:
                                double precio, peso;
                                char consumo;
                                string color;
                                double precioFinal;
                                int case4;
                                Console.WriteLine("Ingrese el precio del producto");
                                precio = double.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el peso del producto");
                                peso = double.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el consumo del producto");
                                consumo = char.Parse(Console.ReadLine());
                                Console.WriteLine("Colores disponibles:\n1. Blanco.\n2. Negro.\n3. Rojo.\n4. Azul\n5. Gris.");
                                case4 = int.Parse(Console.ReadLine());
                                switch (case4)
                                {
                                    case 1:
                                        color = "Blanco";
                                        break;
                                    case 2:
                                        color = "Negro";
                                        break;
                                    case 3:
                                        color = "Rojo";
                                        break;
                                    case 4:
                                        color = "Azul";
                                        break;
                                    case 5:
                                        color = "Gris";
                                        break;
                                    default:
                                        Console.WriteLine("Opción elegida no es valida.");
                                        color = "Blanco";
                                        break;
                                }

                                Electrodomestico electrodomestico = new Electrodomestico(precio, peso, consumo, color);

                                precioFinal = electrodomestico.PrecioFinal();

                                Console.WriteLine("El precio final de este electrodomestico es de: " + precioFinal);

                                break;
                            case 2:
                                double precio2, peso2;
                                double precioFinal2;
                                Console.WriteLine("Ingrese el precio del producto");
                                precio2 = double.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el peso del producto");
                                peso2 = double.Parse(Console.ReadLine());


                                Electrodomestico electrodomestico2 = new Electrodomestico(precio2, peso2);

                                precioFinal2 = electrodomestico2.PrecioFinal();

                                Console.WriteLine("El precio final de este electrodomestico es de: " + precioFinal2);

                                break;
                            case 3:
                                double precioFinal3;
                                Electrodomestico electrodomestico3 = new Electrodomestico();

                                precioFinal3 = electrodomestico3.PrecioFinal();

                                Console.WriteLine("El precio final de este electrodomestico es de: " + precioFinal3);

                                break;
                            default: 

                                break;
                        }
                        break;
                    //LAVADORAS
                    case 2:
                        int case3;
                        Console.WriteLine("Sub-menú electrodomesticos:");
                        Console.WriteLine("1. Deseo ingresar manualmente la carga, precio, peso, consumo electrico y color del producto.\n" +
                            "2. Deseo ingresar el precio y el peso de mi producto.\n3. Dejar que el sistema elija por mi.");
                        case3 = int.Parse(Console.ReadLine());
                        switch (case3)
                        {
                            case 1:
                                double carga;
                                double precio, peso;
                                char consumo;
                                string color;
                                double precioFinal;
                                int case4;
                                Console.WriteLine("Ingrese la carga de lavado");
                                carga = double.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el precio del producto");
                                precio = double.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el peso del producto");
                                peso = double.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el consumo del producto");
                                consumo = char.Parse(Console.ReadLine());
                                Console.WriteLine("Colores disponibles:\n1. Blanco.\n2. Negro.\n3. Rojo.\n4. Azul\n5. Gris.");
                                case4 = int.Parse(Console.ReadLine());
                                switch (case4)
                                {
                                    case 1:
                                        color = "Blanco";
                                        break;
                                    case 2:
                                        color = "Negro";
                                        break;
                                    case 3:
                                        color = "Rojo";
                                        break;
                                    case 4:
                                        color = "Azul";
                                        break;
                                    case 5:
                                        color = "Gris";
                                        break;
                                    default:
                                        Console.WriteLine("Opción elegida no es valida.");
                                        color = "Blanco";
                                        break;
                                }

                                Lavadora lavadora = new Lavadora(carga, precio, peso, consumo, color);

                                precioFinal = lavadora.Precio();

                                Console.WriteLine("El precio final de esta lavadora es de: " + precioFinal);

                                break;
                            case 2:
                                double precio2, peso2;
                                double precioFinal2;
                                Console.WriteLine("Ingrese el precio del producto");
                                precio2 = double.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el peso del producto");
                                peso2 = double.Parse(Console.ReadLine());


                                Lavadora lavadora2 = new Lavadora(precio2, peso2);

                                precioFinal2 = lavadora2.Precio();

                                Console.WriteLine("El precio final de este electrodomestico es de: " + precioFinal2);

                                break;
                            case 3:
                                double precioFinal3;
                                Lavadora lavadora3 = new Lavadora();

                                precioFinal3 = lavadora3.Precio();

                                Console.WriteLine("El precio final de esta lavadora es de: " + precioFinal3);

                                break;
                            default:
                      
                                break;
                        }
                        break;
                    //TELEVISORES
                    case 3:
                        int case4;
                        Console.WriteLine("Sub-menú electrodomesticos:");
                        Console.WriteLine("1. Deseo ingresar manualmente la resolucion, tdt, precio, peso, consumo electrico y color del producto.\n" +
                            "2. Deseo ingresar el precio y el peso de mi producto.\n3. Dejar que el sistema elija por mi.");
                        case4 = int.Parse(Console.ReadLine());
                        switch (case4)
                        {
                            case 1:
                                double resolucion;
                                bool tdt;
                                double precio, peso;
                                char consumo;
                                string color;
                                double precioFinal;
                                int case5;
                                Console.WriteLine("Ingrese la resolucion del tv");
                                resolucion = double.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el precio del producto");
                                precio = double.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el peso del producto");
                                peso = double.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el consumo del producto");
                                consumo = char.Parse(Console.ReadLine());
                                Console.WriteLine("Colores disponibles:\n1. Blanco.\n2. Negro.\n3. Rojo.\n4. Azul\n5. Gris.");
                                case5 = int.Parse(Console.ReadLine());
                                switch (case5)
                                {
                                    case 1:
                                        color = "Blanco";
                                        break;
                                    case 2:
                                        color = "Negro";
                                        break;
                                    case 3:
                                        color = "Rojo";
                                        break;
                                    case 4:
                                        color = "Azul";
                                        break;
                                    case 5:
                                        color = "Gris";
                                        break;
                                    default:
                                        Console.WriteLine("Opción elegida no es valida.");
                                        color = "Blanco";
                                        break;
                                }
                                Console.WriteLine("Tiene tdt?\n1. si.\n2. no.");
                                int eleccion = int.Parse(Console.ReadLine());
                                if(eleccion == 1)
                                {
                                    tdt = true;
                                }
                                else
                                {
                                    tdt = false;
                                }

                                Television televisor = new Television(resolucion, tdt, precio, peso, consumo, color);

                                precioFinal = televisor.Precio();

                                Console.WriteLine("El precio final de este televisor es de: " + precioFinal);

                                break;
                            case 2:
                                double precio2, peso2;
                                double precioFinal2;
                                Console.WriteLine("Ingrese el precio del producto");
                                precio2 = double.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el peso del producto");
                                peso2 = double.Parse(Console.ReadLine());


                                Television televisor2 = new Television(precio2, peso2);

                                precioFinal2 = televisor2.Precio();

                                Console.WriteLine("El precio final de este televisor es de: " + precioFinal2);

                                break;
                            case 3:
                                double precioFinal3;
                                Television televisor3 = new Television();

                                precioFinal3 = televisor3.Precio();

                                Console.WriteLine("El precio final de este televisor es de: " + precioFinal3);

                                break;
                            default:

                                break;
                        }
                        break;
                    default:
                        break;
                }


                contador++; 

            } while (contador < 10);

            }
        }
    }
}