using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float n1;
            float n2;

           float resultado;

           

            Console.WriteLine("Digite um numero ");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro  numero ");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual operacao voce quer realizar? ");
            Console.WriteLine("Somar ");
            Console.WriteLine("Subtrair");
            Console.WriteLine("Multplicar");
            Console.WriteLine("Dividir ");
            String operacao = Console.ReadLine();


            switch (operacao)
            {
                case "Somar":
                case "somar":
                    Console.WriteLine(n1 + n2);
                    break;

                case "Subtrair":
                case "subtrair":
                    Console.WriteLine(n1 - n2);
                    break;
               
                case "Multiplicar":
                case "multiplicar":
                    Console.WriteLine(n1 *  n2);
                    break;
                
                case "Dividir":
                case "dividir":
                    Console.WriteLine(n1 / n2);
                    break;
                default:
                    Console.WriteLine("Voce nao selecionou nada");
                    break;








            }





        }
    }
}
