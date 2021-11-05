using System;

public class Program
{
    public static void Main()
    {
        double s = 1, divisao;
        int dividendo = 1, divisor = 2;

        while (divisor <= 100)
        {
            divisao = (double)dividendo / divisor;
            s += divisao;
            divisor += 1;
        }
        Console.WriteLine(s.ToString("F2"));
    }
}