using System;

public class Program
{
    public static void Main()
    {
        int valor = int.Parse(Console.ReadLine());
        int numero;

        if (valor % 2 == 0)
        {
            valor += 1;
        }

        for (int i = 1; i <= 6; i++)
        {
            Console.WriteLine(valor);
            valor += 2;
        }
    }
}