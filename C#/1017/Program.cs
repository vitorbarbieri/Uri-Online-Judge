using System;

public class Program
{
    public static void Main()
    {
        int tempo, velocidade;
        double distancia, qtLitros;

        tempo = int.Parse(Console.ReadLine());
        velocidade = int.Parse(Console.ReadLine());

        distancia = tempo * velocidade;
        qtLitros = distancia / 12;

        Console.WriteLine(qtLitros.ToString("F3"));
    }
}