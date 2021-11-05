using System;

public class Program
{
    public static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int menor, maior, soma = 0;

        if (n1 < n2)
        {
            menor = n1;
            maior = n2;
        }
        else
        {
            menor = n2;
            maior = n1;
        }

        for (int i = menor; i <= maior; i++)
        {
            if (i % 13 != 0)
            {
                soma += i;
            }
        }
        Console.WriteLine(soma);
    }
}