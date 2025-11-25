using System;

public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public static void CrearPersona()
    {
        Console.Clear();
        Console.WriteLine("===== CREAR PERSONA =====");

        Persona p = new Persona();

        Console.Write("Ingrese el nombre:");
        p.Nombre = Console.ReadLine();

        Console.Write("Ingrese la edad: ");
        p.Edad = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nPersona creada:");
        Console.WriteLine($"Nombre: {p.Nombre}");
        Console.WriteLine($"Edad: {p.Edad}");
    }
}
