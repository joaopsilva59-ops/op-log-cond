public static class Atividade1
{
    public static void Executar()
    {
        double altura;
        double raio;
        double PI = 3.14159;
        double volume;

        Console.WriteLine("Digite a altura da lata: ");
        altura = double.Parse(Console.ReadLine()!);

        Console.WriteLine();

        Console.WriteLine("Digite o raio da lata: ");
        raio = double.Parse(Console.ReadLine()!);

        volume = PI * (raio *raio) * altura;
        Console.WriteLine($"O valor do volume da lata é: {volume}");
    }
}   