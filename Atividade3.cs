public static class Atividade3
{
    public static void Executar()
    {
        int n1;
        int n2;
        int n3;
        int maior = 0;
        int intermediairo = 0;
        int menor = 0;

        Console.WriteLine("Digite o primeiro número: ");
        n1 = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o segundo número: ");
        n2 = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o terceiro número: ");
        n3 = int.Parse(Console.ReadLine()!);
    
        if (n1 > n2 && n1 > n3)
        {
            maior = n1;

            if (n2 > n3)
            {
                intermediairo = n2;
                menor = n3;
            }
            else
            {
                intermediairo = n3;
                menor = n2;
            }
        }

        if (n2 > n1 && n2 > n3)
        {
            maior = n2;

            if (n1 > n3)
            {
                intermediairo = n1;
                menor = n3;
            }
            else
            {
                intermediairo = n3;
                menor = n1;
            }
        }

        if (n3 > n2 && n3 > n1)
        {
            maior = n3;

            if (n2 > n1)
            {
                intermediairo = n2;
                menor = n1;
            }
            else
            {
                intermediairo = n1;
                menor = n2;
            }
        }

        Console.WriteLine($"{menor}, {intermediairo}, {maior}");

    }
}