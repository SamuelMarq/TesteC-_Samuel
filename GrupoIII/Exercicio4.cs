using System;

namespace GrupoIII
{
    public class Exercicio4
    {
        public static void Calculadora()
        {
            int a, b;
            string op;
            try
            {
                Console.WriteLine("Primeiro Número?");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Segundo Número?");
                b = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("O valor introduzido não é um numero");
                return;
            }
            Console.WriteLine("Qual a operação?");
            op = Console.ReadLine()[0].ToString();
            try
            {
                ValidarInput(a,b,op);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("O operador não é reconhecido");
                return;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Ocorreu uma tentativa de dividir por 0");
                return;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("O primeiro número é divisivel por 5 ou o segundo número por 3");
                return;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Um dos valores não se encontra entre 0 e 100");
                return;
            }
            switch (op)
            {
                case "+":
                    Som(a, b);
                    break;
                case "-":
                    Sub(a, b);
                    break;
                case "*":
                    Mul(a, b);
                    break;
                case "/":
                    Div(a, b);
                    break;
                case "%":
                    Res(a, b);
                    break;
            }
        }
        #region operações
        private static void Som(int a,int b)
        {
            var resultado = a + b;
            Console.WriteLine($"{a} + {b} = {resultado}");
        }

        private static void Sub(int a, int b)
        {
            var resultado = a - b;
            Console.WriteLine($"{a} - {b} = {resultado}");
        }

        private static void Mul(int a, int b)
        {
            var resultado = a * b;
            Console.WriteLine($"{a} x {b} = {resultado}");
        }

        private static void Div(int a, int b)
        {
            var resultado = a / b;
            Console.WriteLine($"{a} / {b} = {resultado}");
        }

        private static void Res(int a, int b)
        {
            var resultado = a % b;
            Console.WriteLine($"{a} % {b} = {resultado}");
        }
        #endregion

        private static void ValidarInput(int a, int b, string opt)
        {
            var op = opt[0];
            if(op != '+' && op != '-' && op != '*' && op != '/' && op != '%' ) throw new InvalidOperationException();
            if (op == '/'  && b == 0) throw new DivideByZeroException();
            if(a<0 || a > 100 || b<0 || b >100) throw new ArgumentOutOfRangeException();
            if(a%5==0 || b%3==0) throw new ArithmeticException();
        }

        private static void ValidarInput(int a, int b, char op)
        {
           
            if (op != '+' || op != '-' || op != '*' || op != '/' || op != '%') throw new InvalidOperationException();
            if (b == 0) throw new DivideByZeroException();
            if (a < 0 || a > 100 || b < 0 || b > 100) throw new ArgumentOutOfRangeException();
            if (a % 5 == 0 || b % 3 == 0) throw new ArithmeticException();
        }
    }
}
