using System;

public class Program
{
    public static void Main()
    {
        int maior = 0, posicao = 0;

        for (int i = 1; i <= 100; i++)
        {
            int valor = int.Parse(Console.ReadLine());
            if (valor > maior)
            {
                maior = valor;
                posicao = i;
            }
        }
        Console.WriteLine(maior);
        Console.WriteLine(posicao);
    }
}