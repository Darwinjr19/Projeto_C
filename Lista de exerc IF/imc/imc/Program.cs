using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float peso, altura, calculodoimc;

            Console.WriteLine("Infome seu peso: ");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua Altura: ");
            altura = float.Parse(Console.ReadLine());

            calculodoimc = peso / (altura * altura);

            if (calculodoimc < 18.5)
            {
                Console.Write("A sua classificação é:" + calculodoimc + "\nMagreza" + "\nobesidade 0");
            }
            else if (calculodoimc >= 18.5 && calculodoimc < 24.9)
            {
                Console.WriteLine("A sua classificação é:" + calculodoimc + " \nNormal" + "\nobesidade 0");
            }
            else if (calculodoimc >= 25 && calculodoimc < 29.9)
            {
                Console.WriteLine("A sua classificação é:" + calculodoimc + " \nSobrepeso" + "\nObesidade 1");
            }
            else if (calculodoimc >= 30 && calculodoimc < 39.9)
            {
                Console.WriteLine("A sua classificação é:" + calculodoimc + " \nObesidade" + "\nObesidade 2");
            }
            else if (calculodoimc >= 40)
            {
                Console.WriteLine("A sua classificação é:" + calculodoimc + " \nObesidade Grave " + "\nObesidade 3");
            }
            Console.ReadKey();
        }
       
    }
    
}
