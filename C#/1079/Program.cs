using System;

public class Program
{
    public static void Main()
    {
        int qtd = int.Parse(Console.ReadLine());

        for (int i = 1; i <= qtd; i++)
        {
            string[] notas = Console.ReadLine().Split(' ');
            double n1 = double.Parse(notas[0]);
            double n2 = double.Parse(notas[1]);
            double n3 = double.Parse(notas[2]);
            double media = (n1 * 2 + n2 * 3 + n3 * 5) / 10;
            Console.WriteLine(media.ToString("F1"));
        }
    }
}