using System;

public class Program
{
    public static void Main()
    {
        string[] valores = Console.ReadLine().Split(' ');
        int n1 = int.Parse(valores[0]);
        int n2 = int.Parse(valores[1]);
        int n3 = int.Parse(valores[2]);
        int a, b, c;

        if (n1 < n2 && n1 < n3)
        {
            a = n1;
            if (n2 < n3)
            {
                b = n2;
                c = n3;
            }
            else
            {
                b = n3;
                c = n2;
            }
        }
        else
        {
            if (n2 < n3)
            {
                a = n2;
                if (n1 < n3)
                {
                    b = n1;
                    c = n3;
                }
                else
                {
                    b = n3;
                    c = n1;
                }
            }
            else
            {
                a = n3;
                if (n1 < n2)
                {
                    b = n1;
                    c = n2;
                }
                else
                {
                    b = n2;
                    c = n1;
                }
            }
        }
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine();
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(n3);
    }
}