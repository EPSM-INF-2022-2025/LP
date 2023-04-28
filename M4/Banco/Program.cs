// Executar Sub-Programa
MostrarMenuInicial();

static void MostrarMenuInicial() {

    string nomeTitular = "";
    decimal saldoConta = 0;

    // Declarar variável
    bool continuarPrograma = true;

    while (continuarPrograma)
    {
        // Mostrar menu
        Console.WriteLine("1 - Criar Conta");
        Console.WriteLine("2 - Depositar");
        Console.WriteLine("3 - Levantar");
        Console.WriteLine("0 - Sair");

        // Guardar opção escolhida pelo utilizador
        int opcaoEscolhida = Convert.ToInt32(Console.ReadLine());

        switch (opcaoEscolhida)
        {
            case 1:
                CriarConta(ref nomeTitular, ref saldoConta);
                break;
            case 2:
                decimal novoSaldo = Depositar(ref saldoConta);
                Console.WriteLine("Novo Saldo = " + novoSaldo);
                break;
            case 3:
                decimal novoSaldoLevantar = Levantar(ref saldoConta);
                Console.WriteLine("Novo Saldo = " + novoSaldoLevantar);
                break;
            case 0:
                continuarPrograma = false;
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }

}

static void CriarConta(ref string nomeTitular, ref decimal saldoConta)
{
    Console.WriteLine("Qual o nome?");
    nomeTitular = Console.ReadLine();

    Console.WriteLine("Qual o saldo?");
    saldoConta = Convert.ToDecimal(Console.ReadLine());
}

static decimal Depositar(ref decimal saldoConta) {

    Console.WriteLine("Qual o valor?");
    decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());

    saldoConta = saldoConta + valorDeposito;

    return saldoConta;

}

static decimal Levantar(ref decimal saldoConta)
{
    Console.WriteLine("Qual o valor a levantar?");
    decimal valorLevantar = Convert.ToDecimal(Console.ReadLine());

    saldoConta = saldoConta - valorLevantar;

    return saldoConta;
}