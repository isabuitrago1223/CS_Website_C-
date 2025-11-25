using System;

public class Menu
{
    public static void MostrarMenu()
    {
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("===== MENU PRINCIPAL =====");
            Console.WriteLine("1. Operaciones con INT");
            Console.WriteLine("2. Manejo de STRINGS");
            Console.WriteLine("3. Operaciones con FLOAT y DOUBLE");
            Console.WriteLine("4. Uso de BOOLEAN");
            Console.WriteLine("5. Crear objeto Persona ");
            Console.WriteLine("0. Salir");
            Console.Write("\nSeleccione una opción");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    OperacionesInt.Ejecutar ();
                    break;
                case 2:
                    OperacionesString.Ejecutar();
                    break;
                case 3:
                    OperacionesFloatDouble.Ejecutar();
                    break;
                case 4:
                    OperacionesBoolean.Ejecutar();
                    break;
                case 5:
                    Persona.CrearPersona();
                    break;
                case 0:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();

        } while (opcion != 0);
    }
}
