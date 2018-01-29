using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanBookApp.Model;
using ProdutoApp.ViewModel;

namespace LoanBookApp.ViewModel {
	public class LivroVM : ViewModelBase{

		private string nome;

		public string Nome {
			get => nome;
			set {
				nome = value; 
				Notify("Nome");
			}
		}

		private string autor;

		public string Autor {
			get => autor;
			set {
				autor = value;
				Notify("Autor");
			}
		}

		private string editora;

		public string Editora {
			get => editora;
			set {
				editora = value;
				Notify("Editora");
			}
		}

		private int ano;

		public int Ano {
			get => ano;
			set {
				ano = value;
				Notify("Ano");
			}
		}

		private double precoDeVenda;

		public double PrecoDeVenda {
			get => precoDeVenda;
			set {
				precoDeVenda = value;
				Notify("PrecoDeVenda");
			}
		}

		private ObservableCollection<Livro> listaLivros;

		public ObservableCollection<Livro> ListaLivros {
			get { return App.ListaLivros; }
			set {
				listaLivros = App.ListaLivros;
				Notify("ListaLivros");
			}
		}

		public LivroVM() {
			ListaLivros = App.ListaLivros;
		}
	}
}
