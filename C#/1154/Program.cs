using System;

public class Program
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine()), qtd = 0, total = 0;
        double media = 0;

        while (num >= 0)
        {
            qtd += 1;
            total += num;
            num = int.Parse(Console.ReadLine());
        }
        media = (double)total / qtd;
        Console.WriteLine(media.ToString("F2"));
    }
}