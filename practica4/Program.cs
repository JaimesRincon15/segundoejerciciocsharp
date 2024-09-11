using System;

public class Persona
{
    // Propiedad para almacenar la edad de la persona
    public int Edad { get; set; }

    // Constructor para inicializar la edad
    public Persona(int edad)
    {
        Edad = edad;
    }

    // Método para verificar si la persona es mayor o menor de edad
    public void VerificarEdad()
    {
        if (Edad >= 18)
        {
            Console.WriteLine("La persona es mayor de edad.");
        }
        else
        {
            Console.WriteLine("La persona es menor de edad.");
        }
    }
}

// Ejemplo de uso
class Program
{
    static void Main()
    {
        // Crear una instancia de Persona con una edad específica
        Persona persona1 = new Persona(20);
        Persona persona2 = new Persona(15);

        // Llamar al método VerificarEdad
        persona1.VerificarEdad(); // Debería imprimir "La persona es mayor de edad."
        persona2.VerificarEdad(); // Debería imprimir "La persona es menor de edad."
    }
}
