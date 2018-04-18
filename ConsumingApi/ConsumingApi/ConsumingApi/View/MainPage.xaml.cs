using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsumingApi.ViewModel;
using Xamarin.Forms;

namespace ConsumingApi.View {
    public partial class MainPage {
        public MainPage() {
            InitializeComponent();

            BindingContext = new PesquisaVM();
        }
    }
}
