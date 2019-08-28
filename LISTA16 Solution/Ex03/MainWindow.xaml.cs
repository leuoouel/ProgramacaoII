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

namespace Ex03
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
            Retangulo x = new Retangulo();
            x.SetAltura(double.Parse(a.Text));
            x.SetBase(double.Parse(b.Text));
            area.Text = x.CalcArea().ToString();
            diagonal.Text = x.CalcDiagonal().ToString();
        }
        class Retangulo
        {
            private double b;
            private double h;

            public void SetBase(double v)
            {
                b = v;
            }
            public void SetAltura(double v)
            {
                h = v;
            }
            public double GetBase()
            {
                return b;
            }
            public double GetAltura()
            {
                return h;
            }
            public double CalcArea()
            {
                return b * h;
            }
            public double CalcDiagonal()
            {
                double d = (b * b) + (h * h);
                return Math.Sqrt(d);
            }
        }
    }
}
