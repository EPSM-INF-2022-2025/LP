internal class Program
{
    private static void Main(string[] args)
    {

        int[,] alunos = new int[3,2];

        for (int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine("Qual o  aluno?");
            alunos[i, 0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual a idade?");
            alunos[i,1] = Convert.ToInt32(Console.ReadLine());
        }

        

    }
}