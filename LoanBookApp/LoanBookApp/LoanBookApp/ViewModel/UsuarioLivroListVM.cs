using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanBookApp.Model;
using ProdutoApp.ViewModel;

namespace LoanBookApp.ViewModel {
    public class UsuarioLivroListVM : ViewModelBase{
	    public string Nome { get; set; }
	    public string Autor { get; set; }
	    public string Editora { get; set; }
	    public int Ano { get; set; }
	    public double PrecoDeVenda { get; set; }

		private ObservableCollection<Livro> livrosDoUsuario;

		public ObservableCollection<Livro> LivrosDoUsuario {
			get => App.LivrosDoUsuario;
			set {
				livrosDoUsuario = App.LivrosDoUsuario;
				Notify("LivrosDoUsuario");
			}
		}

	    public UsuarioLivroListVM() {
		    LivrosDoUsuario = App.LivrosDoUsuario;
	    }
	}
}
