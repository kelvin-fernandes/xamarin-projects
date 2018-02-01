using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanBookApp.Model;
using LoanBookApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoanBookApp.View {
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LivroView: ContentPage {
		public LivroView() {
			InitializeComponent();
			BindingContext = new LivroVM();
		}

		public LivroView(bool veioDeUsuarioView) : this() {
			if (veioDeUsuarioView) {
				listaLivros.ItemTapped += (sender, e) => {
					Livro livro = (Livro) e.Item;
					App.LivrosDoUsuario.Add(livro);
					Application.Current.MainPage.Navigation.PopAsync();
					Application.Current.MainPage.Navigation.PushAsync(new UsuarioLivroListView());
				};
			}
		}
	}
}