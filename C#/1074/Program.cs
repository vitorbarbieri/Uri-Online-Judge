using System;

public class Program
{
    public static void Main()
    {
        int qtd = int.Parse(Console.ReadLine());

        for (int i = 1; i <= qtd; i++)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("NULL");
            }
            else
            {
                if (n % 2 == 0)
                {
                    Console.Write("EVEN ");
                }
                else
                {
                    Console.Write("ODD ");
                }

                if (n < 0)
                {
                    Console.WriteLine("NEGATIVE");
                }
                else
                {
                    Console.WriteLine("POSITIVE");
                }
            }
        }
    }
}