using System;

public class Program
{
    public static void Main()
    {
        int mes = int.Parse(Console.ReadLine());
        string nomeMes;

        switch (mes)
        {
            case 1:
                nomeMes = "January";
                break;
            case 2:
                nomeMes = "February";
                break;
            case 3:
                nomeMes = "March";
                break;
            case 4:
                nomeMes = "April";
                break;
            case 5:
                nomeMes = "May";
                break;
            case 6:
                nomeMes = "June";
                break;
            case 7:
                nomeMes = "July";
                break;
            case 8:
                nomeMes = "August";
                break;
            case 9:
                nomeMes = "September";
                break;
            case 10:
                nomeMes = "October";
                break;
            case 11:
                nomeMes = "November";
                break;
            case 12:
                nomeMes = "December";
                break;
            default:
                nomeMes = "Mês inválido";
                break;
        }
        Console.WriteLine(nomeMes);
    }
}