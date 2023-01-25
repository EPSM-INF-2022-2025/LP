// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


// Declarar variáveis
int num1,num2;
double media;

// FAZER ... ATÉ
do
{
    // Perguntar o numero
    Console.WriteLine("Qual o número 1?");
    // Ler e converter o valor
    num1 = Convert.ToInt32(Console.ReadLine());
} while (num1 <= 0);

do
{
    // Perguntar o numero
    Console.WriteLine("Qual o número 2?");
    // Ler e converter o valor
    num2 = Convert.ToInt32(Console.ReadLine());
} while (num2 <= 0);

// Calcular a média
media = (num1 + num2) / 2;

// Escrever a média
Console.WriteLine("A média é " + media);