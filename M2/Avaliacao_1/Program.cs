// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
 Escreva um programa que solicite ao usuário um 
número inteiro e exiba uma mensagem informando se o 
número é positivo, negativo ou zero.
 */

// Declarar variaveis
int numero;

// Perguntar ao utilizador
Console.WriteLine("Qual o numero?");

// Ler e converter valor do utilizador
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0) {
    Console.WriteLine("O numero é positivo");
} else if (numero < 0)
{
    Console.WriteLine("O numero é negativo");
} else if (numero == 0)
{
    Console.WriteLine("O numero é zero");
}