using System;

public class Program
{
    public static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int n4 = int.Parse(Console.ReadLine());
        int n5 = int.Parse(Console.ReadLine());

        int valoresPares = 0;
        if (n1 % 2 == 0) 
        {
            valoresPares += 1;
        }
        if (n2 % 2 == 0) 
        {
            valoresPares += 1;
        }
        if (n3 % 2 == 0) 
        {
            valoresPares += 1;
        }
        if (n4 % 2 == 0) 
        {
            valoresPares += 1;
        }
        if (n5 % 2 == 0) 
        {
            valoresPares += 1;
        }
        Console.WriteLine(valoresPares + " valores pares");
    }
} 