using System;

public class TablaMultiplicar
{
    // Método para imprimir la tabla de multiplicar de un número
    public void ImprimirTabla(int numero)
    {
        Console.WriteLine($"Tabla de multiplicar del {numero}:");
        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }
    }
}

// Ejemplo de uso
class Program
{
    static void Main()
    {
        // Crear una instancia de TablaMultiplicar
        TablaMultiplicar tabla = new TablaMultiplicar();

        // Llamar al método ImprimirTabla para imprimir la tabla de multiplicar del número 7
        tabla.ImprimirTabla(7);
    }
}
