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

namespace Ex01
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
            Viagem x = new Viagem();
            x.SetDistancia(double.Parse(d.Text));
            x.SetTempo(double.Parse(t.Text));
            v.Text = x.CalcVelocidade().ToString();
        }
        class Viagem
        {
            private double Distancia;
            private double Tempo;

            public void SetDistancia(double v)
            {
                Distancia = v;
            }
            public void SetTempo(double v)
            {
                Tempo = v;
            }
            public double GetDistancia()
            {
                return Distancia;
            }
            public double GetTempo()
            {
                return Tempo;
            }
            public double CalcVelocidade()
            {
                return Distancia / Tempo;
            }
        }
    }
}
