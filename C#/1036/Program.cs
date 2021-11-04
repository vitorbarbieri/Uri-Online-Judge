using System;

public class Program
{
    public static void Main()
    {
        string texto;
        string[] vet;
        double a, b, c, delta, r1, r2;

        texto = Console.ReadLine();
        vet = texto.Split(' ');

        a = double.Parse(vet[0]);
        b = double.Parse(vet[1]);
        c = double.Parse(vet[2]);

        delta = Math.Pow(b, 2) - (4 * a * c);
        r1 = (-b + Math.Sqrt(delta)) / (2 * a);
        r2 = (-b - Math.Sqrt(delta)) / (2 * a);

        if (a == 0 || delta < 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
            Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}