using System;

public class Program
{
    public static void Main()
    {
        int quantidade = int.Parse(Console.ReadLine());

        for (int i = 1; i <= quantidade; i++)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int n1 = int.Parse(valores[0]);
            int n2 = int.Parse(valores[1]);
            int menor, maior, soma = 0;

            if (n1 < n2)
            {
                menor = n1;
                maior = n2;
            }
            else
            {
                menor = n2;
                maior = n1;
            }

            for (int j = menor + 1; j < maior; j++)
            {
                if (j % 2 != 0)
                {
                    soma += j;
                }
            }
            Console.WriteLine(soma);
        }
    }
}