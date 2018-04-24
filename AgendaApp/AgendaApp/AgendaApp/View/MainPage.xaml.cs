using System;
using System.Diagnostics;
using AgendaApp.Model;
using AgendaApp.ViewModel;
using Xamarin.Forms;

namespace AgendaApp.View {
	public partial class MainPage {
		public MainPage() {
			InitializeComponent();
			BindingContext = new MainPageVM();
		}
	}
}
