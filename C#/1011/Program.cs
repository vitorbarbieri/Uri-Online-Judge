using System;

public class Program
{
    public static void Main()
    {
        double raio, volume;

        raio = double.Parse(Console.ReadLine());

        volume = (4.0 / 3) * 3.14159 * Math.Pow(raio, 3);

        Console.WriteLine("VOLUME = " + volume.ToString("F3"));       
    }
}