using System;

public class Program
{
    public static void Main()
    {
        int A, B, PROD;

        A = int.Parse(Console.ReadLine());
        B = int.Parse(Console.ReadLine());

        PROD = A * B;

        Console.WriteLine("PROD = " + PROD);
    }
}