using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desconto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String cliente;

            Console.WriteLine("Diga qual o seu nivel nosso ? ");
            Console.WriteLine("Sou Standard  ");
            Console.WriteLine("Sou  Silver ");
            Console.WriteLine("Sou Gold ");
            Console.WriteLine("Sou Platinum ");
            Console.WriteLine("Ainda não sou ");







            cliente = Console.ReadLine();

            switch (cliente)
            {
                case "0":
                    Console.WriteLine("Ainda não faço parte ");
                    if (cliente == "0") Console.WriteLine("Voce quer fazer parte? Qual voce queria ser ?");
                    String parte = Console.ReadLine();
                    Console.WriteLine("Voce agora é " + parte);
                    break;
                case "1":
                    Console.WriteLine("  Standard tem 10% de desconto");
                    break;
                case "2":
                    Console.WriteLine("Silver  tem 15% de desconto");
                    break;
                case "3":
                    Console.WriteLine(" Gold  tem 20% de desconto");
                    break;
                case "4":
                    Console.WriteLine(" Platinum tem 25% de desconto");
                    break;

                default:
                    Console.WriteLine("Voce não selecionou nenhuma opcao, por favor nos diga qual e voce ");
                    break;


           }






        }
    }
}
