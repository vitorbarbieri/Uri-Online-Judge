using System;

public class Program
{
    public static void Main()
    {
        double i, j;
        int a, b;

        for (i = 0; i < 2.1; i += 0.2)
        {
            for (j = 1; j <= 3; j++)
            {
                i = Math.Round(i, 2);
                if (i > 0 && i < 1 || i > 1 && i < 2)
                {
                    Console.WriteLine("I=" + i.ToString("F1") + " J=" + (i + j).ToString("F1"));
                }
                else
                {
                    a = (int)i;
                    b = (int)(i + j);
                    Console.WriteLine("I=" + a + " J=" + b);
                }
            }
        }
    }
}