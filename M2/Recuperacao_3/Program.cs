/*
 
Faça um programa em C# que solicite ao usuário sua idade. 
O programa deve verificar se o usuário é maior de idade ou 
não e exibir uma mensagem adequada para cada caso. Se o 
usuário tiver 18 anos ou mais, exiba a mensagem "Você é maior 
de idade". Caso contrário, exiba a mensagem "Você é menor de 
idade".  Além disso, caso o usuário digite uma idade inválida 
(menor do que zero ou maior do que 120), exiba uma mensagem de 
erro.
 
 */
int idade;

Console.WriteLine("Quantos anos tem?");
idade = Convert.ToInt32(Console.ReadLine());

if (idade < 0 || idade > 120)
{
    Console.WriteLine("idade invalida");
}
else if (idade >= 18)
{
    Console.WriteLine("é maior de idade");
}
else 
{
    Console.WriteLine("menor de idade");  
}
