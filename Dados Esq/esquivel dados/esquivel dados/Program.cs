
using System; 

class Program
{
    static void Main()
    {
        Console.Title = "Simulador de Lanzamiento de Dados"; // esta parte del codigo es el título de la consola.
        Console.ForegroundColor = ConsoleColor.Yellow; // aqui agrego el color de texto en amarillo.
        Console.WriteLine("**************************************************");
        Console.WriteLine("Bienvenido al Simulador de Lanzamiento de Dados!"); // agregue instrucciones en un mensaje de bienvenida.
        Console.WriteLine("Presiona Enter para lanzar los dados o Esc para salir.");
        Console.WriteLine("**************************************************");

        Random random = new Random(); //Procedi a crear instancia para generar números aleatorios.

        while (true) // utilize While para el bucle infinito que permita múltiples lanzamientos de dados.
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(); // esta parte espera confirmacion de que tecla presiona el usuario.

            if (keyInfo.Key == ConsoleKey.Escape) // Verificar si se presionó la tecla Esc.
            {
                Console.WriteLine("\nSaliendo del programa..."); // Si el usuario presiono Esc manda un mensaje de salida.
                break; // terminar el programa.
            }
            else if (keyInfo.Key == ConsoleKey.Enter) // Verificar si se presionó la tecla Enter.
            {
                int dado1 = random.Next(1, 7); // Generar un número aleatorio entre 1 y 6 para el dado 1.
                int dado2 = random.Next(1, 7); // Generar un número aleatorio entre 1 y 6 para el dado 2.

                Console.WriteLine($"\nDado 1: {dado1}"); // Muestra el resultado del dado 1.
                Console.WriteLine($"Dado 2: {dado2}"); // Muestra el resultado del dado 2.
                Console.WriteLine($"Total: {dado1 + dado2}\n"); // Muestra la suma de los resultados.
            }
            else
            {
                Console.WriteLine("\nPresiona Enter para lanzar los dados o Esc para salir.");
                // Muestra un mensaje de instrucción si se presionó una tecla diferente.
            }
        }
    }
}
