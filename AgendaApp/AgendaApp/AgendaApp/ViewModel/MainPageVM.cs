using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using AgendaApp.Model;
using AgendaApp.Repository;
using AgendaApp.View;
using Xamarin.Forms;

namespace AgendaApp.ViewModel {
    public class MainPageVM : ViewModelBase {
        private readonly ContatoRepository contatoRepository = new ContatoRepository();

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

        public ICommand EditarCommand { get; set; }

        public ICommand ExcluirCommand { get; set; }

        public MainPageVM() {
            Contatos = new ObservableCollection<Contato>(contatoRepository.GetAll());

            CadastrarCommand = new Command(CadastroAction);
            EditarCommand    = new Command<Contato>(EditarAction);
            ExcluirCommand   = new Command<Contato>(ExcluirAction);
        }

        public void CadastroAction() {
            Application.Current.MainPage.Navigation.PushAsync(new View.ContatoView());
        }

        public void EditarAction(Contato c) {
            Application.Current.MainPage.Navigation.PushAsync(new View.ContatoView(c));
        }

        public async void ExcluirAction(Contato c) {
            var result = await Application.Current.MainPage.DisplayAlert("Excluir",
                $"Deseja excluir o contato {c.Nome} - {c.Celular}?", "Sim", "Não");
            if (result) {
                using (var dados = new ContatoRepository()) {
                    dados.Delete(c);

                    await Application.Current.MainPage.DisplayAlert("Contato", "Contato excluído com sucesso!", "OK");
                    Application.Current.MainPage = new NavigationPage(new MainPage()) {BarBackgroundColor = Color.Green};
                }
            }
        }
    }
}