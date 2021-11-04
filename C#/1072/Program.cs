using System;

public class Program
{
    public static void Main()
    {
        int qtd = int.Parse(Console.ReadLine());
        int valor, dentro = 0, fora = 0;

        for (int i = 1; i <= qtd; i++)
        {
            valor = int.Parse(Console.ReadLine());
            if (valor >= 10 && valor <= 20)
            {
                dentro += 1;
            }
            else
            {
                fora += 1;
            }
        }
        Console.WriteLine(dentro + " in");
        Console.WriteLine(fora + " out");
    }
}