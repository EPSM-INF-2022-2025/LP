internal class Program
{
    private static void Main(string[] args)
    {
        int[] idades = new int[5];

        for (int i = 0; i < idades.Length; i++)
        {
            Console.WriteLine("Qual a sua idade?");
            idades[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        int soma = 0;
        decimal media;
        for (int i = 0; i < idades.Length; i++)
        {
            soma = soma + idades[i];
        }

        media = soma / idades.Length;

        Console.WriteLine("Média = " +  media);

    }
}