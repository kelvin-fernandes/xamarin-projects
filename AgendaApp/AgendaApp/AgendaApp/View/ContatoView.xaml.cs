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
	}
}