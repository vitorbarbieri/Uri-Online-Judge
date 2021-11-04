using System;

public class Program
{
    public static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int menor, maior, soma = 0;

        if (x < y)
        {
            menor = x;
            maior = y;
        }
        else
        {
            menor = y;
            maior = x;
        }

        if (menor % 2 == 0)
        {
            menor += 1;
        }
        else
        {
            menor += 2;
        }

        while (menor < maior)
        {
            soma += menor;
            menor += 2;
        }
        Console.WriteLine(soma);
    }
}