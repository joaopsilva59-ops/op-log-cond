public static class ExemplDois
{
    public static void Execultar()
    {
        double nota;
        double frequencia;

        Console.WriteLine("Digite a nota do aluno: ");
        nota = double.Parse(Console.ReadLine()!);

        Console.WriteLine();

        Console.WriteLine("Digite a Frequência do aluno: ");
        frequencia = double.Parse(Console.ReadLine()!);

        if (nota >= 7)
        {
            if (frequencia >= 75)
            {
                Console.WriteLine("Aluno aprovado!");
            }
            else
            {
                Console.WriteLine("Aluno reprovado por frequencia.");
            }
        }
    }
}   