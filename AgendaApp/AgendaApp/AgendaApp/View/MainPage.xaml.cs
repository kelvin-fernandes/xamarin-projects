using AgendaApp.ViewModel;

namespace AgendaApp.View {
	public partial class MainPage {
		public MainPage() {
			InitializeComponent();

			BindingContext = new MainPageVM();
		}
	}
}
