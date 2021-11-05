using System;

public class Program
{
    public static void Main()
    {
            int n = int.Parse(Console.ReadLine()), valor = 1;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(valor + " " + (valor + 1) + " " + (valor + 2) + " PUM");
                valor += 4;
            }       
    }
}