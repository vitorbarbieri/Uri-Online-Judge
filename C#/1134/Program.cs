using System;

public class Program
{
    public static void Main()
    {
        int combustivel = int.Parse(Console.ReadLine()), somaA = 0, somaG = 0, somaD = 0;

        while (combustivel != 4)
        {
            switch (combustivel)
            {
                case 1:
                    somaA += 1;
                    break;
                case 2:
                    somaG += 1;
                    break;
                case 3:
                    somaD += 1;
                    break;
            }
            combustivel = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: " + somaA);
        Console.WriteLine("Gasolina: " + somaG);
        Console.WriteLine("Diesel: " + somaD);
    }
}