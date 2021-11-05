using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int fatorial = n;

        if (n > 0 && n < 13)
        {
            for (int i = 1; i < n; i++)
            {
                fatorial *= (n - i);
            }
        }
        Console.WriteLine(fatorial);
    }
}