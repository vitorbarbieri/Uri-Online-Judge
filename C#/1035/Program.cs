using System;

public class Program
{
    public static void Main()
    {
        string texto = Console.ReadLine();
        string[] vet = texto.Split(' ');

        int a = int.Parse(vet[0]);
        int b = int.Parse(vet[1]);
        int c = int.Parse(vet[2]);
        int d = int.Parse(vet[3]);

        if (b > c && d > a && c + d > a + b && c > 0 && d > 0 && a % 2 == 0)
        {
            Console.WriteLine("Valores aceitos");
        }
        else
        {
            Console.WriteLine("Valores nao aceitos");
        }
    }
}