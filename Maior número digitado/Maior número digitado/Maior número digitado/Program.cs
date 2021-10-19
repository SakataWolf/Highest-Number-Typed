using System;

namespace Maior_número_digitado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maior número que foi digitado.\n");
            int n, Mn;
            Console.Write("Digite o 1° número: ");
            Mn = int.Parse(Console.ReadLine());
            for (int x = 1; x < 15; x++)
            {
                Console.Write("Digite o {0}° número: ", x + 1);
                n = int.Parse(Console.ReadLine());
                if (n > Mn)
                {
                    Mn = n;
                }
            }
            Console.WriteLine("\nO maior número digitado foi: {0}", Mn);
            Console.ReadKey();
        }
    }
}
