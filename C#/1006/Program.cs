using System;

public class Program
{
    public static void Main()
    {
        double A, B, C, MEDIA;

        A = double.Parse(Console.ReadLine());
        B = double.Parse(Console.ReadLine());
        C = double.Parse(Console.ReadLine());

        MEDIA = (A * 2 + B * 3 + C * 5) / 10;

        Console.WriteLine("MEDIA = " + MEDIA.ToString("F1"));
    }
}