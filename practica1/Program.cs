using System;

public class Persona
{
    // Propiedad para almacenar el nombre de la persona
    public string Nombre { get; set; }

    // Constructor para inicializar el nombre
    public Persona(string nombre)
    {
        Nombre = nombre;
    }

    // Método para saludar
    public void Saludar()
    {
        Console.WriteLine($"¡Hola, mi nombre es {Nombre}!");
    }
}

// Ejemplo de uso
class Program
{
    static void Main()
    {
        // Crear una instancia de Persona
        Persona persona = new Persona("Juan");

        // Llamar al método Saludar
        persona.Saludar();
    }
}
