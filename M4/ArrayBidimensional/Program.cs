internal class Program
{
    private static void Main(string[] args)
    {

        int[,] alunos = new int[4,2];

        for (int i = 0; i < alunos.GetLength(0); i++)
        {
            Console.WriteLine("Qual o  aluno?");
            alunos[i, 0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual a idade?");
            alunos[i,1] = Convert.ToInt32(Console.ReadLine());
        }

        int maiorIdade = 0;
        int numeroAluno = 0;

        for (int i = 0; i < alunos.GetLength(0); i++)
        {
            int idade = alunos[i, 1];

            if (idade > maiorIdade)
            {
                maiorIdade = idade;
                numeroAluno = alunos[i, 0];
            }
        }

        Console.WriteLine("O Aluno tem " + maiorIdade + " e o número " + numeroAluno);
        

    }
}