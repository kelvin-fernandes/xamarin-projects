using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using LoanBookApp.Model;
using LoanBookApp.View;
using ProdutoApp.ViewModel;
using Xamarin.Forms;

namespace LoanBookApp.ViewModel {
	public class UsuarioVM : ViewModelBase{

		private string nome;

		public string Nome {
			get => nome;
			set {
				nome = value;
				Notify("Nome");
			}
		}

		private string telefone;

		public string Telefone {
			get => telefone;
			set {
				telefone = value;
				Notify("Telefone");
			}
		}

		private string endereco;

		public string Endereco {
			get => endereco;
			set {
				endereco = value;
				Notify("Endereco");
			}
		}

		private ObservableCollection<Usuario> usuarios;

		public ObservableCollection<Usuario> Usuarios {
			get { return App.ListaUsuarios; }
			set {
				Usuarios = App.ListaUsuarios;
				Notify("ListaUsuarios");
			}
		}

		public ICommand AbrirLivros { get; set; }
		
		public UsuarioVM() {
			Usuarios = App.ListaUsuarios;

			AbrirLivros = new Command(AbrirLivrosAction);
		}

		private async void AbrirLivrosAction() {
			await Application.Current.MainPage.Navigation.PushAsync(new UsuarioLivroListView());
		}
	}
}
