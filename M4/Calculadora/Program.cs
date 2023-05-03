MostrarMenuInicial();

static void MostrarMenuInicial()
{
    bool continuar = true;

    while (continuar)
    {
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");
        Console.WriteLine("0 - Sair");

        int opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 0:
                continuar = false;
                break;
            case 1:
                Somar();
                break;
            case 2:
                Subtrair();
                break;
            case 3:
                Multiplicar();
                break;
            case 4:
                Dividir();
                break;
            default:
                break;
        }
    }
}

static void Somar()
{
    Console.WriteLine("Qual o numero 1?");
    int numero1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Qual o numero 2?");
    int numero2 = Convert.ToInt32(Console.ReadLine());

    int resultado = numero1 + numero2;

    Console.WriteLine("Resultado = " + resultado);
}

static void Subtrair()
{
    Console.WriteLine("Qual o numero 1?");
    int numero1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Qual o numero 2?");
    int numero2 = Convert.ToInt32(Console.ReadLine());

    int resultado = numero1 - numero2;

    Console.WriteLine("Resultado = " + resultado);
}

static void Multiplicar()
{
    Console.WriteLine("Qual o numero 1?");
    int numero1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Qual o numero 2?");
    int numero2 = Convert.ToInt32(Console.ReadLine());

    int resultado = numero1 * numero2;

    Console.WriteLine("Resultado = " + resultado);
}

static void Dividir()
{
    Console.WriteLine("Qual o numero 1?");
    int numero1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Qual o numero 2?");
    int numero2 = Convert.ToInt32(Console.ReadLine());

    int resultado = numero1 / numero2;

    Console.WriteLine("Resultado = " + resultado);
}