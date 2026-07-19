using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notasconceitos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int notas;
            

            Console.WriteLine("Digite qual nota voce tirou");
            notas = int.Parse(Console.ReadLine());


            switch (notas)
            {

                case 10:
                case 9:
                    Console.WriteLine("Muito  bom");
                   break;

                case 8:
                case 7:
                    Console.WriteLine("Bom");
                    break;

                case 6:
                case 5:
                    Console.WriteLine("Regular");
                    break;

                case 4:
                case 3:
                    Console.WriteLine("Ruim ");
                    break;

                case 2:
                case 1:
                    Console.WriteLine(" Burro");
                    break;

                case 0:
                    Console.WriteLine("Voce tem problema?");
                    break;

                default:
                    Console.WriteLine("Voce nao digitou sua nota");
                    break;








            }





        }
    }
}
