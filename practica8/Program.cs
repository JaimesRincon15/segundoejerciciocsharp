using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear una lista de números enteros
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Imprimir cada número en la lista
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}
