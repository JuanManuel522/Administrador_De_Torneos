using System;
using System.Collections.Generic;

public static class TorneoMenu
{
    static List<string> torneos = new List<string>();

    public static void Mostrar()
    {
        // Variable que alamacena lo que digite el usuario
        int opcion;

        // Inicia el ciclo
        do
        {
            //Bloque de codigo que muestra el menu torneo
            Console.Clear();
            Console.WriteLine("=== MENU DE TORNEOS ===");
            Console.WriteLine("0.1 Agregar Torneo");
            Console.WriteLine("0.2 Buscar Torneo");
            Console.WriteLine("0.3 Eliminar Torneo");
            Console.WriteLine("0.4 Actualizar Torneo");
            Console.WriteLine("0.5 Regresar al Menu Principal");
            Console.Write("Seleccione una opción: ");

            // Condicion que evalua que la opcion sea un entero
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida\nPresione una tecla para reintentar...");
                Console.ReadKey();
                continue;
            }
            // Evalua si el entero alamcenaqdo en la varibale opcion cumpla con un caso
            switch (opcion)
            {
                case 1:
                    // Metodo añadir torneo
                    AddTorneo();
                    break;
                case 2:
                    // Metodo de buscar torneo
                    BuscarTorneo();
                    break;
                case 3:
                    // Metodo de eliminar torneo
                    EliminarTorneo();
                    break;
                case 4:
                    // Metodo de actualizar torneo
                    ActualizarTorneo();
                    break;
                case 5:
                    // Metodo de regresar al menu principal
                    Console.WriteLine("Regresando al menú principal...");
                    break;
            }
            // Condicion que evalua que la opcion no sea mayor que 5 
            if (opcion != 5)
            {
                Console.WriteLine("La opcion ingresda supera el rango de opciones.\nPresione una tecla para reintentar");
                Console.ReadKey();
            }

        // Condicion para que el ciclo termine
        } while (opcion != 5);
    }

    //Metodo añadir torneo
    static void AddTorneo()
    {
        Console.WriteLine("==== Tipo de Torneo =====");
        Console.WriteLine("1.Torneo Internacional");
        Console.WriteLine("2.Liga");
        Console.WriteLine("Ingrese la opcion: ");
        string? Tipo = Console.ReadLine();
        if (Tipo != null)
        {
            torneos.Add(Tipo);
        }
        else
        {
            Console.WriteLine("Ingrese un tipo de torneo e intente de nuevo.\n Presione una tecla para reintentar.");
        }
        Console.WriteLine("Ingrese el nombre del torneo: ");
        string? nombre = Console.ReadLine();
        if (nombre != null)
        {
            torneos.Add(nombre);
        }
        else
        {
            Console.WriteLine("Ingrese un nombre para el  torneo e intente de nuevo.\n Presione una tecla para reintentar.");
        }
        Console.WriteLine("Torneo agregado exitosamente.");
    }

    static void BuscarTorneo()
    {
        Console.Write("Ingrese el nombre del torneo a buscar: ");
        string nombre = Console.ReadLine() ?? "";

        if (torneos.Contains(nombre))
            Console.WriteLine($"Torneo '{nombre}' encontrado.");
        else
            Console.WriteLine("Torneo no encontrado.");
    }

    static void EliminarTorneo()
    {
        Console.Write("Ingrese el nombre del torneo a eliminar: ");
        string nombre = Console.ReadLine() ?? "";

        if (torneos.Remove(nombre))
            Console.WriteLine("Torneo eliminado.");
        else
            Console.WriteLine("Torneo no encontrado.");
    }

    static void ActualizarTorneo()
    {
        Console.Write("Ingrese el nombre del torneo a actualizar: ");
        string antiguo = Console.ReadLine() ?? "";

        int index = torneos.IndexOf(antiguo);
        if (index != -1)
        {
            Console.Write("Ingrese el nuevo nombre: ");
            string nuevo = Console.ReadLine() ?? "";
            torneos[index] = nuevo;
            Console.WriteLine("Torneo actualizado.");
        }
        else
        {
            Console.WriteLine("Torneo no encontrado.");
        }
    }
}
