using System;

public class OperacionesBoolean
{
    public static void Ejecutar()
    {
        Console.Clear();
        Console.WriteLine("===== BOOLEAN =====");

        Console.Write("Ingrese un número: ");
        int num = int.Parse(Console.ReadLine());

        bool esPar = num % 2 == 0;

        Console.WriteLine($"¿El número es par? {esPar}");
    }
}
