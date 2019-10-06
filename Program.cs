using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumaIloczyn
{
    class Program
    {
        static void Main(string[] args)
        {
            double suma = 0, iloczyn = 1;
            int n;
            Console.Write("    Podaj ilość liczb: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"\tPodaj liczbę {i}: ");
                double number = Convert.ToDouble(Console.ReadLine());
                suma += number;
                iloczyn *= number;
            }

            Console.WriteLine($"\t  Suma tych liczb to: {suma}");
            Console.WriteLine($"\t  Iloczyn tych licz to: {iloczyn}");
            Console.ReadKey();
        }
    }
}