using System;

public class Ejercicio_2
{
    public Ejercicio_2()
    {
        /* 2. Crear una aplicacion que le pida al usuario un numero positivo y 
                                el sistema identifique si es primo o no.*/

        Console.Write("\n ~ Ingrese un numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero > 0)
        {
            if (numero % 2 != 0 || numero == 2) Console.WriteLine("\n ~ El numero es primo ~ ");
            else Console.WriteLine("\n ~ El numero no es primo ~ ");
        }
        else
        {
            Console.WriteLine("\n ~ El  numero ingresado es negativo ~ ");
        }
        Console.ReadKey();

    }
}
