using System;

public class Program
{
    public static void Main()
    {
        double nota = double.Parse(Console.ReadLine()), media = 0, total = 0;
        int qtd = 0;

        while (qtd < 2)
        {
            if (nota < 0 || nota > 10)
            {
                Console.WriteLine("nota invalida");
            }
            else
            {
                qtd += 1;
                total += nota;
            }
            if (qtd < 2)
            {
                nota = double.Parse(Console.ReadLine());
            }
        }
        media = (double)total / qtd;
        Console.WriteLine("media = " + media.ToString("F2"));
    }
}