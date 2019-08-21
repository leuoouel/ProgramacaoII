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

namespace Ex05
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

		class Numeros
		{
			private int inicio;
			private int fim;

			public void Setinicio(int x)
			{
				inicio = x;
			}
			public void SetFim(int x)
			{
				fim = x;
			}
			public double GetInicio()
			{
				return inicio;
			}
			public double GetFim()
			{
				return fim;
			}

			public Numeros(int i, int f)
			{
				inicio = i;
				fim = f;
			}
			public int[] Calcular(bool p, bool i)
			{
				int[] k = new int[10];
				int z = 0;
				for (int w = inicio; w <= fim; w++)
				{
					if (w % 2 == 0 && p == true)
					{
						k[z] = w;
						z++;
					}
					if (w % 2 == 1 && i == true)
					{
						k[z] = w;
						z++;
					}
					if(p == true && i == true)
					{
						k[z] = w;
						z++;
					}
				}
				return k;
			}
		}

		
	}
}
