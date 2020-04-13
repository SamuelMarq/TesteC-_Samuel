using System;

namespace GrupoIII
{
    public class Exercicio3
    {
        public static void ApresentarTabela()
        {
            int n, m;
            char c;
            Console.WriteLine("Quantas Linhas?");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas Colunas?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o Caracter?");
            c = Console.ReadLine()[0];

            for (int i = 0; i < m; i++)
            {
                for (int ii = 0; ii < n; ii++)
                {
                    Console.Write(c+" ");
                }
                Console.WriteLine();
            }
        }

        public static void MultiploDeTresESete(int n)
        {
            if (!(n % 7 == 0 || n % 3 == 0))
                Console.WriteLine("Nem multiplo de 3 nem de 7");
            else
            {
                if (n % 7 == 0 && n % 3 == 0)
                    Console.WriteLine("Multiplo de 3 e 7");
                else if (n%7==0)
                    Console.WriteLine("Multiplo de 7");
                else
                    Console.WriteLine("Multiplo de 3");
            }
        }

        public static void FactorialI()
        {
            int n;
            Console.WriteLine("Qual o número?");
            n = int.Parse(Console.ReadLine());
            if (n == 0)
                Console.WriteLine($"{n}! = 1");
            else if (n < 0)
                Console.WriteLine("O número tem de ser maior que 0");
            else
            {
                Console.Write($"{n}! = {n} x ");
                for (int i = n - 1; i > 0; i--)
                {
                    n *= i;
                    if (i == 1)
                        Console.Write($"{i} = ");
                    else
                        Console.Write($"{i} x ");
                }
                Console.WriteLine(n);
            }
        }

        public static int FactorialR(int n = 0, int fact = 1, bool run1 = true)
        {
            if (run1)
            {
                Console.WriteLine("Qual o número?");
                n = int.Parse(Console.ReadLine());
                if (n == 0)
                    Console.Write($"{n}! = 1");
                else if (n < 0)
                {
                    Console.WriteLine("O número tem de ser maior que 0");
                    return -1;
                }
                else
                {
                    Console.Write($"{n}! = ");
                    Console.Write($"{ FactorialR(n, 1, false)}\n");
                }
                    
                    
                return 0;
            }
            else
            {
                if (n == 0) 
                    return fact;
                else
                {
                    fact *= n;
                    if (n==1)
                        Console.Write($"{n} = ");
                    else
                        Console.Write($"{n} x ");
                    return FactorialR(n - 1, fact, false);
                }
            }
        }


    }
}
