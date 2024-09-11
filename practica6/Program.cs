using System;

public class Rectangulo
{
    // Propiedad para almacenar el ancho del rectángulo
    public double Ancho { get; set; }

    // Propiedad para almacenar el alto del rectángulo
    public double Alto { get; set; }

    // Constructor para inicializar las propiedades Ancho y Alto
    public Rectangulo(double ancho, double alto)
    {
        Ancho = ancho;
        Alto = alto;
    }

    // Método para calcular el área del rectángulo
    public double CalcularArea()
    {
        return Ancho * Alto;
    }
}

// Ejemplo de uso
class Program
{
    static void Main()
    {
        // Crear una instancia de Rectangulo con ancho 5 y alto 10
        Rectangulo rectangulo = new Rectangulo(5, 10);

        // Llamar al método CalcularArea
        double area = rectangulo.CalcularArea();
        Console.WriteLine($"El área del rectángulo es: {area}");
    }
}
