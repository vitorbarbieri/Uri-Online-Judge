using System;

public class Program
{
    public static void Main()
    {
        string texto = Console.ReadLine();
        string[] vet = texto.Split(' ');

        int produto = int.Parse(vet[0]);
        int quantidade = int.Parse(vet[1]);
        double total = 0;

        switch (produto)
        {
            case 1:
                total = 4 * quantidade;
                break;
            case 2:
                total = 4.5 * quantidade;
                break;
            case 3:
                total = 5 * quantidade;
                break;
            case 4:
                total = 2 * quantidade;
                break;
            case 5:
                total = 1.5 * quantidade;
                break;
            default:
                break;
        }
        Console.WriteLine("Total: R$ " + total.ToString("F2"));
    }
}