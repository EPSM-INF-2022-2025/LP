// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Declara variáveis
int primeiroNumero;
int segundoNumero;
int soma;

// Escrever na consola
Console.WriteLine("Qual o primeiro numero?");

/* 
 * Ler valor da consola, converter para inteiro
 * e gravar na variável
 */
primeiroNumero = Convert.ToInt32(Console.ReadLine());

//Ler e gravar o segundo numero
Console.WriteLine("Qual o segundo numero?");
segundoNumero = Convert.ToInt32(Console.ReadLine());

// Somar os dois numeros
soma = primeiroNumero + segundoNumero;

// Escrever resultado
Console.WriteLine("O resultado é " + soma);
