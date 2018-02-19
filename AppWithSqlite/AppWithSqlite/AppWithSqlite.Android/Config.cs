//using SQLite.Net.Interop;
//using SQLite.Net.Platform.XamarinAndroid;
//using AppWithSqlite.Interface;
using Xamarin.Forms;

//SPECIFYING THE EACH WAY PLATAFORM TO ACCESS DATA
[assembly: Dependency(typeof(AppWithSqlite.Droid.Config))]
namespace AppWithSqlite.Droid {
    public class Config {
        private string _diretorioDB;

        public string DiretorioDB
        {
            get {
                if (string.IsNullOrEmpty(_diretorioDB))
                    _diretorioDB = System.Environment.SpecialFolder.Personal.ToString();
                return _diretorioDB;
            }
        }

        //private ISQLitePlatform _plataforma;

        //public ISQLitePlatform Plataforma => _plataforma ?? (_plataforma = new SQLitePlatformAndroid());
    }
}
