using System;

public class Program
{
    public static void Main()
    {
        int qtd = int.Parse(Console.ReadLine());

        for (int i = 0; i < qtd; i++)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int n1 = int.Parse(valores[0]);
            int n2 = int.Parse(valores[1]);
            if (n2 == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else
            {
                double divisao = (double)n1 / n2;
                Console.WriteLine(divisao.ToString("F1"));
            }
        }
    }
}