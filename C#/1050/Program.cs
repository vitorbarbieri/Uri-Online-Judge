using System;

public class Program
{
    public static void Main()
    {
        int ddd = int.Parse(Console.ReadLine());
        string destino;

        switch (ddd)
        {
            case 11:
                destino = "Sao Paulo";
                break;
            case 19:
                destino = "Campinas";
                break;
            case 21:
                destino = "Rio de Janeiro";
                break;
            case 27:
                destino = "Vitoria";
                break;
            case 31:
                destino = "Belo Horizonte";
                break;
            case 32:
                destino = "Juiz de Fora";
                break;
            case 61:
                destino = "Brasilia";
                break;
            case 71:
                destino = "Salvador";
                break;
            default:
                destino = "DDD nao cadastrado";
                break;
        }
        Console.WriteLine(destino);
    }
}