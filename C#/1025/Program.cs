using System;

public class Program
{
    public static void Main()
    {
        int total, n100, n50, n20, n10, n5, n2, n1, resto;

        total = int.Parse(Console.ReadLine());

        n100 = total / 100;
        resto = total % 100;
        n50 = resto / 50;
        resto = resto % 50;
        n20 = resto / 20;
        resto = resto % 20;
        n10 = resto / 10;
        resto = resto % 10;
        n5 = resto / 5;
        resto = resto % 5;
        n2 = resto / 2;
        n1 = resto % 2;

        Console.WriteLine(total);
        Console.WriteLine(n100 + " nota(s) de R$ 100,00");
        Console.WriteLine(n50 + " nota(s) de R$ 50,00");
        Console.WriteLine(n20 + " nota(s) de R$ 20,00");
        Console.WriteLine(n10 + " nota(s) de R$ 10,00");
        Console.WriteLine(n5 + " nota(s) de R$ 5,00");
        Console.WriteLine(n2 + " nota(s) de R$ 2,00");
        Console.WriteLine(n1 + " nota(s) de R$ 1,00");
    }
}