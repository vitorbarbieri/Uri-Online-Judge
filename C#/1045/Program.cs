using System;

public class Program
{
    public static void Main()
    {
        string[] valores = Console.ReadLine().Split(' ');
        double n1 = double.Parse(vetor[0]);
        double n2 = double.Parse(vetor[1]);
        double n3 = double.Parse(vetor[2]);
        double a, b, c;

        // Ordena os números informado em ordem decrescente.
        if (n1 > n2 && n1 > n3)
        {
            a = n1;
            if (n2 > n3)
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
            if (n2 > n3)
            {
                a = n2;
                if (n1 > n3)
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
                if (n1 > n2)
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

        // Determina os tipos de triângulo.
        if (a >= b + c)
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else
        {
            if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (Math.Pow(a, 2) > Math.Pow(b, 2) + Math.Pow(c, 2))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if (Math.Pow(a, 2) < Math.Pow(b, 2) + Math.Pow(c, 2))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }

            if (a == b && b == c)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}