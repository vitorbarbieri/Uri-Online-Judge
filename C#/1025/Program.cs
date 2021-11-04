using System;

public class Program
{
    public static void Main()
    {
        double total = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double[] valor = { 100, 50, 20, 10, 5, 2, 1, 0.5, 0.25, 0.1, 0.05, 0.01 };
        int quantidade;

        Console.WriteLine("NOTAS:");
        for (int i = 0; i < 6; i++)
        {
            quantidade = (int)(total / valor[i]);
            Console.WriteLine(quantidade + " nota(s) de R$ " + valor[i].ToString("F2", CultureInfo.InvariantCulture));
            total -= quantidade * valor[i];
            total = Math.Round(total, 2);
        }
        Console.WriteLine("MOEDAS:");
        for (int i = 6; i < valor.Length; i++)
        {
            quantidade = (int)(total / valor[i]);
            Console.WriteLine(quantidade + " moeda(s) de R$ " + valor[i].ToString("F2", CultureInfo.InvariantCulture));
            total -= quantidade * valor[i];
            total = Math.Round(total, 2);
        }
    }
}