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

namespace EquacaoII
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
			double a = double.Parse(txtA.Text);
			double b = double.Parse(txtB.Text);
			double c = double.Parse(txtC.Text);
			Equacao x = new Equacao();
			x.SetABC(a, b, c);
			txtdelta.Text = x.Delta().ToString();

			double i, j;
			if (x.X1(out i))
			{
				txtx1.Text = i.ToString();
			}
			else
			{
				txtx1.Text = "ERRO";
			}
			if (x.X2(out j))
			{
				txtx2.Text = j.ToString();
			}
			else
			{
				txtx2.Text = "ERRO";
			}
		}
		class Equacao
		{
			private double a;
			private double b;
			private double c;

			public void SetABC(double a, double b, double c)
			{
				this.a = a;
				this.b = b;
				this.c = c;
			}
			public void GetABC(out double a, out double b, out double c)
			{
				a = this.a;
				b = this.b;
				c = this.c;
			}
			public double Delta()
			{
				return b * b - 4 * a * c;
			}
			public bool RaizesReais()
			{
				if (Delta() >= 0)
				{
					return true;
				}
				else
				{
					return false;
				}

			}
			public bool X1(out double x)
			{
				if (Delta() >= 0)
				{
					x = (-b + Math.Sqrt(Delta())) / (2 * a);
					return true;
				}


				else
				{
					x = 0;
					return false;
				}

			}
			public bool X2(out double x)
			{
				if (Delta() >= 0)
				{
					x = (-b - Math.Sqrt(Delta())) / (2 * a);
					return true;
				}
				else
				{
					x = 0;
					return false;
				}
			}
		}
	}
}
