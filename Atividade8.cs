public static class Atividade8
{
    public static void Executar()
    {
        int respostasPositivas = 0;

        Console.Write("Telefonou para a vítima? (s/n): ");
        if (Console.ReadLine()!.ToLower() == "s")
            respostasPositivas++;

        Console.Write("Esteve no local do crime? (s/n): ");
        if (Console.ReadLine()!.ToLower() == "s")
            respostasPositivas++;

        Console.Write("Mora perto da vítima? (s/n): ");
        if (Console.ReadLine()!.ToLower() == "s")
            respostasPositivas++;

        Console.Write("Devia para a vítima? (s/n): ");
        if (Console.ReadLine()!.ToLower() == "s")
            respostasPositivas++;

        Console.Write("Já trabalhou com a vítima? (s/n): ");
        if (Console.ReadLine()!.ToLower() == "s")
            respostasPositivas++;

        Console.WriteLine();

        if (respostasPositivas == 2)
        {
            Console.WriteLine("Classificação: Suspeita");
        }
        else if (respostasPositivas >= 3 && respostasPositivas <= 4)
        {
            Console.WriteLine("Classificação: Cúmplice");
        }
        else if (respostasPositivas == 5)
        {
            Console.WriteLine("Classificação: Assassino");
        }
        else
        {
            Console.WriteLine("Classificação: Inocente");
        }
    }
}