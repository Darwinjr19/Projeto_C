using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_1
{
    internal class Program
    {       static void Main(string[] args)
            {
                Console.WriteLine("Selecione uma das Opções");
                Console.WriteLine("Digite 1- Dias para Horas");
                Console.WriteLine("Digite 2- Horas para Minutos");
                Console.WriteLine("Digite 3- Minutos para Segundos");
                Console.WriteLine("Digite o Valor para Conversão:");
                string opc = Console.ReadLine();

                float conv;

                switch (opc)
                {
                    case "1":
                        Console.WriteLine("Informe a quantidade de dia");
                        float dias = float.Parse(Console.ReadLine());
                        conv = dias * 24;
                        Console.WriteLine("O resultado é:" + conv + " Horas ");
                        break;

                    case "2":
                        Console.WriteLine("Informar a quantidade de Horas");
                        float horas = float.Parse(Console.ReadLine());
                        conv = horas * 60;
                        Console.WriteLine("O resultado é: " + conv + " Minutos ");
                        break;

                    case "3":
                        Console.WriteLine("Informe a quantidade de minutos");
                        float minutos = float.Parse(Console.ReadLine());
                        conv = minutos * 60;
                        Console.WriteLine("O resultado é: " + conv + " Segundos ");
                        break;
                }

                Console.ReadKey();

            }
    }
}
