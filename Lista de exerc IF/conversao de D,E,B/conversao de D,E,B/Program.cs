using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversao_de_D_E_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float dolar, euro, bitcon;
            int valor, opcao;

            Console.WriteLine("Digite uma das Opções:");
            Console.WriteLine("Digite 1- Dolar para Real");
            Console.WriteLine("Digite 2- Euro para Real");
            Console.WriteLine("Digite 3- Bitcon para Real");

            Console.WriteLine("Escolha a opcao desejada");
            opcao = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu Valor");
            valor = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {

                dolar = valor * 5.3f;
                Console.WriteLine("O valor é: " + dolar);
            }
            else if (opcao == 2)
            {
                euro = valor * 5.56f;
                Console.WriteLine("O valor é: " + euro);
            }
            else if (opcao == 3)
            {
                bitcon = valor * 213.177f;
                Console.WriteLine("O valor é: " + bitcon);
            }
            Console.ReadKey();

        }
    }
}
    