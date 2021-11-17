using System;

public class Program
{
    public static void Main()
    {
        int num;
        do
        {
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (i == num)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        } while (num != 0);
    }
}