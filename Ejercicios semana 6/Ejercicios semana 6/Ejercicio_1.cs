using System;

public class Ejercicio_1
{
	public Ejercicio_1() 
	{
        //1. Crear una aplicacion que muestre la tabla de multiplicar del(7), tips usar ciclo while.

        int i = 1;
        Console.WriteLine("\n ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine(" ~~~~~~~~~~~ Tabla del 7 ~~~~~~~~~~~");
        Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ \n");


        while (i <= 12)
        {
            int multiplicacion = 7 * i;
            Console.WriteLine(" 7 x {0} = {1}", i, multiplicacion);
            i++;
        }

        Console.ReadKey();

    }
}
