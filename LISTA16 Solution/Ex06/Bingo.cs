using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    class Bingo
    {
        private int numBolas, cont = 0;
        public void Iniciar(int a) { numBolas = a; }
        private bool[] sorteados = new bool[100];
        private int[] Sort = new int[100];
        public int proximo()
        {
            Random random = new Random();
            bool passar = false;
            int k = 0;
            while (!passar)
            {
                k = random.Next(1, numBolas + 1);
                if (!sorteados[k - 1] && cont < numBolas)
                {
                    sorteados[k - 1] = true;
                    passar = true;
                    Sort[cont] = k;
                    cont++;
                }
            }
            if (cont >= numBolas) return -1;
            return k;
        }
        public int[] Sorteados()
        {
            int[] retorno = new int[cont];
            Array.Copy(Sort, retorno, cont);
            return retorno;
        }
        public int GetCont() { return cont; }
    }
}

