using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using ProdutoApp.Model;
using ProdutoApp.View;
using ProdutoApp.ViewModel;
using Xamarin.Forms;

namespace ProdutoApp {
	public partial class App: Application {

		public static ObservableCollection<Produto> ListaProdutos;
		public static ObservableCollection<Fabricante> ListaFabricantes;

		public App() {
			InitializeComponent();
			ListaProdutos = new ObservableCollection<Produto>();
			ListaFabricantes = new ObservableCollection<Fabricante>();
			MainPage = new NavigationPage(new ProdutoView());
		}

		protected override void OnStart() {
			// Handle when your app starts
		}

		protected override void OnSleep() {
			// Handle when your app sleeps
		}

		protected override void OnResume() {
			// Handle when your app resumes
		}
	}
}
