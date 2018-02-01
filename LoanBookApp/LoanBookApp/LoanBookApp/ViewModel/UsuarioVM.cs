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

		private string usuario;

		public string Usuario {
			get => (usuario != null && !usuario.Equals(String.Empty)) ? usuario.ToUpper() : usuario;
			set {
				usuario = value;
				Notify("Usuario");
			}
		}

		private ObservableCollection<Usuario> usuarios;

		public ObservableCollection<Usuario> Usuarios {
			get => App.ListaUsuarios;
			set {
				usuarios = App.ListaUsuarios;
				Notify("Usuarios");
			}
		}
		
		private ObservableCollection<Livro> livrosDoUsuario;

		public ObservableCollection<Livro> LivrosDoUsuario {
			get => livrosDoUsuario;
			set {
				livrosDoUsuario = value;
				Notify("LivrosDoUsuario");
			}
		}

		private ObservableCollection<Livro> livros;

		public ObservableCollection<Livro> Livros {
			get => App.ListaLivros;
			set {
				livros = App.ListaLivros;
				Notify("TodosOsLivros");
			}
		}

		public ICommand Salvar { get; set; }
		public ICommand AbrirLivrosUsuario { get; set; }
		public ICommand TodosOsLivros { get; set; }
		
		public UsuarioVM() {
			Usuarios = new ObservableCollection<Usuario>();
			LivrosDoUsuario = new ObservableCollection<Livro>();
			Livros = App.ListaLivros;

			Salvar = new Command(SalvarCommand);
			AbrirLivrosUsuario = new Command(AbrirLivrosAction);
			TodosOsLivros = new Command(TodosOsLivrosAction);

			Usuario = "Escolha um Usuário";
		}

		public UsuarioVM(Usuario _usuario) : this() {
			Usuario = _usuario.Nome;
		}

		private void SalvarCommand() {
			if (VerificarCampos()) {
				Usuario novoUsuario = new Usuario {
					Nome = Nome,
					Telefone = Telefone,
					Endereco = Endereco
				};
				App.ListaUsuarios.Add(novoUsuario);
				LimparCampos();
			}
			else {
				//TODO Show message like 'Toast' on Android
			}
		}

		private async void AbrirLivrosAction() {
			if(VerificarUsuario())
				await Application.Current.MainPage.Navigation.PushAsync(new UsuarioLivroListView(){Title = Usuario});
			//else
				//TODO Show message like 'Toast' on Android
		}

		private async void TodosOsLivrosAction() {
			if(VerificarUsuario())
				await Application.Current.MainPage.Navigation.PushAsync(new LivroView(true));
			//else
				//TODO Show message like 'Toast' on Android
		}

		private bool VerificarUsuario() {
			if (!Usuario.Equals(String.Empty) && !Usuario.Equals("Escolha um Usuário".ToUpper()))
				return true;

			return false;
		}

		private bool VerificarCampos() {
			if(Nome != null && Telefone != null && Endereco != null)
				if (Nome.Length > 0 && Telefone.Length > 0 && Endereco.Length > 0)
					return true;

			return false;
		}

		private void LimparCampos() {
			Nome = "";
			Telefone = "";
			Endereco = "";
		}
	}
}
