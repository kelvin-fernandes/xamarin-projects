using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using AgendaApp.Model;
using Xamarin.Forms;

namespace AgendaApp.ViewModel {
    public class MainPageVM : ViewModelBase {
        private ObservableCollection<Contato> _contatos;

        public ObservableCollection<Contato> Contatos {
            get => _contatos;
            set {
                _contatos = value;
                Notify("Contatos");
            }
        }

        private string _nome;

        public string Nome {
            get => _nome;
            set {
                _nome = value;
                Notify("Nome");
            }
        }

        public ICommand CadastrarCommand { get; set; }

        public MainPageVM() {
            Contatos = new ObservableCollection<Contato>();

            CadastrarCommand = new Command(Cadastro);
        }

        public void Cadastro() {
            Application.Current.MainPage.Navigation.PushAsync(new View.ContatoView());
        }
    }
}
