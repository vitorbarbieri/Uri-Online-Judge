using System;

public class Program
{
    public static void Main()
    {
        int i = 1;

        for (int j = 60; j >= 0; j -= 5)
        {
            Console.WriteLine("I=" + i + " J=" + j);
            i += 3;
        }
    }
}