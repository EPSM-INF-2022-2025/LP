int sequencia;
int numero1 = 0;
int numero2 = 1;



Console.WriteLine("Quantas sequencias queres fazer?");
sequencia = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(numero1);
Console.WriteLine(numero2);

for (int i = 0; i < sequencia - 2; i++)
{

    int temp = numero2;
    numero2 = numero1 + numero2;
    numero1 = temp;
    Console.WriteLine(numero2);
}
