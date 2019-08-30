using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    class Disciplina
    {
        private string nome, semestre;
        private double media;
        private bool aprovado;
        public Disciplina(string n, string s, double m, bool a)
        {
            nome = n;
            semestre = s;
            media = m;
            aprovado = a;
        }
        public override string ToString()
        {
            string j;
            if (aprovado) j = "Aprovado";
            else j = "Reprovado";
            return nome + " - " + semestre + " - " + media.ToString() + " - " + j;
        }
        public string GetNome() { return nome; }
        public string GetSemestre() { return semestre; }
        public double GetMedia() { return media; }
        public bool GetAprovado() { return aprovado; }
    }
}
