using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ex07
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
        class Disciplina
        {
            private string nome;
            private int media;
            public Disciplina(string nome, int media)
            {
                this.nome = nome;
                this.media = media;
            }
            public override string ToString()
            {
                return nome;
            }
            public int GetMedia()
            {
                return media;
            }
        }

        class Historico
        {
            private string aluno;
            private Disciplina[] discs = new Disciplina[10];
            private int k;
            public Historico(string aluno)
            {
                this.aluno = aluno;
            }
            public void Inserir(Disciplina d)
            {
                if (k < 10) discs[k++] = d;
            }
            public Disciplina[] Listar()
            {
                Disciplina[] novo = new Disciplina[k];
                Array.Copy(discs, novo, k);
                return novo;
            }
            public double IRA()
            {
                if (k == 0) return 0;
                double x = 0;
                foreach (Disciplina d in discs)
                    if (d != null) x = x + d.GetMedia();
                return x / k;
            }
        }

    }
}
