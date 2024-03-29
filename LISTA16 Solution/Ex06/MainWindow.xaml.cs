﻿using System;
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

namespace Ex06
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        Bingo a;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            a = new Bingo();
            a.Iniciar(int.Parse(txt.Text));
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (txt != null) txt.Text = slider.Value.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Resultado.Text = a.proximo().ToString();
            string texto = "";
            foreach (int i in a.Sorteados())
            {
                texto = texto + i.ToString() + " - ";
            }
            Sorteados.Text = texto;
        }
    }
}
