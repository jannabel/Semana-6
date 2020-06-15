using System;

public class Ejercicio_3
{
    public Ejercicio_3()
    {
        /*3. Crear un programa que me diga la cantidad de digitos que tiene un numero positivo.
              Mostrar en mensaje ej: El numero ingresado tiene (N) digitos.*/

        Console.Write("\n ~ Ingrese un numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero > 0)
        {
            string n = Convert.ToString(numero);

            Console.WriteLine("\n ~ El numero ingresado tiene {0} digitos. ~ ", n.Length);

        }
        else
        {
            Console.WriteLine("\n ~ El  numero ingresado es negativo ~ ");
        }
        Console.ReadKey();
    }
}
