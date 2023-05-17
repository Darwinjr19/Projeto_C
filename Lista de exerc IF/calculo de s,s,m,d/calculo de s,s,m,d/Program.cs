using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_de_s_s_m_d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor, opcao, a, b, soma, subtracao, multiplicacao, divisao;

            Console.WriteLine("escolha uma das opcoes: ");
            Console.WriteLine("Digite 1- Soma");
            Console.WriteLine("Digite 2- Subtracao");
            Console.WriteLine("Digite 3- Multiplicacao");
            Console.WriteLine("Digite 4- Divisao");

            Console.WriteLine("Escolha a opcao desejada");
            opcao = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Valor");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo Valor");
            b = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                valor = a + b;
                Console.WriteLine("O valor é: " + valor);
            }
            else if (opcao == 2)
            {
                valor = a - b;
                Console.WriteLine("O valor é:" + valor);
            }
            else if (opcao == 3)
            {
                valor = a * b;
                Console.WriteLine("O valor é:" + valor);
            }
            else if (opcao == 4)
            {
                valor = a / b;
                Console.WriteLine("O valor é:" + valor);
            }
            Console.ReadKey();

        }
    }
}
