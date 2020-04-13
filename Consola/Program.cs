using System;
using GrupoIII;
using GrupoIV;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Grupo3.Grupo3.GoodbyeWorld();
            Console.WriteLine("------");
            Exercicio2.OlaPessoa("Fábio");
            Console.WriteLine("------");
            Console.WriteLine(Exercicio2.QuantasPatas(3, 4, 2));
            Console.WriteLine("------");
            Exercicio2.Somar(1, 2);
            Exercicio2.Somar(1, 1);
            Console.WriteLine("------");
            Console.WriteLine(Exercicio2.Potencia(2, 3));
            Console.WriteLine("------");
            Exercicio3.ApresentarTabela();
            Console.WriteLine("------");
            Exercicio3.MultiploDeTresESete(21);
            Exercicio3.MultiploDeTresESete(18);
            Exercicio3.MultiploDeTresESete(14);
            Exercicio3.MultiploDeTresESete(16);
            Console.WriteLine("------");
            Exercicio3.FactorialI();
            Exercicio3.FactorialR();
            Console.WriteLine("------");
            Exercicio4.Calculadora();
        }
    }
}
