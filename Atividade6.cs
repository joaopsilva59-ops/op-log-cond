public static class Atividade6
{
    public static void Executar()
    {
        Console.Write("Digite o primeiro ângulo: ");
        double a = double.Parse(Console.ReadLine()!);

        Console.Write("Digite o segundo ângulo: ");
        double b = double.Parse(Console.ReadLine()!);

        Console.Write("Digite o terceiro ângulo: ");
        double c = double.Parse(Console.ReadLine()!);

        if (a + b + c != 180)
        {
            Console.WriteLine("Não forma um triângulo");
        }
        else
        {
            if (a == 90 || b == 90 || c == 90)
            {
                Console.WriteLine("Triângulo retângulo");
            }
            else if (a > 90 || b > 90 || c > 90)
            {
                Console.WriteLine("Triângulo obtusângulo");
            }
            else
            {
                Console.WriteLine("Triângulo acutângulo");
            }
        }
    }
}