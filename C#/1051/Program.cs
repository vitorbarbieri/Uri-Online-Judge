using System;

public class Program
{
    public static void Main()
    {
        double salario = double.Parse(Console.ReadLine());
        double imposto;

        if (salario >= 0 && salario <= 2000)
        {
            Console.WriteLine("Isento");
        }
        else if (salario <= 3000)
        {
            imposto = (salario - 2000) * 0.08;
            Console.WriteLine("R$ " + imposto.ToString("F2"));
        }
        else if (salario <= 4500)
        {
            imposto = 1000 * 0.08 + (salario - 3000) * 0.18;
            Console.WriteLine("R$ " + imposto.ToString("F2"));
        }
        else
        {
            imposto = 1000 * 0.08 + 1500 * 0.18 + (salario - 4500) * 0.28;
            Console.WriteLine("R$ " + imposto.ToString("F2"));
        }
    }
}