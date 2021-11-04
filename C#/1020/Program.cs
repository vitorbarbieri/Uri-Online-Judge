using System;

public class Program
{
    public static void Main()
    {
        int total, ano, mes, dia, resto;

        total = int.Parse(Console.ReadLine());

        ano = total / 365;
        resto = total % 365;
        mes = resto / 30;
        dia = resto % 30;

        Console.WriteLine(ano + " ano(s)");
        Console.WriteLine(mes + " mes(es)");
        Console.WriteLine(dia + " dia(s)");
    }
}