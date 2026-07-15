using System;
class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        if (idade <= 20)
        {
            Console.WriteLine($"Você é novo. Você tem a idade de {idade}!");
        } else
        {
            Console.WriteLine($"Você é veio! Esta com idade de {idade}!");
        }

        Console.WriteLine($"Olá {nome}!");
        Console.WriteLine($"Você possui {idade} anos.");
    }
}