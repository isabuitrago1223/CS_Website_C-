
using System;

public class OperacionesInt
{
    public static void Ejecutar()
    {
        Console.Clear();
        Console.WriteLine("===== OPERACIONES CON INT =====");

        Console.Write("Ingrese número 1:");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Ingrese número 2: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nSuma: {a + b}");
        Console.WriteLine($"Resta: {a - b}");
        Console.WriteLine($"Multiplicación: {a * b}");
        Console.WriteLine($"División: {a / b}");
    }
}
