using System;

public class Program
{
    public static void Main()
    {
        int tempo, hora, minuto, segundo, resto1, resto2;

        tempo = int.Parse(Console.ReadLine());

        hora = tempo / 3600;
        resto1 = tempo % 3600;
        minuto = resto1 / 60;
        resto2 = resto1 % 60;
        segundo = resto2;

        Console.WriteLine(hora + ":" + minuto + ":" + segundo);
    }
}