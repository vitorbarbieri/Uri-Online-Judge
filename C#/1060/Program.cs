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

        int valoresPositivos = 0;
        if (n1 > 0) 
        {
            valoresPositivos += 1;
        }
        if (n2 > 0) 
        {
            valoresPositivos += 1;
        }
        if (n3 > 0) 
        {
            valoresPositivos += 1;
        }
        if (n4 > 0) 
        {
            valoresPositivos += 1;
        }
        if (n5 > 0) 
        {
            valoresPositivos += 1;
        }
        if (n6 > 0) 
        {
            valoresPositivos += 1;
        }
        Console.WriteLine(valoresPositivos + " valores positivos");
    }
}