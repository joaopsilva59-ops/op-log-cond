 public static class Atividade7
{
    public static void Executar()
 
 {
        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine()!);

        Console.Write("Digite seu peso (kg): ");
        double peso = double.Parse(Console.ReadLine()!);

        bool podeDoar = true;

        if (idade < 18 || idade > 67)
        {
            podeDoar = false;
        }

        if (peso <= 60)
        {
            podeDoar = false;
        }

        if (podeDoar)
        {
            Console.WriteLine("Você pode doar sangue.");
        }
        else
        {
            Console.WriteLine("Você não pode doar sangue pelos seguintes motivos:");

            if (idade < 18)
            {
                Console.WriteLine("- Idade menor que 18 anos.");
            }
            if (idade > 67)
            {
                Console.WriteLine("- Idade maior que 67 anos.");
            }
            if (peso <= 60)
            {
                Console.WriteLine("- Peso menor ou igual a 60 kg.");
            }
        }
    }
}