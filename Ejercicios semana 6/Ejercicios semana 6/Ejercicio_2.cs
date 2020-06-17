using System;

public class Ejercicio_2
{
    public Ejercicio_2()
    {
        /* 2. Crear una aplicacion que le pida al usuario un numero positivo y 
                               el sistema identifique si es primo o no.*/

        Console.Write("\n ~ Ingrese un numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        int cont = 0;

        for (int i = 1; i < (numero + 1); i++)
        {
            if (numero % i == 0)
            {
                cont++;
            }
        }
        if (cont != 2)
        {
            Console.WriteLine(" ~ El numero no es primo");
        }
        else
        {
            Console.WriteLine(" ~ El numero es primo");
        }

        Console.ReadKey();
    }
}
