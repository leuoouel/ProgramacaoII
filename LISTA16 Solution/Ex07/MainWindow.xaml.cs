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
        Historico a = new Historico(" ");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            a = new Historico(NomeAluno.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bool ap = false;
            if (Aprovado.IsChecked == true) ap = true;
            Disciplina d = new Disciplina(NomeDisciplina.Text, Semestre.Text, double.Parse(Media.Text), ap);
            a.Inserir(d);
            Listar.ItemsSource = a.Listar();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            a.Excluir(Listar.SelectedIndex);
            Listar.ItemsSource = a.Listar();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(a.CalcularIRA().ToString(), "IRA");
        }

        private void Aprovado_Checked(object sender, RoutedEventArgs e)
        {
            if (Media.Text != "")
            {
                if (double.Parse(Media.Text) >= 60) Aprovado.IsChecked = true;
                else Aprovado.IsChecked = false;
            }
        }
    }
}
