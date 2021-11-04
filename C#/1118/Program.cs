using System;

public class Program
{
    public static void Main()
    {
        int continua = 1;

        while (continua != 2)
        {
            if (continua == 1)
            {
                double nota1 = double.Parse(Console.ReadLine());
                while (nota1 < 0 || nota1 > 10)
                {
                    Console.WriteLine("nota invalida");
                    nota1 = double.Parse(Console.ReadLine());
                }
                double nota2 = double.Parse(Console.ReadLine());
                while (nota2 < 0 || nota2 > 10)
                {
                    Console.WriteLine("nota invalida");
                    nota2 = double.Parse(Console.ReadLine());
                }
                double media = (nota1 + nota2) / 2;
                Console.WriteLine("media = " + media.ToString("F2"));
            }
            Console.WriteLine("novo calculo (1-sim 2-nao)");
            continua = int.Parse(Console.ReadLine());
        }
    }
}