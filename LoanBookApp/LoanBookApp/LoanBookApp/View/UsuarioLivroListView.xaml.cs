﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanBookApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoanBookApp.View {
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UsuarioLivroListView: ContentPage {
		public UsuarioLivroListView() {
			InitializeComponent();

			BindingContext = new UsuarioLivroListVM();
		}
	}
}