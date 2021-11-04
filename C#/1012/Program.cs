using System;

public class Program
{
    public static void Main()
    {
        double a, b, c, aTri, aCir, aTra, aQua, aRet;
        string texto;

        texto = Console.ReadLine();
        string[] vet = texto.Split(' ');

        a = double.Parse(vet[0]);
        b = double.Parse(vet[1]);
        c = double.Parse(vet[2]);

        aTri = (a * c) / 2.0;
        aCir = 3.14159 * Math.Pow(c, 2);
        aTra = ((a + b) * c) / 2.0;
        aQua = Math.Pow(b, 2);
        aRet = a * b;

        Console.WriteLine("TRIANGULO: " + aTri.ToString("F3"));
        Console.WriteLine("CIRCULO: " + aCir.ToString("F3"));
        Console.WriteLine("TRAPEZIO: " + aTra.ToString("F3"));
        Console.WriteLine("QUADRADO: " + aQua.ToString("F3"));
        Console.WriteLine("RETANGULO: " + aRet.ToString("F3"));
    }
}