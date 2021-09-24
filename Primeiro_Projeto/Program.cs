using System;

namespace Primeiro_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            if(idade < 1)
            {
                Console.WriteLine("Você é um bebê!");

            } else if(idade > 1 && idade < 12)
            {
                Console.WriteLine("Você é uma criança!");

            } else if (idade > 12 && idade <= 18)
            {
                Console.WriteLine("Você é um adolescente!");

            } else if (idade > 18 && idade <= 60)
            {
                Console.WriteLine("Você é um adulto!");

            } else
            {
                Console.WriteLine("Você é um idoso!");
            }
        }
    }
}
