using System;

public class Program
{
    public static void Main()
    {
        int cd1, cd2, qt1, qt2;
        double vl1, vl2, total;
        string s1, s2;

        s1 = Console.ReadLine();
        s2 = Console.ReadLine();

        string[] vet1 = s1.Split(' ');
        string[] vet2 = s2.Split(' ');

        cd1 = int.Parse(vet1[0]);
        cd2 = int.Parse(vet2[0]);
        qt1 = int.Parse(vet1[1]);
        qt2 = int.Parse(vet2[1]);
        vl1 = double.Parse(vet1[2]);
        vl2 = double.Parse(vet2[2]);

        total = qt1 * vl1 + qt2 * vl2;

        Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
    }
}