using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using LoanBookApp.Model;
using ProdutoApp.ViewModel;
using Xamarin.Forms;

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

		private ObservableCollection<Livro> livros;

		public ObservableCollection<Livro> Livros {
			get => App.ListaLivros;
			set {
				livros = App.ListaLivros;
				Notify("Livros");
			}
		}

		public ICommand Salvar { get; set; }
		
		public LivroVM() {
			Livros = App.ListaLivros;

			Salvar = new Command(SalvarAction);
		}

		private void SalvarAction() {
			if (VerificarCampos()) {
				Livro novoLivro = new Livro {
					Nome = Nome,
					Autor = Autor,
					Editora = Editora,
					Ano = Ano,
					PrecoDeVenda = PrecoDeVenda
				};
				App.ListaLivros.Add(novoLivro);

				LimparCampos();
			}
		}

		private bool VerificarCampos() {
			if(Nome != null && Autor != null && Editora != null && Ano != 0 && PrecoDeVenda != 0)
				if (Nome.Length > 0 && Autor.Length > 0 && Editora.Length > 0)
					return true;

			return false;
		}

		private void LimparCampos() {
			Nome = "";
			Autor = "";
			Editora = "";
			Ano = 0;
			PrecoDeVenda = 0;
		}
	}
}
