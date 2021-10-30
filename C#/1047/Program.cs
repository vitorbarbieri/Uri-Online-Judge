using System;
					
public class Program
{
	public static void Main()
	{
            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int minutoInicial = int.Parse(valores[1]);
            int horaFinal = int.Parse(valores[2]);
            int minutoFinal = int.Parse(valores[3]);

            int tempoInicial = horaInicial * 60 + minutoInicial;
            int tempoFinal = horaFinal * 60 + minutoFinal;

            int duracao;
            if (tempoInicial < tempoFinal)
            {
                duracao = tempoFinal - tempoInicial;
            }
            else
            {
                duracao = (24 * 60 - tempoInicial) + tempoFinal;
            }

            int duracaoHoras = duracao / 60;
            int duracaoMinutos = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");
	}
}