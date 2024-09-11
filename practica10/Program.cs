using System;

public class CalculadoraFactorial
{
    // Método para calcular el factorial de un número entero
    public long CalcularFactorial(int numero)
    {
        if (numero < 0)
        {
            throw new ArgumentException("El número debe ser no negativo.");
        }
        
        long resultado = 1;
        
        for (int i = 1; i <= numero; i++)
        {
            resultado *= i;
        }
        
        return resultado;
    }
}

// Ejemplo de uso
class Program
{
    static void Main()
    {
        // Crear una instancia de CalculadoraFactorial
        CalculadoraFactorial calculadora = new CalculadoraFactorial();

        // Definir un número para calcular su factorial
        int numero = 5;

        // Calcular el factorial del número
        long factorial = calculadora.CalcularFactorial(numero);
        
        // Mostrar el resultado
        Console.WriteLine($"El factorial de {numero} es: {factorial}");
    }
}
