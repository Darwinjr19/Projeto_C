using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasolina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float preço;
            float etanol;
            float gasolina;
            float lado;





            Console.WriteLine("Digite o preço da gasolina");
            gasolina = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço do Etanol");
            etanol = float.Parse(Console.ReadLine());


            Console.WriteLine("Digite o seu combustivel");
            lado = float.Parse(Console.ReadLine());
            preço = gasolina * 70 / 100;

            if (preço <= etanol)
            {
                Console.WriteLine("O etanol e recomendado");

            }
            else
            {

                Console.WriteLine("Fica sem abastecer");

            }
            Console.ReadKey();
        }
    }
}
   
