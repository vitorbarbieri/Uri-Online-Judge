using System;

public class Program
{
    public static void Main()
    {
        int m, n;

        do
        {
            string[] valores = Console.ReadLine().Split(' ');
            m = int.Parse(valores[0]);
            n = int.Parse(valores[1]);
            if (m > 0 && n > 0)
            {
                int menor, maior, soma = 0;

                if (m < n)
                {
                    menor = m;
                    maior = n;
                }
                else
                {
                    menor = n;
                    maior = m;
                }

                for (int i = menor; i <= maior; i++)
                {
                    soma += i;
                    if (i != maior)
                    {
                        Console.Write(i + " ");
                    }
                    else
                    {
                        Console.WriteLine(i + " Sum=" + soma);
                    }
                }
            }
        } while (m > 0 && n > 0);
    }
}