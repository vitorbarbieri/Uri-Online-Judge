using System;

public class Program
{
    public static void Main()
    {
        int numero, horas;
        double valor, salario;

        numero = int.Parse(Console.ReadLine());
        horas = int.Parse(Console.ReadLine());
        valor = double.Parse(Console.ReadLine());

        salario = horas * valor;

        Console.WriteLine("NUMBER = " + numero);
        Console.WriteLine("SALARY = U$ " + salario.ToString("F2"));
    }
}