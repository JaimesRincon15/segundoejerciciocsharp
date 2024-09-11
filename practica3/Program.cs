using System;

public class ConversorTemperatura
{
    // Método para convertir Celsius a Fahrenheit
    public double CelsiusAFahrenheit(double gradosCelsius)
    {
        return (gradosCelsius * 9 / 5) + 32;
    }
}

// Ejemplo de uso
class Program
{
    static void Main()
    {
        // Crear una instancia de ConversorTemperatura
        ConversorTemperatura conversor = new ConversorTemperatura();

        // Convertir una temperatura de Celsius a Fahrenheit
        double temperaturaCelsius = 25.0;
        double temperaturaFahrenheit = conversor.CelsiusAFahrenheit(temperaturaCelsius);
        Console.WriteLine($"{temperaturaCelsius} grados Celsius son {temperaturaFahrenheit} grados Fahrenheit.");
    }
}
