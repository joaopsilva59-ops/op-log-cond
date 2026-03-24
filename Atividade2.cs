public static class Atividade2
{
    public static void Executar()
    {
        string letra;

        Console.WriteLine("Digite a letra: ");
        letra = (Console.ReadLine()!.ToLower());

        if(letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")

        {
            Console.WriteLine($"A letra \"{letra}\" é uma vogal");
        }
         else 
        {
            Console.WriteLine($"A letra \"{letra}\" é uma consoante");
    }

       
    }
}   
