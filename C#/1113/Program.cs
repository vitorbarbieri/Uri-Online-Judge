using System;

public class Program
{
    public static void Main()
    {
        string[] valores = Console.ReadLine().Split(' ');
        int x = int.Parse(valores[0]);
        int y = int.Parse(valores[1]);

        while (x != y)
        {
            if (x > y)
            {
                Console.WriteLine("Decrescente");
            }
            else
            {
                Console.WriteLine("Crescente");
            }
            valores = Console.ReadLine().Split(' ');
            x = int.Parse(valores[0]);
            y = int.Parse(valores[1]);
        }
    }
}