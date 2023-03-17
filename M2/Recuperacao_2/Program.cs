/*
Faça um programa em C# que solicite ao usuário o seu salário 
e o salário mínimo atual. O programa deve verificar se o 
salário informado pelo usuário é maior ou menor do que cinco 
salários mínimos e exibir uma mensagem adequada para cada caso.
Se o salário informado pelo usuário for maior do que cinco 
salários mínimos, exiba a mensagem "Seu salário é maior do que 
cinco salários mínimos". Caso contrário, exiba a mensagem "Seu 
salário é igual ou menor do que cinco salários mínimos".
 */

Console.WriteLine("Qual o seu salário?");
double salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Qual o salário minino?");
double salarioMinimo = Convert.ToDouble(Console.ReadLine());

double cincoSalariosMinimos = salarioMinimo * 5;

if (salario > cincoSalariosMinimos)
{
    Console.WriteLine("Seu salário é maior do que cinco salários mínimos");
} else
{
    Console.WriteLine("Seu salário é igual ou menor do que cinco salários mínimos");
}