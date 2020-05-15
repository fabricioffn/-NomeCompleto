using System;

namespace _NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string sobrenome;
            Console.WriteLine("digite seu nome...");
            nome = Console.ReadLine();
            Console.WriteLine("digite seu sobrenome...");
            sobrenome = Console.ReadLine();

            Console.WriteLine("seu nome completo: " + nome + sobrenome);
            Console.WriteLine("nome de catalogo: " + sobrenome + nome);

        }
    }
}
