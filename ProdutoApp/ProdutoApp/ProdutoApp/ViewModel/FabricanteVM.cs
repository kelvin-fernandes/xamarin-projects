using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ProdutoApp.Model;
using Xamarin.Forms;

namespace ProdutoApp.ViewModel {
	public class FabricanteVM : ViewModelBase {

		private int codigo;

		public int Codigo {
			get => codigo;
			set {
				codigo = value;
				Notify("Codigo");
			}
		}

		private string nome;

		public string Nome {
			get => nome;
			set {
				nome = value;
				Notify("Nome");
			}
		}

		private ObservableCollection<Fabricante> fabricantes;

		public ObservableCollection<Fabricante> Fabricantes {
			get => fabricantes;
			set {
				fabricantes = value;
				Notify("Fabricantes");
			}
		}

		public ICommand Salvar { get; set; }

		public FabricanteVM() {
			Salvar = new Command(InserirFabricante);
			Fabricantes = new ObservableCollection<Fabricante>();
		}

		public FabricanteVM(ObservableCollection<Fabricante> fabricantes) : this() {
			Fabricantes = fabricantes;
		}

		public void InserirFabricante() {
			Fabricantes.Add(new Fabricante {Codigo = this.Codigo, Nome = this.Nome});
			//Fabricantes.Add(new Fabricante {Codigo = this.Codigo, Nome = this.Nome});
			LimparCampos();
		}

		private void LimparCampos() {
			Codigo = 0;
			Nome = "";
		}
	}
}
