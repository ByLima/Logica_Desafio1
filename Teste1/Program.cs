using System;

namespace Teste1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            int Idade;
            string Sexo;
            Console.WriteLine("Entre com o seu nome: ");
            Console.WriteLine("Entre com a sua idade: ");
            Console.WriteLine("Entre com a seu sexo M ou F: ");
            Nome = Console.ReadLine();
            Idade = Convert.ToInt32(Console.ReadLine());
            Sexo = Console.ReadLine();

            if (Idade >= 21 && Sexo == "M")
            {
               Console.WriteLine("Seu nome é: ",(Nome));
                Console.WriteLine(Idade);
                Console.WriteLine(Sexo);
            }
            else
            {
                Console.WriteLine("Menor de 21 anos ou do sexo feminino");
            }
            Console.ReadLine();
        }
    }
}
