using AgendaApp.Services;
using SQLite.Net.Interop;
using SQLite.Net.Platform.XamarinAndroid;
using Xamarin.Forms;

[assembly: Dependency(typeof(AgendaApp.Droid.Config))]
namespace AgendaApp.Droid {
    public class Config : IConfig {
        private string _diretorio;

        public string Diretorio => _diretorio ?? System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

        private ISQLitePlatform _plataforma;

        public ISQLitePlatform Plataforma => _plataforma ?? (_plataforma = new SQLitePlatformAndroid());
    }
}
