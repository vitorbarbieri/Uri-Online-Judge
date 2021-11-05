using System;

public class Program
{
    public static void Main()
    {
        double s = 1, divisao;
        int dividendo = 3, divisor = 2;

        while (dividendo <= 39)
        {
            divisao = (double)dividendo / divisor;
            s += divisao;
            dividendo += 2;
            divisor *= 2;
        }
        Console.WriteLine(s.ToString("F2"));
    }
}