using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ProdutoApp.Model;
using Xamarin.Forms;

namespace ProdutoApp.ViewModel {
	public class ProdutoVM : ViewModelBase {
		public ObservableCollection<Produto> ListaProdutos { get; set; }

		private int codigo;

		public int Codigo {
			get => codigo;
			set {
				codigo = value;
				Notify("Codigo");
			}
		}

		private string nome;

		public string Nome {
			get => nome;
			set {
				nome = value;
				Notify("Nome");
			}
		}

		private string fabricante;

		public string Fabricante {
			get => fabricante;
			set {
				fabricante = value;
				Notify("Fabricante");
			}
		}

		public ICommand Salvar { get; set; }

		public ICommand Listar { get; set; }

		public ICommand AbrirFabricante { get; set; }

		public ProdutoVM() {
			ListaProdutos = new ObservableCollection<Produto>();

			Salvar = new Command(RealizarGravacao);
			Listar = new Command(AbrirLista);
			AbrirFabricante = new Command(AbrirTelaFabricante);
			Fabricante = "Adicione Fabricante da Lista";
		}

		public ProdutoVM(Fabricante fabricante) {
			Fabricante = fabricante.Nome;
		}

		private async void AbrirTelaFabricante() {
			await Application.Current.MainPage.Navigation.PushAsync(new View.FabricanteView());
		}

		private async void AbrirLista() {
			// await Application.Current.MainPage.Navigation.PushAsync(new View.ListaProdutosView());
		}

		private void RealizarGravacao() {
			Produto produto = new Produto {
				Codigo = Codigo,
				Nome = Nome
			};
			ListaProdutos.Add(produto);
		}
	}
}