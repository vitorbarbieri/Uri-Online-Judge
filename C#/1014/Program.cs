using System;

public class Program
{
    public static void Main()
    {
        int dist;
        double total, media;

        dist = int.Parse(Console.ReadLine());
        total = double.Parse(Console.ReadLine());

        media = dist / total;

        Console.WriteLine(media.ToString("F3") + " km/l");      
    }
}