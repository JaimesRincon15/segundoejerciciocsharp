using System;

public class Calculadora
{
    // Método para sumar dos números enteros
    public int Sumar(int a, int b)
    {
        return a + b;
    }

    // Método para restar dos números enteros
    public int Restar(int a, int b)
    {
        return a - b;
    }
}

// Ejemplo de uso
class Program
{
    static void Main()
    {
        // Crear una instancia de Calculadora
        Calculadora calculadora = new Calculadora();

        // Llamar al método Sumar
        int suma = calculadora.Sumar(10, 5);
        Console.WriteLine($"La suma de 10 y 5 es: {suma}");

        // Llamar al método Restar
        int resta = calculadora.Restar(10, 5);
        Console.WriteLine($"La resta de 10 y 5 es: {resta}");
    }
}
