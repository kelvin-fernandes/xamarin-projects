using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ProdutoApp.Annotations;

namespace ProdutoApp.ViewModel {
    public abstract class ViewModelBase : INotifyPropertyChanged {
	    public event PropertyChangedEventHandler PropertyChanged;

	    protected void Notify(String property) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
    }
}
