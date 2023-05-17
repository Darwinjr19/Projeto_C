using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira Nota:");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda Nota:");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira Nota:");
            float num3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quarta Nota:");
            float num4 = float.Parse(Console.ReadLine());

            float media = (num1 + num2 + num3 + num4) / 4;


            if (media < 5)
            {
                Console.WriteLine("Aluno Retido");
            }
            else if (media < 7)
            {
                Console.WriteLine("Aluno esta de Recuperação");
            }
            if (media >= 7)
            {
                Console.WriteLine("Aluno está Aprovado");
            }

            Console.ReadKey();
        }

    }
}
    