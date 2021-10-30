using System;

public class Program
{
    public static void Main()
    {
        string[] valores = Console.ReadLine().Split(' ');
        double a = double.Parse(valores[0]);
        double b = double.Parse(valores[1]);
        double c = double.Parse(valores[2]);

        if (a < b + c && b < a + c && c < a + b) // Verifica se é triângulo.
        {
            double perimetro = a + b + c;
            Console.WriteLine("Perimetro = " + perimetro.ToString("F1"));
        }
        else
        {
            double area = ((a + b) * c) / 2;
            Console.WriteLine("Area = " + area.ToString("F1"));   
        }     
    }
}