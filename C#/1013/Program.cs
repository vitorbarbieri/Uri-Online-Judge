using System;

public class Program
{
    public static void Main()
    {
        string str;
        int a, b, c, maiorAB, maiorABC;

        str = Console.ReadLine();
        string[] vet = str.Split(' ');

        a = int.Parse(vet[0]);
        b = int.Parse(vet[1]);
        c = int.Parse(vet[2]);

        maiorAB = (a + b + Math.Abs(a - b)) / 2;
        maiorABC = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

        Console.WriteLine(maiorABC + " eh o maior");    
    }
}