using System;

public class Program
{
    public static void Main()
    {
        string texto = Console.ReadLine();
        string[] vet = texto.Split(' ');

        int n1 = int.Parse(vet[0]);
        int n2 = int.Parse(vet[1]);
        int divisao;

        if (n1 < n2)
        {
            divisao = n2 % n1;
        }
        else
        {
            divisao = n1 % n2;
        }

        if (divisao == 0)
        {
            Console.WriteLine("Sao Multiplos");
        }
        else
        {
            Console.WriteLine("Nao sao Multiplos");
        }
    }
}