/*
Faça um programa em C# que solicite ao usuário uma senha. 
O programa deve verificar se a senha digitada pelo usuário é 
igual a uma senha pré-definida ("123456") e exibir uma mensagem
adequada para cada caso. Se a senha digitada pelo usuário for 
correta, exiba a mensagem "Acesso permitido". Caso contrário, 
exiba a mensagem "Acesso negado". 
 */

Console.WriteLine("Qual a senha?");
String senha = Console.ReadLine();

if (senha == "123456")
{
    Console.WriteLine("Acesso permitido");
} else
{
    Console.WriteLine("Acesso negado");
}