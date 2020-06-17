using System;

public class Ejercicio_5
{
	public Ejercicio_5()
	{
        //Jannabel Ramos Ramirez   MAT. 2019-8510

        // 5. Crear una aplicacion que muestre la cantidad de 0 que hay del 1 al 100.

        //string[] numeros = new string[100];
        string a = ".";
        char y;
        int contador = 0;

        for (int i = 1; i <= 100; i++)
        {
            a += Convert.ToString(i);
        }

        for (int q = 1; q < a.Length; q++)
        {
            y = a[q];
            if (y == '0')
            {
                contador++;
            }
        }

        Console.WriteLine("/n ~ EL numero de ceros es: " + contador);
        Console.ReadKey();
    }
}
