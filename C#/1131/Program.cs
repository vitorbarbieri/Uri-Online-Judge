using System;

public class Program
{
    public static void Main()
    {
        int continua = 1, qtd = 0, vI = 0, vG = 0, empate = 0;

        while (continua != 2)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int valor1 = int.Parse(valores[0]);
            int valor2 = int.Parse(valores[1]);
            qtd += 1;
            if (valor1 > valor2)
            {
                vI += 1;
            }
            else if (valor2 > valor1)
            {
                vG += 1;
            }
            else
            {
                empate += 1;
            }
            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            continua = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(qtd + " grenais");
        Console.WriteLine("Inter:" + vI);
        Console.WriteLine("Gremio:" + vG);
        Console.WriteLine("Empates:" + empate);
        if (vI > vG)
        {
            Console.WriteLine("Inter venceu mais");
        }
        else if (vG > vI)
        {
            Console.WriteLine("Gremio venceu mais");
        }
        else
        {
            Console.WriteLine("Nao houve vencedor");
        }
    }
}