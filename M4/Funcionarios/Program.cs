internal class Program
{
    static List<int> codigos = new List<int>();
    static List<string> nomes = new List<string>();
    static List<string> telefones = new List<string>();
    static List<string> emails = new List<string>();

    private static void Main(string[] args)
    {

        bool sair = false;

        while (sair == false)
        {
            Console.WriteLine("SISTEMA DE GESTÃO DE FUNCIONÁRIOS");
            Console.WriteLine("1 - Criar Funcionário");
            Console.WriteLine("2 - Consultar Funcionário");
            Console.WriteLine("3 - Atualizar Funcionário");
            Console.WriteLine("4 - Remover Funcionário");
            Console.WriteLine("5 - Listar Funcionários");
            Console.WriteLine("0 - SAIR");

            Console.WriteLine("Escolha uma das opções?");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CriarFuncionario()
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 0:
                    sair = true;
                    break;
                default:
                    break;
            }
        }
    }

    static void CriarFuncionario()
    {

        Console.WriteLine("Qual o nome?");
        string nome = Console.ReadLine();

        Console.WriteLine("Qual o telefone?");
        string telefone = Console.ReadLine();

        Console.WriteLine("Qual o email?");
        string email = Console.ReadLine();

        int novoCodigo = codigos.Count() + 1;

        codigos.Add(novoCodigo); 
        nomes.Add(nome);
        telefones.Add(telefone);
        emails.Add(email);

        Console.WriteLine("Funcionário adicionado com sucesso!");

    }
}