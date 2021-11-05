using System;

public class Program
{
    public static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n1; i++)
        {
            Console.WriteLine(i + " " + (Math.Pow(i,2)) + " " + (Math.Pow(i,3)));
        }    
    }
}