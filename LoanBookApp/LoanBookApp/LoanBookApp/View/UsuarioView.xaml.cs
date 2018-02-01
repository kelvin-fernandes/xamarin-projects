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
	public partial class UsuarioView: ContentPage {
		public UsuarioView() {
			InitializeComponent();
			BindingContext = new UsuarioVM();

			listaUsuarios.ItemTapped += (sender, e) => {
				Usuario usuario = (Usuario) e.Item;
				BindingContext = new UsuarioVM(usuario);
			};
		}
	}
}