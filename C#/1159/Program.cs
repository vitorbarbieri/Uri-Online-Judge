using System;

public class Program
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        while (num != 0)
        {
            if (num % 2 != 0)
            {
                num += 1;
            }
            int total = num + (num + 2) + (num + 4) + (num + 6) + (num + 8);
            Console.WriteLine(total);
            num = int.Parse(Console.ReadLine());
        }
    }
}