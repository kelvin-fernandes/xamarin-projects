using AgendaApp.Model;
using AgendaApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgendaApp.View {
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContatoView : ContentPage {
		public ContatoView() {
			InitializeComponent();

			BindingContext = new ContatoVM();
		}

		public ContatoView(Contato c) : this(){
			BindingContext = new ContatoVM(c);
		}
	}
}