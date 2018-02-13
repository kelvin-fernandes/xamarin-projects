using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GitHubRepoApp.View;
using Xamarin.Forms;

namespace GitHubRepoApp {
    public partial class App : Application {
        public App() {
            InitializeComponent();

			//DOING LAYOUT IN C#
            //StackLayout stackLayout = new StackLayout { Padding = 20, Spacing = 20 };
            //Entry user = new Entry { Placeholder = "User"};
            //Button btnSearch = new Button { Text = "Search"};
            //ListView lstRepositories = new ListView();
            //stackLayout.Children.Add(user);
            //stackLayout.Children.Add(btnSearch);
            //stackLayout.Children.Add(lstRepositories);

            //btnSearch.Clicked += async (e, sender) => {
            //    lstRepositories.ItemsSource = await new GitHubApi().GetAsync(user.Text);
            //};

            //MainPage = new ContentPage {
            //    Content = stackLayout
            //};

			//CALLING VIEW WITH THE LAYOUT
            //MainPage = new MainPage();

			//CALLING VIEW WITH VIEWMODEL SCHEME
			MainPage = new UserRepositoriesPage();
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
