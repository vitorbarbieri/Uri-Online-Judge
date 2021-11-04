using System;

public class Program
{
    public static void Main()
    {
        string nome;
        double salario, venda, total;

        nome = Console.ReadLine();
        salario = double.Parse(Console.ReadLine());
        venda = double.Parse(Console.ReadLine());

        total = salario + venda * 0.15;

        Console.WriteLine("TOTAL = R$ " + total.ToString("F2"));
    }
}