using System;

public class Program
{
    public static void Main()
    {
        string palavra1 = Console.ReadLine();
        string palavra2 = Console.ReadLine();
        string palavra3 = Console.ReadLine();

        if (palavra1 == "vertebrado")
        {
            if (palavra2 == "ave")
            {
                if (palavra3 == "carnivoro")
                {
                    System.Console.WriteLine("aguia");
                }
                else
                {
                    System.Console.WriteLine("pomba");
                }
            }
            else
            {
                if (palavra3 == "onivoro")
                {
                    System.Console.WriteLine("homem");
                }
                else
                {
                    System.Console.WriteLine("vaca");
                }
            }
        }
        else{
            if (palavra2 == "inseto")
            {
                if (palavra3 == "hematofago")
                {
                    System.Console.WriteLine("pulga");
                }
                else
                {
                    System.Console.WriteLine("lagarta");
                }
            }
            else
            {
                if (palavra3 == "hematofago")
                {
                    System.Console.WriteLine("sanguessuga");
                }
                else
                {
                    System.Console.WriteLine("minhoca");
                }
            }
        }
    }
}