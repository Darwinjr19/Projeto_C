using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nat_mortalidade
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            {
                Console.WriteLine("Escolha uma das Opcoes: ");
                Console.WriteLine("1 - Taxa de Natalidade");
                Console.WriteLine("2 - Taxa de Mortalidade");
                string opc = Console.ReadLine();

                float calc;

                switch (opc)
                {
                    case "1":
                        Console.WriteLine("Digite o número de nascimentos");
                        int nascimento = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o número de habitantes");
                        float habitantes = float.Parse(Console.ReadLine());
                        calc = nascimento * 1000 / habitantes;
                        Console.WriteLine("A taxa de natalidade é:" + calc);
                        break;

                    case "2":
                        Console.WriteLine("Digite o número de Óbitos:");
                        float obt = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o número de Habitantes");
                        float hab = float.Parse(Console.ReadLine());
                        calc = obt * 1000 / hab;
                        Console.WriteLine("A taxa de Mortalidade é:" + calc);
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
   
