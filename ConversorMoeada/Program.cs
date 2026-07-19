using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoeada
{
    internal class Program
    {
        static void Main(string[] args)
        {


            float valor;
            float dolar = 5.18f;
            float euro = 5.97f;

            Console.WriteLine("1 - Dolar");
            Console.WriteLine("2 - Euro");

            // 1. Primeiro recebemos o dinheiro do usuário
            Console.WriteLine("Digite quanto dinheiro em Real você tem: ");
            valor = float.Parse(Console.ReadLine());

            // 2. Depois recebemos a OPÇÃO da moeda que ele quer
            Console.WriteLine("Agora escolha a moeda para conversão (1 ou 2): ");
            string opcao = Console.ReadLine();

            // 3. O switch agora avalia a OPÇÃO escolhida (usando aspas duplas de string)
            switch (opcao)
            {
                case "1":
                    // Em vez de multiplicar, dividimos o Real pelo valor do Dólar para saber quantos dólares temos
                    Console.WriteLine("Dinheiro convertido em dólar você tem: " + (valor / dolar));
                    break;

                case "2":
                    // Mesma coisa aqui, dividimos o Real pelo valor do Euro
                    Console.WriteLine("Dinheiro convertido em euro você tem: " + (valor / euro));
                    break;

                default:
                    Console.WriteLine("Opção de moeda inválida!");
                    break;
            }








        }
    }
}
