using System;

public class Numero
{
    // Propiedad para almacenar el valor del número
    public int Valor { get; set; }

    // Constructor para inicializar la propiedad Valor
    public Numero(int valor)
    {
        Valor = valor;
    }

    // Método para verificar si el número es par o impar
    public void VerificarParImpar()
    {
        if (Valor % 2 == 0)
        {
            Console.WriteLine($"{Valor} es un número par.");
        }
        else
        {
            Console.WriteLine($"{Valor} es un número impar.");
        }
    }
}

// Ejemplo de uso
class Program
{
    static void Main()
    {
        // Crear instancias de Numero con diferentes valores
        Numero numero1 = new Numero(4);
        Numero numero2 = new Numero(7);

        // Llamar al método VerificarParImpar
        numero1.VerificarParImpar(); // Debería imprimir "4 es un número par."
        numero2.VerificarParImpar(); // Debería imprimir "7 es un número impar."
    }
}
