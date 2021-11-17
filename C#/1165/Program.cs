using System;

public class Program
{
    public static void Main()
    {
        int linhas = int.Parse(Console.ReadLine());

        if (linhas >= 0 && linhas <= 100)
        {
            for (int i = 0; i < linhas; i++)
            {
                char resp = 's';
                int num = int.Parse(Console.ReadLine());
                if (num > 1 && num <= 10000000)
                {
                    for (int j = 2; j < num; j++)
                    {
                        if (num % j == 0)
                        {
                            resp = 'n';
                        }
                    }
                }
                if (resp == 'n')
                {
                    System.Console.WriteLine(num + " nao eh primo");
                }
                else
                {
                    System.Console.WriteLine(num + " eh primo");
                }
            }
        }
    }
}