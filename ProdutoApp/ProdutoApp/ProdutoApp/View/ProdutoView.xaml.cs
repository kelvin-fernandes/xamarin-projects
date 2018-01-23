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
	public partial class ProdutoView: ContentPage {
		public ProdutoView() {
			InitializeComponent();
			BindingContext = new ProdutoVM();
		}

		public ProdutoView(Fabricante fabricante) {
			InitializeComponent();
			BindingContext = new ProdutoVM(fabricante);
		}
	}
}