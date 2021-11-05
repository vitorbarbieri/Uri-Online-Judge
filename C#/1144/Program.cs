using System;

public class Program
{
    public static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n1; i++)
        {
            int n2 = i * i;
            int n3 = i * i * i;
            Console.WriteLine(i + " " + n2 + " " + n3);
            Console.WriteLine(i + " " + (n2 + 1) + " " + (n3 + 1));
        }
    }
}