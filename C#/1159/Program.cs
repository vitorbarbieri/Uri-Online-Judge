using System;

public class Program
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine()), total = 0;

        while (num != 0)
        {
            if (num % 2 != 0)
            {
                num += 1;
            }
            total = 0;
            for (int i = 1; i <= 5; i++)
            {
                total += num;
                num = num + 2;
            }
            Console.WriteLine(total);
            num = int.Parse(Console.ReadLine());
        }
    }
}