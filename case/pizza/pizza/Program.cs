using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma das opcoes:");
            Console.WriteLine("1- Pizza de Frango com Catupiry R$ 35,00");
            Console.WriteLine("2- Pizza de Calabresa R$ 32,00");
            Console.WriteLine("3- Pizaa Portuguesa R$ 37,00");
            Console.WriteLine("4- Pizza de Mussarela R$ 30,00");
            string opc = Console.ReadLine();

            float calc, desconto;

            switch (opc)
            {
                case "1":
                    Console.WriteLine("Solicite a quantindade que deseja");
                    float qnt = float.Parse(Console.ReadLine());

                    calc = qnt * 35;
                    if(calc >= 60)
                    {
                        desconto = calc * 5 / 100;
                        calc = calc - desconto;
                    }

                    Console.WriteLine("O valor é:" + calc);
                    break;

                case "2":
                    Console.WriteLine("Solicite a quantidade que deseja");
                    float qnt1 = float.Parse(Console.ReadLine());

                    calc = qnt1 * 32;
                    if(calc >=60)
                    {
                        desconto = calc * 5 / 100;
                        calc = calc - desconto;
                    }
                    Console.WriteLine("O valor é" + calc);
                    break;

                case "3":
                    Console.WriteLine("Solicite a quantidade que deseja");
                    float qnt2 = float.Parse(Console.ReadLine());

                    calc = qnt2 * 37;
                    if (calc >= 60)
                    {
                        desconto = calc * 5 / 100;
                        calc = calc - desconto;
                    }
                    Console.WriteLine("O valor é:" + calc);
                    break;

                case "4":
                    Console.WriteLine("Solicite a quantidade que deseja");
                    float qnt3 = float.Parse(Console.ReadLine());

                    calc = qnt3 * 30;
                    if (calc >= 60)
                    {
                        desconto = calc * 5 / 100;
                        calc = calc - desconto;
                    }
                    Console.WriteLine("O valor é:" + calc);
                    break;
            }
            Console.ReadKey();
        }
    }
}
