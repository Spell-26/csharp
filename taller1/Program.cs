using System;

string eleccion;
int opcion;
Console.WriteLine("--- TALLER 1 .NET ---");
Console.WriteLine("MENU:\n1 => Notas aprendiz\n2 => Inversión\n3 => Ganancias vendedor" +
"\n4 => Colillas de pago\n5 => Compra de piezas\n6 => Número a texto\n7 => Vocal o consonante\n8 => Turnos");
Console.WriteLine("Ingrese la opción a la que desea acceder:");

eleccion = Console.ReadLine();
opcion = int.Parse(eleccion);
Console.WriteLine("Eleccion: " + opcion);

switch (opcion)
{
    case 1:
        Console.WriteLine("Ha seleccionado la opción: Notas del aprendiz");
        double nota1, nota2, nota3, resultado;
        string n1, n2, n3;
        bool inputOk = false;
        do
        {
            Console.WriteLine("Ingrese la primera nota:");
            n1 = Console.ReadLine();
            Console.WriteLine("Ingrese la segunda nota:");
            n2 = Console.ReadLine();
            Console.WriteLine("Ingrese la tercera nota:");
            n3 = Console.ReadLine();

            nota1 = int.Parse(n1);
            nota2 = int.Parse(n2);
            nota3 = int.Parse(n3);

            if ((nota1 <= 5 && nota1 >= 0) && (nota2 <= 5 && nota2 >= 0) && (nota3 <= 5 && nota3 >= 0))
            {
                inputOk = true;
                resultado = notasAprendiz(nota1, nota2, nota3);
                Console.WriteLine("Nota final del aprendiz: " + resultado);
            }
            else
            {
                Console.WriteLine("Los datos ingresados no son válidos, intente nuevamente.");
            }
        }
        while (inputOk == false);
        break;
    case 2:
        Console.WriteLine("Ha seleccionado la opción: Inversión.");
        double inversion, utilidad;
        Console.WriteLine("Ingrese la cantidad de dinero a invertir:");
        inversion = double.Parse(Console.ReadLine());
        utilidad = (inversion * 2) / 100;

        Console.WriteLine("La utilidad mensual de la inversión (2%) será de: " + utilidad);
        Console.WriteLine("El saldo total, despues del primer mes, incluyendo la inversión inicial será de: " + (inversion + utilidad));

        break;
    case 3:
        Console.WriteLine("He seleccionado la opcion: Ganancias vendedor.");
        double sueldo, venta1, venta2, venta3, comision1, comision2, comision3;
        Console.WriteLine("Ingrese su sueldo base");
        sueldo = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el valor de la primera venta: ");
        venta1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el valor de la segunda venta: ");
        venta2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el valor de la tercera venta: ");
        venta3 = double.Parse(Console.ReadLine());

        comision1 = venta1 * 0.1;
        comision2 = venta2 * 0.1;
        comision3 = venta3 * 0.1;

        Console.WriteLine("Comisiones de venta:\nVenta 1: " + venta1 + ". Comision: " + comision1 + "\nVenta 2: " + venta1
        + ". Comision: " + comision2 + "\nVenta 3: " + venta3 + ". Comision: " + comision3 + "\nSueldo base: " + sueldo + "\nSueldo más comisiones: "
        + (sueldo + (comision1 + comision2 + comision3)));

        break;
    case 4:
        Console.WriteLine("He seleccionado colillas de pago.");
        double salarioneto, ahorroMensual, salud, pension, salario;
        Console.WriteLine("Ingrese el salario neto: ");
        salarioneto = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el valor del ahorro mensual");
        ahorroMensual = double.Parse(Console.ReadLine());

        salud = salarioneto * 0.125;
        pension = salarioneto * 0.16;

        salario = salarioneto - (salud + pension + ahorroMensual);

        Console.WriteLine("Colilla de pago:\n------------\nSalario neto: " + salarioneto + "\nAhorro programado: " +
        ahorroMensual + "\nDeducciones:\nSalud (12.5%): " + salud + "\nPensión (16%): " + pension + "\n------------\n"
        + "Salario despues de deducciones: " + salario);
        break;
    case 5:
        Console.WriteLine("Ha saleccionado: Compra de piezas.");
        double valorCompra, tope = 5000000, pagoRecursosEmpresa = 0, creditoBancario = 0, creditoFrabricante = 0;
        double interesFabricante = 0;

        Console.WriteLine("Ingrese el valor de la compra a realizar por la empresa: ");
        valorCompra = double.Parse(Console.ReadLine());

        if (valorCompra > 0)
        {

            if (valorCompra >= tope)
            {
                pagoRecursosEmpresa = valorCompra * 0.55;
                creditoBancario = valorCompra * 0.30;
                creditoFrabricante = valorCompra * 0.15;
                interesFabricante = creditoFrabricante * 0.15;
            }
            else
            {
                pagoRecursosEmpresa = valorCompra * 0.70;
                creditoFrabricante = valorCompra * 0.30;
                interesFabricante = creditoFrabricante * 0.15;
            }

            Console.WriteLine("----------\nValor de la compra: " + valorCompra +
            "\nPago con recursos de la empresa: " + pagoRecursosEmpresa + "\nPago con credito bancario: " +
            creditoBancario + "\nPago con credito del fabricante: " + creditoFrabricante +
            "\nIntereses del credito de fabricante: " + interesFabricante + ".");

        }
        else
        {
            Console.WriteLine("Valor ingresado no es válido.");
        }

        break;
    case 6:
        Console.WriteLine("Ha seleccionado: Número a texto.");
        string entrada;

        int primerDigito, segundoDigito, numero;
        Console.WriteLine("Ingrese un número entre el 0 y el 99");
        entrada = Console.ReadLine();

        if(entrada != null ){
            numero = int.Parse(entrada);
            if(numero >= 0 && numero <= 99){
                string respuesta = numberToText(numero);
                Console.WriteLine(respuesta);
            }
            else{
                Console.WriteLine("Valor ingresado no es valido");
            }
        }
        else{
            Console.WriteLine("No se ha ingresado ningun valor");
        }

       
        break;
    case 7:
        Console.WriteLine("Ha seleccionado: Letra o vocal");
        char input;
        char[] vocales = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E','I','O','U'};

        Console.WriteLine("Ingrese una letra: ");
        input = char.Parse(Console.ReadLine());

        if(vocales.Contains(input)){
            Console.WriteLine("Es una vocal");
        }else{
            Console.WriteLine("No es vocal");
        }

        break;
    case 8:
        
        break;
    default:
        Console.WriteLine("Opción incorrecta.");
        break;
}

double notasAprendiz(double nota1, double nota2, double nota3)
{
    double resultado, n1, n2, n3;
    n1 = nota1 * 0.2;
    n2 = nota2 * 0.3;
    n3 = nota3 * 0.5;
    resultado = n1 + n2 + n3;

    return resultado;
}

string numberToText(int numero){
    string resultado = "";

    
    string[] decenas = new string[] {"","", "Veinte", "Treinta", "Cuarenta", "Cinquenta", "Sesenta", "Setenta",
                    "Ochenta", "Noventa"};
    string[] unidades = new string[] { "Cero", "Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve" };
    string[] especiales = new string[] {"Diez","Once", "Doce", "Trece","Catorce",
     "Quince", "Dieciseis","Diecisiete","Dieciocho","Diecinueve"};
    if(numero < 10){
        resultado = unidades[numero];
    }
    if(numero < 20){
        resultado = especiales[numero - 10];
    }
    else{
        int primerDigito = numero / 10;
        int segundoDigito = numero % 10;

        if(segundoDigito == 0){
            resultado = decenas[primerDigito];
        }
        else{
            resultado = decenas[primerDigito] + " y " + unidades[segundoDigito];
        }
    }


    return resultado;
}
