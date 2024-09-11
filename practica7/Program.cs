using System;

public class ConversorDivisas
{
    // Método para convertir una cantidad de dinero de una divisa a otra
    public double Convertir(double cantidad, double tasaConversion)
    {
        return cantidad * tasaConversion;
    }
}

// Ejemplo de uso
class Program
{
    static void Main()
    {
        // Crear una instancia de ConversorDivisas
        ConversorDivisas conversor = new ConversorDivisas();

        // Definir una cantidad de dinero y una tasa de conversión
        double cantidad = 100.0; // 100 unidades de la divisa original
        double tasaConversion = 1.12; // Tasa de conversión (por ejemplo, de USD a EUR)

        // Convertir la cantidad usando la tasa de conversión
        double cantidadConvertida = conversor.Convertir(cantidad, tasaConversion);

        // Mostrar el resultado
        Console.WriteLine($"La cantidad de {cantidad} unidades convertida con una tasa de conversión de {tasaConversion} es: {cantidadConvertida}");
    }
}
