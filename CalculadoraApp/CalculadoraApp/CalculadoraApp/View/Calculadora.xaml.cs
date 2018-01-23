using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculadoraApp.View {
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Calculadora: ContentPage {

		public string MathOperator { get; set; }
		public double FirstNumber { get; set; }
		public double SecondNumber { get; set; }
		public int Contador { get; set; }

		private StringBuilder acumulador;

		public Calculadora() {
			InitializeComponent();
			Contador = 0;
			acumulador = new StringBuilder();
			OnClear(this, null);
		}

		void OnSelectNumber(object sender, EventArgs e) {
			Button button = (Button)sender;
			string pressed = button.Text;

			if (Contador > 0) {
				acumulador.Append(pressed);
				SecondNumber = Convert.ToDouble(acumulador.ToString());
				this.txtAcumulado.Text = this.txtAcumulado.Text + acumulador[acumulador.Length - 1];
			}
			else {
				acumulador.Append(pressed);
				FirstNumber = Convert.ToDouble(acumulador.ToString());
				this.txtAcumulado.Text = FirstNumber.ToString();
			}
		}

		private void ObterValor(object sender, EventArgs e) {
			double resultado = Calculate(FirstNumber, SecondNumber, MathOperator);

			if (resultado != Double.MinValue)
				this.txtResult.Text = Convert.ToString(resultado);
			else 
				this.txtResult.Text = "/ by ZERO";

			ClearOpContAcu();
		}

		public static double Calculate(double firstNum, double secondNum, string mathOp) {
			double result = 0;

			switch (mathOp) {
				case "/":
					if (secondNum != 0)
						result = firstNum / secondNum;
					else
						result = Double.MinValue;

					break;
				case "X":
					result = firstNum * secondNum;
					break;
				case "+":
					result = firstNum + secondNum;
					break;
				case "-":
					result = firstNum - secondNum;
					break;
				default:
					return result;
			}

			return result;
		}

		private void OnClear(object sender, EventArgs e) {
			FirstNumber = 0;
			SecondNumber = 0;
			MathOperator = "";
			this.txtResult.Text = "0";
			Contador = 0;
			acumulador = new StringBuilder();
			this.txtAcumulado.Text = "";
		}

		private void ClearOpContAcu() {
			MathOperator = "";
			Contador = 0;
			acumulador = new StringBuilder();
		}

		private void OnSelectOperator(object sender, EventArgs e) {
			Button button = (Button) sender;
			MathOperator = button.Text;
			acumulador = new StringBuilder();
			this.txtAcumulado.Text = this.txtAcumulado.Text + $" {MathOperator} ";
			Contador++;
		}
	}
}