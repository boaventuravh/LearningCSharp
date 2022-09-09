using System;
class EntryPoint
    {
        static void Main()
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine(nome);
            Console.WriteLine(idade);
        }
    }