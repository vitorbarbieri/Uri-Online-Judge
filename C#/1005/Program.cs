using System;

public class Program
{
    public static void Main()
    {
        double A, B, MEDIA;

        A = double.Parse(Console.ReadLine());
        B = double.Parse(Console.ReadLine());

        MEDIA = (A * 3.5 + 7.5 * B) / 11;

        Console.WriteLine("MEDIA = " + MEDIA.ToString("F5"));
    }
}