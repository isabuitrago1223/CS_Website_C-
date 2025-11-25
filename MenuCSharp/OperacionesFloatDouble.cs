using System;

public class OperacionesFloatDouble
{
    public static void Ejecutar()
    {
        Console.Clear();
        Console.WriteLine("===== FLOAT Y DOUBLE =====");

        Console.Write("Ingrese un número FLOAT: ");
        float f = float.Parse(Console.ReadLine());

        Console.Write("Ingrese un número DOUBLE: ");
        double d = double.Parse(Console.ReadLine());

        Console.WriteLine($"\nFLOAT * DOUBLE = {f * d}");
        Console.WriteLine($"DOUBLE / FLOAT = {d / f}");
    }
}
