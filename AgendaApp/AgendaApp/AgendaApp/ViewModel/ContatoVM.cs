using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using AgendaApp.Model;
using AgendaApp.Repository;
using AgendaApp.View;
using Xamarin.Forms;

namespace AgendaApp.ViewModel {
    public class ContatoVM : ViewModelBase {
        private string _nome;

        public string Nome {
            get => _nome;
            set {
                _nome = value;
                Notify("Nome");
            }
        }

        private string _celular;

        public string Celular {
            get => _celular;
            set {
                _celular = value;
                Notify("Celular");
            }
        }

        private string _email;

        public string Email {
            get => _email;
            set {
                _email = value;
                Notify("Email");
            }
        }

        public ICommand SalvarCommand { get; set; }

        public ContatoVM() {
            SalvarCommand = new Command(SalvarContato);
        }

        public void SalvarContato() {
            if (!string.IsNullOrEmpty(Nome)    &&
                !string.IsNullOrEmpty(Celular) &&
                !string.IsNullOrEmpty(Email)) {
                using (var dados = new ContatoRepository()) {
                    Contato contato = new Contato {
                        Nome    = Nome,
                        Celular = Celular,
                        Email   = Email
                    };

                    dados.Insert(contato);

                    Application.Current.MainPage.DisplayAlert("Contato", "Informações inseridas com sucesso!", "OK");
                    Application.Current.MainPage = new NavigationPage(new MainPage()) { BarBackgroundColor = Color.Green };
                }

                return;
            }

            Application.Current.MainPage.DisplayAlert("Contato", "Preencha todos os campos!", "OK");
        }
    }
}
