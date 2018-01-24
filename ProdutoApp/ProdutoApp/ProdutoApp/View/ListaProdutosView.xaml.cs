using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProdutoApp.Model;
using ProdutoApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProdutoApp.View {
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaProdutosView: ContentPage {
		public ListaProdutosView(ObservableCollection<Produto> listaProdutos) {
			InitializeComponent();
			BindingContext = new ListaProdutosVM(listaProdutos);
		}
	}
}