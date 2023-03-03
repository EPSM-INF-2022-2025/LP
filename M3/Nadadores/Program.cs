// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int nrGolfinhos = 0;
int nrInfantis = 0;
int nrJuvenis = 0;
int nrTubaroes = 0;
int nrCotas = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Qual a idade do nadador?");
    int idade = Convert.ToInt32(Console.ReadLine());

    if (idade <= 6)
    {
        nrGolfinhos = nrGolfinhos + 1;
    } else if (idade >= 7 && idade <=10) 
    { 
        nrInfantis = nrInfantis + 1;
    } else if (idade >= 11 && idade <= 13)
    {
        nrJuvenis = nrJuvenis + 1;
    } else if (idade >= 14 && idade <= 17)
    {
        nrTubaroes = nrTubaroes + 1;
    } else if (idade > 18)
    {
        nrCotas = nrCotas + 1;
    }
}

Console.WriteLine("Golfinhos: " + nrGolfinhos);
Console.WriteLine("Infantis: " + nrInfantis);
Console.WriteLine("Juvenil: " + nrJuvenis);
Console.WriteLine("Tubarão: " + nrTubaroes);
Console.WriteLine("Cota: " + nrCotas);
