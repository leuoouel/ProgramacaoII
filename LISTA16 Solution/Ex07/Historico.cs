using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    class Historico
    {
            private string aluno;
            private int cont = 0;
            private Disciplina[] discs = new Disciplina[20];
            public Historico(string n) { aluno = n; }
            public void Inserir(Disciplina d)
            {
                if (cont < 20)
                {
                    discs[cont] = d;
                    cont++;
                }
            }
            public Disciplina[] Listar()
            {
                Disciplina[] retorno = new Disciplina[cont];
                Array.Copy(discs, retorno, cont);
                return retorno;
            }
            public double CalcularIRA()
            {
                double soma = 0;
                for (int i = 0; i < cont; i++)
                {
                    soma += discs[i].GetMedia();
                }
                return soma / cont;
            }
            public void Excluir(int k)
            {
                if (k != -1)
                {
                    for (int i = k; i < cont - 1; i++)
                    {
                        discs[i] = discs[i + 1];
                    }
                    discs[cont] = null;
                    cont--;
                }
            }
        


    }
}
