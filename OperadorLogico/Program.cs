using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadorLogico
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String email;
            String usuario;
            bool PermissaoADM;
            bool  RedeInterna;
            bool ContaExpirada;

            Console.WriteLine("Olá, digite o seu usuario: ");
            usuario = Console.ReadLine();

            Console.WriteLine("Digite o seu email: ");
            email = Console.ReadLine();

            Console.WriteLine("Voce tem a permissa adim ?");
            PermissaoADM = bool.Parse(Console.ReadLine());

            Console.WriteLine("Voce esta usando a rede interna ?");
            RedeInterna = bool.Parse(Console.ReadLine());

            Console.WriteLine("Voce tem a conta expirada?");
            ContaExpirada = bool.Parse(Console.ReadLine());

            if (PermissaoADM == true && RedeInterna == true && ContaExpirada == false)
            {
                Console.WriteLine("Voce pode acessar; ");

            }
            else if (PermissaoADM == true && RedeInterna == true && ContaExpirada == true)
            {
                Console.WriteLine("Voce nao pode acessar, porque sua conta expirou. Entre em contato com o seu gestor!!");
            }













        }
    }
}
