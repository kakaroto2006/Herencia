using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear las formas
        Circulo circulo = new Circulo(5);      // radio = 5
        Rectangulo rectangulo = new Rectangulo(4, 6); // ancho=4, alto=6

        // Lista polimórfica
        List<Forma> formas = new List<Forma>();
        formas.Add(circulo);
        formas.Add(rectangulo);

        // Recorrer la lista
        foreach (var forma in formas)
        {
            Console.WriteLine($"Forma: {forma.Nombre}");
            Console.WriteLine($"Área: {forma.CalcularArea()}");
            Console.WriteLine("-------------------------------");
        }

        Console.ReadLine();
    }
}


