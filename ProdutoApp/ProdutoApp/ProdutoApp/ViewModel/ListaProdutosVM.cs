using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProdutoApp.Model;

namespace ProdutoApp.ViewModel {
	public class ListaProdutosVM : ViewModelBase {

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

		private double preco;

		public double Preco {
			get => preco;
			set {
				preco = value;
				Notify("Preco");
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

		private ObservableCollection<Produto> produtos;

		public ObservableCollection<Produto> Produtos {
			get => produtos;
			set {
				produtos = value;
				Notify("Produtos");
			}
		}

		public ListaProdutosVM() {
			Produtos = new ObservableCollection<Produto>();
		}

		public ListaProdutosVM(ObservableCollection<Produto> listaProdutos) {
			Produtos = listaProdutos;
		}
	}
}
