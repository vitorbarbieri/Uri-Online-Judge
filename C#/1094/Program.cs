using System;

public class Program
{
    public static void Main()
    {
        int qtdTestes = int.Parse(Console.ReadLine());
        int qtdR = 0, qtdS = 0, qtdC = 0, qtdCobais = 0;

        for (int i = 1; i <= qtdTestes; i++)
        {
            string[] caso = Console.ReadLine().Split(' ');
            int qtd = int.Parse(caso[0]);
            string tipo = caso[1];

            if (qtd >= 1 && qtd <= 15)
            {
                switch (tipo)
                {
                    case "R":
                        qtdR += qtd;
                        break;
                    case "S":
                        qtdS += qtd;
                        break;
                    case "C":
                        qtdC += qtd;
                        break;
                    default:
                        Console.WriteLine("Tipo inválido");
                        break;
                }
                qtdCobais += qtd;
            }
        }
        double percentualC = (double)qtdC / qtdCobais;
        double percentualR = (double)qtdR / qtdCobais;
        double percentualS = (double)qtdS / qtdCobais;
        Console.WriteLine("Total: " + qtdCobais + " cobaias");
        Console.WriteLine("Total de coelhos: " + qtdC);
        Console.WriteLine("Total de ratos: " + qtdR);
        Console.WriteLine("Total de sapos: " + qtdS);
        Console.WriteLine("Percentual de coelhos: " + (percentualC * 100).ToString("F2") + " %");
        Console.WriteLine("Percentual de ratos: " + (percentualR * 100).ToString("F2") + " %");
        Console.WriteLine("Percentual de sapos: " + (percentualS * 100).ToString("F2") + " %");
    }
}