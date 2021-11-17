using System;

public class Program
{
    public static void Main()
    {
        string[] valores = Console.ReadLine().Split(' ');
        int n1 = int.Parse(valores[0]);
        int n2 = int.Parse(valores[1]);
        int n = 1;

        for (int i = 1; i <= n2; i++)
        {
            if (i % n1 == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.Write(i + " ");
            }
        }
    }
}