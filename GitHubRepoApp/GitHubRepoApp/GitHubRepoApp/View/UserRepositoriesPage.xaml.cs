using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitHubRepoApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GitHubRepoApp.View {
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserRepositoriesPage : ContentPage {
		public UserRepositoriesPage() {
			InitializeComponent();

			BindingContext = new UserRepositoriesVM();
		}
	}
}