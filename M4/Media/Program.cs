MostrarMenu();

static void MostrarMenu()
{
    bool continuar = true;
    List<int> numeros = new List<int>();

    while (continuar)
    {
        Console.WriteLine("1 - Ler Numeros");
        Console.WriteLine("2 - Calcular Média");
        Console.WriteLine("0 - Sair");

        int opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                numeros = LerNumeros();
                break;
            case 2:
                decimal media = CalcularMedia(numeros);
                Console.WriteLine("Média = " + media);
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