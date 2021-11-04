using System;

public class Program
{
    public static void Main()
    {
        string[] dataInicial = Console.ReadLine().Split(' ');
        int diaInicial = int.Parse(dataInicial[1]);
        string[] tempoInicial = Console.ReadLine().Split(':');
        int horaInicial = int.Parse(tempoInicial[0]);
        int minutoInicial = int.Parse(tempoInicial[1]);
        int segundoInicial = int.Parse(tempoInicial[2]);

        string[] DataFinal = Console.ReadLine().Split(' ');
        int diaFinal = int.Parse(DataFinal[1]);
        string[] tempoFinal = Console.ReadLine().Split(':');
        int horaFinal = int.Parse(tempoFinal[0]);
        int minutoFinal = int.Parse(tempoFinal[1]);
        int segundoFinal = int.Parse(tempoFinal[2]);

        int duracaoInicial = (diaInicial - 1) * 24 * 60 * 60 + horaInicial * 60 * 60 + minutoInicial * 60 + segundoInicial;
        int duracaoFinal = (diaFinal - 1) * 24 * 60 * 60 + horaFinal * 60 * 60 + minutoFinal * 60 + segundoFinal;
        int duracaoDiferenca = duracaoFinal - duracaoInicial;

        int totalDias = duracaoDiferenca / (24 * 60 * 60);
        int resto = duracaoDiferenca % (24 * 60 * 60);
        int totalHoras = resto / (60 * 60);
        resto = duracaoDiferenca % (60 * 60);
        int totalMinutos = resto / 60;
        int totalSegundos = resto % 60;

        Console.WriteLine(totalDias + " dia(s)");
        Console.WriteLine(totalHoras + " hora(s)");
        Console.WriteLine(totalMinutos + " minuto(s)");
        Console.WriteLine(totalSegundos + " segundo(s)");
    }
}