using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> Clientes = new Queue<string>(); //Crear cola Clientes

        Clientes.Enqueue("Cliente 1");
        Clientes.Enqueue("Cliente 2");
        Clientes.Enqueue("Cliente 3"); //Agregar clientes a la cola Clientes

        MostrarCola(Clientes); //Mostrar el estado de la cola

        Atender(Clientes); //Aquí se atiende al cliente número 1

        MostrarCola(Clientes); //Mostrar de vuelta el estado de la cola

        Clientes.Enqueue("Cliente 4");

        MostrarCola(Clientes);

        Atender(Clientes);

        MostrarCola(Clientes);
    }

    static void MostrarCola(Queue<string> Clientes) //Arreglo para mostrar los clientes
    {
        Console.WriteLine("Cola: "); //Mostrar la cola
        foreach (var cliente in Clientes)
        {
            Console.WriteLine(cliente); //Muestra los clientes
        }
        Console.WriteLine();
    }

    static void Atender(Queue<string> Clientes) //Arreglo para atender a los clientes
    {
        if (Clientes.Count > 0) //Los clientes a ser mayores a 0 se cumple la siguiente condición
        {
            string Atendido = Clientes.Dequeue();
            Console.WriteLine("Atendiendo a Cliente"); //Mostrar que se esta atendiendo a los clientes
        }
        else
        {
            Console.WriteLine("No se esta atendiendo a clientes."); //Si no se cumple la condición de que los clientes son mayores a 0, se muestra este texto
        }
    }
}