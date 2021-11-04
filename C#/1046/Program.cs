using System;

public class Program
{
    public static void Main()
    {
        string texto = Console.ReadLine();
        string[] vet = texto.Split(' ');

        int a = int.Parse(vet[0]);
        int b = int.Parse(vet[1]);
        int duracao;

        if (a == b)
        {
            duracao = 24;
        }
        else
        {
            if (a < b)
            {
                duracao = b - a;
            }
            else
            {
                duracao = 24 - (a - b);
            }
        }
        Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
    }
}