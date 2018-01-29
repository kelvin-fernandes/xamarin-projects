using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using LoanBookApp.View;
using Xamarin.Forms;

namespace LoanBookApp.ViewModel {
	public class MainVM {

		public ICommand MostrarUsuarios { get; set; }

		public ICommand MostrarLivros { get; set; }

		public MainVM() {
			MostrarUsuarios = new Command(MostrarUsuariosAction);
			MostrarLivros = new Command(MostrarLivrosAction);
		}

		private async void MostrarUsuariosAction() {
			await Application.Current.MainPage.Navigation.PushAsync(new UsuarioView());
		}

		private async void MostrarLivrosAction() {
			await Application.Current.MainPage.Navigation.PushAsync(new LivroView());
		}
	}
}
