public static class Atividade4
{
    public static void Executar()
 {
        // Ler as notas
        Console.Write("Digite a nota N1: ");
        double n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a nota N2: ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        // Calcular a média
        double media = (n1 + n2) / 2;

        // Determinar o conceito
        string conceito;

        if (media >= 8.5 && media <= 10)
            conceito = "A";
        else if (media >= 7)
            conceito = "B";
        else if (media >= 5)
            conceito = "C";
        else if (media >= 3)
            conceito = "D";
        else
            conceito = "E";

        // Exibir resultado
        Console.WriteLine($"Média: {media:F2}");
        Console.WriteLine($"Conceito: {conceito}");
    }
}