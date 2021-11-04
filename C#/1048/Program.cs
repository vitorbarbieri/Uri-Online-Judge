using System;

public class Program
{
    public static void Main()
    {
            double salario = double.Parse(Console.ReadLine());
            double novoSalario, reajuste;
            int percentual;

            if (salario <= 400) 
            {
                novoSalario = salario * 1.15;
                reajuste = novoSalario - salario;
                percentual = 15;
            }
            else
            {
                if (salario <= 800)
                {
                    novoSalario = salario * 1.12;
                    reajuste = novoSalario - salario;
                    percentual = 12;
                }
                else
                {
                    if (salario <= 1200)
                    {
                        novoSalario = salario * 1.10;
                        reajuste = novoSalario - salario;
                        percentual = 10;
                    }
                    else
                    {
                        if (salario <= 2000)
                        {
                            novoSalario = salario * 1.07;
                            reajuste = novoSalario - salario;
                            percentual = 7;
                        }
                        else
                        {
                            novoSalario = salario * 1.04;
                            reajuste = novoSalario - salario;
                            percentual = 4;
                        }
                    }
                }
            }
            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2"));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2"));
            Console.WriteLine("Em percentual: " + percentual + " %");       
    }
}