using System;

namespace PrimeiroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // Console.WriteLine("Hello World!");
            Console.WriteLine("Digite o seu nome: ");
            string name = Console.ReadLine();
            // Console.WriteLine("Nome: " + name);
            Console.WriteLine("Digite a idade de " + name + ": ");
            int age = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("A idade do " + name + " é: " + age); //concatenação
            Console.WriteLine($"A idade do {name} é: {age}"); //interpolação
        }
    }
}
