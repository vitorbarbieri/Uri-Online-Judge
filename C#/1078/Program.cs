using System;

public class Program
{
    public static void Main()
    {
        double num = double.Parse(Console.ReadLine());

        if (num >= 2 || num <= 1000)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " x " + num + " = " + (i * num));
            }
        }
    }
}