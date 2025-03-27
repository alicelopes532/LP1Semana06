using System;

public class random
{
    static void Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine(" ");
            return;
        }

        if (!int.TryParse(args[0], out int n) || !int.TryParse(args[1], out int s))
        {
            Console.WriteLine("Erro.");
            return;
        }

        Random random = new Random(s);
        int soma = 0;

        for (int i = 0; i < n; i++)
        {
            soma += random.Next(1, 7); 
        }

        Console.WriteLine(soma);
    }
}