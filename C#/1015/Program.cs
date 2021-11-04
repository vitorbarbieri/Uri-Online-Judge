using System;

public class Program
{
    public static void Main()
    {
        string str1, str2;
        double x1, x2, y1, y2, dist;

        str1 = Console.ReadLine();
        string[] vet1 = str1.Split(' ');
        str2 = Console.ReadLine();
        string[] vet2 = str2.Split(' ');

        x1 = double.Parse(vet1[0]);
        y1 = double.Parse(vet1[1]);
        x2 = double.Parse(vet2[0]);
        y2 = double.Parse(vet2[1]);

        dist = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

        Console.WriteLine(dist.ToString("F4"));
    }
}