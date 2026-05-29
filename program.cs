using System ;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> pedidos = new Stack<string>();

        pedidos.Push("Tacos");
        pedidos.Push("Torta");
        pedidos.Push("Agua");
        pedidos.Push("Cafe");
        pedidos.Push("Sandwich");

        string actual = pedidos.Peek();
        Console.WriteLine($"Tope actual: {actual}");
        Console.WriteLine(pedidos.Count);

        string retirado = pedidos.Pop();
        Console.WriteLine($"Se retiro: {retirado}");
        Console.WriteLine(pedidos.Count);

        Console.WriteLine(pedidos.Peek());
        // los cambios para guardar
    }
}
