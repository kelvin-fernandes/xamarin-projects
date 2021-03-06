﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using LoanBookApp.Model;
using LoanBookApp.View;
using Xamarin.Forms;

namespace LoanBookApp {
	public partial class App: Application {

		public static ObservableCollection<Usuario> ListaUsuarios { get; set; }
		public static ObservableCollection<Livro> ListaLivros { get; set; }
		public static ObservableCollection<Livro> LivrosDoUsuario { get; set; }

		public App() {
			InitializeComponent();

			ListaUsuarios = new ObservableCollection<Usuario>();
			ListaLivros = new ObservableCollection<Livro>();
			LivrosDoUsuario = new ObservableCollection<Livro>();
			MainPage = new NavigationPage(new MainView());
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
