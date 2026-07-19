using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjusteSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String nome;
            int filhos;
            float salario;
            float salarioNovo;

            Console.WriteLine("Olá, digite o seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o seu salario atual ");
            salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Quantos filhos voce tem ");
            filhos = int.Parse(Console.ReadLine());

            if (filhos <= 2)
            {
                salarioNovo = salario + (salario * 2 / 100);
                Console.WriteLine("Seu salario novo é de " + salarioNovo);
            }
            else if (filhos == 3)
            {
                salarioNovo = salario + (salario * 3 / 100) ;
                Console.WriteLine("Seu salario novo é de " + salarioNovo);
            }
            else if ( filhos >=4)
            {
                salarioNovo = salario + (salario * 4 / 100);
                Console.WriteLine("Seu salario novo é de " + salarioNovo);

            }





        }
    }
}
