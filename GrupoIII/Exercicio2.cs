using System;

namespace GrupoIII
{
    public class Exercicio2
    {
        public static void OlaPessoa(string nome)
        {
           Console.WriteLine("Olá "+nome);
        }

        #region patas

        public static int QuantasPatas(int vacas, int porcos, int galinhas)
        {
            int patas = 0;
            patas += vacas * 4;
            patas += porcos * 4;
            patas += galinhas * 2;
            return patas;
        }

        #endregion

        public static void Somar(int n1, int n2)
        {
            int soma = n1+n2;
            if (n1==n2)
            {
                soma *= 3;
            }
            Console.WriteLine(soma);
        }

        public static int Potencia(int n, int e)
        {
            int poten = n;
            for (int i = 1; i < e; i++)
            {
                poten *= n;
            }
            return poten;
        }
    }
}
