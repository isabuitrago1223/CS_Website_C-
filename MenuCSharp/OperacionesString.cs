using System;


namespace MenuCSharp{
public class OperacionesString
{
    public static void Ejecutar()
    {
        Console.Clear();
        Console.WriteLine("===== OPERACIONES CON STRING =====");

        Console.Write("Escribe un texto:");
        string texto = Console.ReadLine();

        Console.WriteLine($"\nLongitud: {texto.Length}");
        Console.WriteLine($"En mayúscula: {texto.ToUpper()}");
        Console.WriteLine($"En minúscula: {texto.ToLower()}");
        Console.WriteLine($"¿Contiene la palabra 'hola'? {texto.Contains("hola")}");
    }
}
}
