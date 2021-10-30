using System;

public class Program
{
    public static void Main()
    {
        double n1 = double.Parse(Console.ReadLine());
        double n2 = double.Parse(Console.ReadLine());
        double n3 = double.Parse(Console.ReadLine());
        double n4 = double.Parse(Console.ReadLine());
        double n5 = double.Parse(Console.ReadLine());
        double n6 = double.Parse(Console.ReadLine());

        int quantidadePositivos = 0;
        double somaPositivos = 0;
        if (n1 > 0) 
        {
            quantidadePositivos += 1;
            somaPositivos += n1;
        }
        if (n2 > 0) 
        {
            quantidadePositivos += 1;
            somaPositivos += n2;
        }
        if (n3 > 0) 
        {
            quantidadePositivos += 1;
            somaPositivos += n3;
        }
        if (n4 > 0) 
        {
            quantidadePositivos += 1;
            somaPositivos += n4;
        }
        if (n5 > 0) 
        {
            quantidadePositivos += 1;
            somaPositivos += n5;
        }
        if (n6 > 0) 
        {
            quantidadePositivos += 1;
            somaPositivos += n6;
        }
        Console.WriteLine(quantidadePositivos + " valores positivos");
        Console.WriteLine((somaPositivos / quantidadePositivos).ToString("F1"));
    }
}