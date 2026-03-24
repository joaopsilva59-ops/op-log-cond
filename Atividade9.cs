public static class Atividade9
{
    public static void Executar()
      {
        Console.Write("Digite um número: ");
        double numero = double.Parse(Console.ReadLine()!);

        if (numero > 0)
        {
            Console.WriteLine("O número é positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine("O número é negativo.");
        }
        else
        {
            Console.WriteLine("O número é zero.");
        }
    }
}