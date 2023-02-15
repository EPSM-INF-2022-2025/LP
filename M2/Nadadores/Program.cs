// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Declarar variáveis
int idade;
string escalao = "";

Console.WriteLine("Qual a idade?");
idade = Convert.ToInt32(Console.ReadLine());

if (idade <= 6)
{
    escalao = "Golfinho";
}
else if (idade >= 7 && idade <= 10)
{
    escalao = "Infantil";
}
else if (idade >= 11 && idade <= 13)
{
    escalao = "Juvenil";
}
else if (idade >= 14 && idade <= 17) {
    escalao = "Tubarão";
} else if (idade > 17)
{
    escalao = "Cota";
}

Console.WriteLine("O escalão é " + escalao);