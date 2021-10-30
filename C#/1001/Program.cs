using System;
using System.Globalization;

public class Program
{
    public static void Main()
    {
        double raio = double.Parse(Console.ReadLine());

        double area = 3.14159 * Math.Pow(raio, 2);

        Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
    }
}