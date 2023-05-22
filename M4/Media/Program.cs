MostrarMenu();

static void MostrarMenu()
{
    bool continuar = true;
    List<int> numeros = new List<int>();

    while (continuar)
    {
        Console.WriteLine("1 - Ler Numeros");
        Console.WriteLine("2 - Calcular Média");
        Console.WriteLine("3 - Encontrar o MAIOR");
        Console.WriteLine("0 - Sair");

        int opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                numeros = LerNumeros();
                break;
            case 2:
                if (numeros.Count() > 0)
                {
                    decimal media = CalcularMedia(numeros);
                    Console.WriteLine("Média = " + media);
                }
                else {
                    Console.WriteLine("Média = " + media);
                }
                
                break;
            case 3:
                int maior = EncontrarMaior(numeros);
                Console.WriteLine("Maior = " + maior);
                break;
            case 0:
                continuar = false;
                break;
            default:
                break;
        }

    }
}

static List<int> LerNumeros() {

    bool continuarLerNumeros = true;
    List<int> listaDeNumeros = new List<int>();

    while (continuarLerNumeros)
    {
        Console.WriteLine("Qual o numero? 0 - Sair");
        int numero = Convert.ToInt32(Console.ReadLine());
    
        if (numero == 0)
        {
            continuarLerNumeros = false;
        }
        else
        {
            listaDeNumeros.Add(numero);
        }
    }

    return listaDeNumeros;

}

static decimal CalcularMedia(List<int> numeros)
{
    decimal media = 0;
    int soma = 0;

    foreach (var numero in numeros)
    {
        soma = soma + numero;
    }

    media = soma / numeros.Count();

    return media;
}

static int EncontrarMaior(List<int> numeros)
{
    int maior = 0;

    foreach (var num in numeros)
    {
        if (num > maior) { 
            maior = num;
        }
    }

    return maior;
}