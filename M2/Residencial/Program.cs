using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int numero, soma, paga;
        double dia, total;
        string nome;

        Console.WriteLine("Qual é seu nome?");
        nome = Console.ReadLine();
        paga = 0;
        Console.WriteLine("Quantos dia vai ficar?");
        dia = inputValue();
        if (dia == 10)
        {
            paga = 50 * 6;
        }
        else
        {
            if (dia < 10)
            {
                paga = 50 * 7;
            }
            else
            {
                if (dia > 10)
                {
                    paga = 50 * 5;
                }
            }
        }
        Console.WriteLine(nome + "Você têm que pagar " + paga);
    }

    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}