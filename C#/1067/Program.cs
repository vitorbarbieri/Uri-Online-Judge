using System;

public class Program
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int valor = 1;

        while (valor <= num)
        {
            Console.WriteLine(valor);
            valor += 2;
        }
    }
}