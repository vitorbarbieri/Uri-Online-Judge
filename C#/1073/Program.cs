using System;

public class Program
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        if (num >= 5 && num <= 2000)
        {
            for (int i = 2; i <= num; i += 2)
            {
                Console.WriteLine(i + "^2 = " + Math.Pow(i, 2));
            }
        }
    }
}