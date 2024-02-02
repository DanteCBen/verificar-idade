using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verificar_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificação de idade!");

            int idade = int.Parse(Console.ReadLine());

            if (idade > 0 && idade <= 10)
            {
                Console.WriteLine("Você é uma criança");
            } else if (idade > 10 && idade <= 17)
            {
                Console.WriteLine("Você é um adolescente!");
            } else if (idade >= 18 && idade < 60)
            {
                Console.WriteLine("Você é um adulto");
            } else
            {
                Console.WriteLine("Você é um idoso!");
            }
        }
    }
}
