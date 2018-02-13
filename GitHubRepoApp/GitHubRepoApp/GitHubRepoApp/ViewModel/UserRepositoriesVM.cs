using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace GitHubRepoApp.ViewModel {
	public class UserRepositoriesVM : INotifyPropertyChanged{
		public event PropertyChangedEventHandler PropertyChanged;

		private string _user;

		public string User {
			get => _user;
			set {
				_user = value;
				BtnSearchEnabled = User.Length > 0;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("User"));
			}
		}

		private List<string> _repositoriesList;

		public List<string> RepositoriesList {
			get => _repositoriesList;
			set {
				_repositoriesList = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RepositoriesList"));
			}
		}

		private bool _btnSearchEnabled;

		public bool BtnSearchEnabled {
			get => _btnSearchEnabled;
			set { 
				_btnSearchEnabled = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BtnSearchEnabled"));
			}
		}

		public ICommand SearchCommand { get; set; }

		public UserRepositoriesVM() {
			RepositoriesList = new List<string>();
			BtnSearchEnabled = false;
			SearchCommand = new Command(SearchAction);
		}
		
		private async void SearchAction() {
			RepositoriesList = await new GitHubApi().GetAsync(User);
		}
	}
}
