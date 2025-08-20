using System;

class Program
{
    static void Main(string[] args)
    {
        // Variable que va almacenar lo que ingrese el usuario 
        int opcion;
        //Inicia el ciclo 
        do
        {
            // Bloque de codigo del menu principal
            Console.Clear();
            Console.WriteLine("========================");
            Console.WriteLine("==== MENU PRINCIPAL ====");
            Console.WriteLine("========================");
            Console.WriteLine("0. Crear Torneo");
            Console.WriteLine("1. Registro Equipos");
            Console.WriteLine("2. Registro Jugadores");
            Console.WriteLine("3. Transferencias (Compra, Préstamo)");
            Console.WriteLine("4. Estadísticas"); 
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            // Condicion que evalua que la opcion sea valida
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida\nPresione una tecla para reintentar...");
                Console.ReadKey();
                continue;
            }

            // Evalua el entero guardado en la variable opcion
            switch (opcion)
            {
                case 0:
                    // Llama al submenú de torneos
                    TorneoMenu.Mostrar();
                    break;
                case 1:
                    Console.WriteLine("Registro de Equipos...");
                    break;
                case 2:
                    Console.WriteLine("Registro de Jugadores...");
                    break;
                case 3:
                    Console.WriteLine("Transferencias (Compra, Préstamo)...");
                    break;
                case 4:
                    Console.WriteLine("Mostrando Estadísticas...");
                    break;
                case 5:
                    Console.WriteLine("Saliendo del sistema...");
                    break;
            }

            //Evalua si el entero es mayor que 5 imprime ese mensaje 
            if (opcion != 5)
            {
                Console.WriteLine("La opcion ingresada supera el rango de opciones.\nPresione cualquier tecla para reintentar...");
                Console.ReadKey();
            }
        // Condicion para que termine el ciclo 
        } while (opcion != 5);
    }
}


