using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 números");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);
            Console.WriteLine("O maior número é: " + resultado);
        }

        static int Maior(int N1, int N2, int N3)
        {
            int maior;
            if (N1 > N2 && N1 > N3)
            {
                maior = N1;
                
            }
            else if (N2 > N1 && N2 > N3)
            {
                maior = N2;
                
            }

            else
            {
                maior = N3;
                
            }

            return maior;
        }

    }
}
