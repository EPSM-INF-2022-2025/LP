internal class Program
{

    internal static string[] titulos = new string[3];
    internal static string[] autores = new string[3];
    internal static double[] precos = new double[3];

    private static void Main(string[] args)
    {
        MostrarMenu();
    }

    private static void MostrarMenu()
    {
        Console.WriteLine("1 - Registar Livros");
        Console.WriteLine("2 - Mostrar mais caro");
        Console.WriteLine("3 - Mostrar mais barato");
        Console.WriteLine("4 - Mostrar média");
        Console.WriteLine("5 - Mostrar livros de autor");
        Console.WriteLine("0 - Sair");

        int opcao = Convert.ToInt32(Console.ReadLine());
        bool continuar = true;

        while (continuar)
        {
            switch (opcao)
            {
                case 1:
                    RegistarLivros();
                    break;
                case 2:
                    MostrarMaisCaro();
                    break;
                case 3:
                    MostrarMaisBarato();
                    break;
                case 4:
                    MostrarMedia();
                    break;
                case 5:
                    MostrarLivrosAutor();
                    break;
                case 0:
                    continuar = false;
                    break;
                default:
                    break;
            }
        }
        
        
    }

    private static void MostrarLivrosAutor()
    {
        Console.WriteLine("Qual o autor?");
        string autor = Console.ReadLine();

        for (int i = 0; i < autores.Length; i++)
        {
            if (autores[i] == autor) {
                Console.WriteLine("Titulo = " + titulos[i]);
                Console.WriteLine("Autor = " + autores[i]);
                Console.WriteLine("Preço = " + precos[i]);
            }
        }
    }

    private static void MostrarMedia()
    {
        double media;
        double soma = 0;

        for (int i = 0; i < precos.Length; i++)
        {
            soma = soma + precos[i];
        }

        media = soma / precos.Length;

        Console.WriteLine("Média = " + media);
    }

    private static void MostrarMaisBarato()
    {
        string tituloMaisBarato = "";
        string autorMaisBarato = "";
        double precoMaisBarato = double.MaxValue;

        for (int i = 0; i < precos.Length; i++)
        {
            if (precos[i] < precoMaisBarato)
            {
                precoMaisBarato = precos[i];
                tituloMaisBarato = titulos[i];
                autorMaisBarato = autores[i];
            }
        }

        Console.WriteLine("Titulo = " + tituloMaisBarato);
        Console.WriteLine("Autor = " + autorMaisBarato);
        Console.WriteLine("Preço = " + precoMaisBarato);
    }

    private static void MostrarMaisCaro()
    {
        string tituloMaisCaro = "";
        string autorMaisCaro = "";
        double precoMaisCaro = 0;

        for (int i = 0; i < precos.Length; i++)
        {

            if (precos[i] > precoMaisCaro)
            {
                precoMaisCaro = precos[i];
                tituloMaisCaro = titulos[i];
                autorMaisCaro = autores[i];
            }

        }

        Console.WriteLine("Titulo = " + tituloMaisCaro);
        Console.WriteLine("Autor = " + autorMaisCaro);
        Console.WriteLine("Preço = " + precoMaisCaro);
    }

    private static void RegistarLivros()
    {
        for (int i = 0; i < titulos.Length; i++)
        {
            Console.WriteLine("Qual o titulo?");
            titulos[i] = Console.ReadLine();

            Console.WriteLine("Qual o autor?");
            autores[i] = Console.ReadLine();

            Console.WriteLine("Qual o preço?");
            precos[i] = Convert.ToDouble(Console.ReadLine());

        }
    }
}