// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Desenvolva um programa que pergunta ao utilizador o
//tempo da corrida de dois atletas (horas, minutos e
//segundos) e no final indique qual dos atletas venceu.

// Declara variaveis
int h1,m1,s1,h2,m2,s2;
int tempo1, tempo2;

Console.WriteLine("Quantas horas? (Atleta 1)");
h1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Quantos minutos? (Atleta 1)");
m1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Quantos segundos? (Atleta 1)");
s1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Quantas horas? (Atleta 2)");
h2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Quantos minutos? (Atleta 2)");
m2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Quantos segundos? (Atleta 2)");
s2 = Convert.ToInt32(Console.ReadLine());

tempo1 = s1 + (m1 * 60) + (h1 * 60 * 60);
tempo2 = s2 + (m2 * 60) + (h2 * 60 * 60);

if (tempo1 < tempo2)
{
    Console.WriteLine("Ganhou o ATLETA 1");
} else if (tempo2 < tempo1)
{
    Console.WriteLine("Ganhou o ATLETA 2");
} else
{
    Console.WriteLine("EMPATE");
}


