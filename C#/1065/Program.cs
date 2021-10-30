using System;

public class Program
{
    public static void Main()
    {
        int pares = 0;
        int impares = 0;
        int positivos = 0;
        int negativos = 0;


        int numero = int.Parse(Console.ReadLine());
        if (numero > 0)
        {
            positivos += 1;
        }
        else if (numero < 0)
        {
            negativos += 1;
        }
        if (numero % 2 == 0)
        {
            pares += 1;
        }
        else
        {
            impares += 1;
        }

        numero = int.Parse(Console.ReadLine());
        if (numero > 0)
        {
            positivos += 1;
        }
        else if (numero < 0)
        {
            negativos += 1;
        }
        if (numero % 2 == 0)
        {
            pares += 1;
        }
        else
        {
            impares += 1;
        }
        
        numero = int.Parse(Console.ReadLine());
        if (numero > 0)
        {
            positivos += 1;
        }
        else if (numero < 0)
        {
            negativos += 1;
        }
        if (numero % 2 == 0)
        {
            pares += 1;
        }
        else
        {
            impares += 1;
        }
        
        numero = int.Parse(Console.ReadLine());
        if (numero > 0)
        {
            positivos += 1;
        }
        else if (numero < 0)
        {
            negativos += 1;
        }
        if (numero % 2 == 0)
        {
            pares += 1;
        }
        else
        {
            impares += 1;
        }
        
        numero = int.Parse(Console.ReadLine());
        if (numero > 0)
        {
            positivos += 1;
        }
        else if (numero < 0)
        {
            negativos += 1;
        }
        if (numero % 2 == 0)
        {
            pares += 1;
        }
        else
        {
            impares += 1;
        }

        Console.WriteLine(pares + " valor(es) par(es)");
        Console.WriteLine(impares + " valor(es) impar(es)");
        Console.WriteLine(positivos + " valor(es) positivo(s)");
        Console.WriteLine(negativos + " valor(es) negativo(s)");
    }
}