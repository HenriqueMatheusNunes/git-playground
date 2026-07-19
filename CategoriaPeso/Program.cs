using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoriaPeso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome;
            int idade;
            float altura;
            float peso;

            Console.WriteLine("Olá, digite o seu nome : ");
            nome = Console.ReadLine();
            
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a sua altura");
            altura = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o seu peso");
            peso = float.Parse(Console.ReadLine());

            if (peso <= 70.0)
            {
                Console.WriteLine("Voce " + nome + "Idade " + idade + " Altura " + altura + " Peso " + peso + " Sua categoria é peso leve");
            } else if (peso <= 77)
            {
                Console.WriteLine("Voce " + nome + "Idade " + idade + " Altura " + altura + " Peso " + peso + " Sua categoria é peso meio-médio");
            } else if (peso <= 83)
            {
                Console.WriteLine("Voce " + nome + "Idade " + idade + " Altura " + altura + " Peso " + peso + " Sua categoria é peso médio");
            } else if (peso <= 93 )
            {
                Console.WriteLine("Voce " + nome + "Idade " + idade + " Altura " + altura + " Peso " + peso + " Sua categoria é peso meio pesado");
            } else if (peso == 120)
            {
                Console.WriteLine("Voce " + nome + "Idade " + idade + " Altura " + altura + " Peso " + peso + " Sua categoria é peso ");
            }


          




        }
    }
}
