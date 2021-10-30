using System;

public class Program
{
    public static void Main()
    {
        string[] valores = Console.ReadLine().Split(' ');
        double x = double.Parse(valores[0]);
        double y = double.Parse(valores[1]);

        if (x == 0 && y == 0)
        {
            Console.WriteLine("Origem");
        }
        else if (x == 0)
        {
            Console.WriteLine("Eixo Y");
        }
        else if (y == 0)
        {
            Console.WriteLine("Eixo X");
        }
        else if (x > 0 && y > 0)
        {
            Console.WriteLine("Q1");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Q4");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Q3");
        }
        else
        {
            Console.WriteLine("Q2");
        }
    }
}