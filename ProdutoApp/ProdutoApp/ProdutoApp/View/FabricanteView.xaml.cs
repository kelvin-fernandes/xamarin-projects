using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProdutoApp.Model;
using ProdutoApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProdutoApp.View {
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FabricanteView: ContentPage {
		public FabricanteView() {
			InitializeComponent();
			BindingContext = new FabricanteVM();

			listaFornecedor.ItemTapped += (sender, e) => {
				Fabricante fabricante = (Fabricante) e.Item;
				Application.Current.MainPage = new NavigationPage(new ProdutoView(fabricante));
			};
		}
	}
}