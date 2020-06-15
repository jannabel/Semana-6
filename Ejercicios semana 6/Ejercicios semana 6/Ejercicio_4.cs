using System;

public class Ejercicio_4
{
    public Ejercicio_4()
    {
        /*4. Crear una aplicacion que genere un numero aleatorio entre 50 y 100. 
                   Y pida al usuario si desea generar otro numero antes de terminar la aplicacion. 
                    El programa debe terminar cuando el usuario presione la letra 'S'*/

        string continuar;

        do
        {
            Console.Clear();

            var naleatorio = new Random().Next(50, 100);

            Console.WriteLine("\n ~ El numero generado es: " + naleatorio);

            Console.WriteLine("\n ~ Desea generar otro numero antes de terminar la aplicacion? ");
            Console.WriteLine(" ~ Presione S para salir ~");
            Console.WriteLine(" ~ Presione cualquier otra tecla para generar otro numero ~");


            continuar = Console.ReadLine();
            if (continuar == "S") Environment.Exit(0);

        } while (continuar != "S");
    }
}
