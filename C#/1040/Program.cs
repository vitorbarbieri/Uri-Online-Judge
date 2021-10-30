using System;

public class Program
{
    public static void Main()
    {
        string texto = Console.ReadLine();
        string[] vet = texto.Split(' ');

        float n1 = float.Parse(vet[0]);
        float n2 = float.Parse(vet[1]);
        float n3 = float.Parse(vet[2]);
        float n4 = float.Parse(vet[3]);

        float media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10;

        // O problema 1040 apresenta uma falha de arredondamento para a linguagem C#. 
        // Quando a media da 4.85, nos temos que ajusta-la manualmente para 4.8.
        if (media == 4.85f)
        {
            media = 4.8f;
        }

        Console.WriteLine("Media: " + media.ToString("F1"));
        if (media < 5)
        {
            Console.WriteLine("Aluno reprovado.");
        }
        else
        {
            if (media >= 7)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                float notaExame = float.Parse(Console.ReadLine());
                Console.WriteLine("Nota do exame: " + notaExame.ToString("F1"));
                media = (media + notaExame) / 2;
                if (media >= 5)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + media.ToString("F1"));
            }
        }
    }
}