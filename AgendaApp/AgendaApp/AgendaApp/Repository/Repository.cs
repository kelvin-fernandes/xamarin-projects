using System;
using SQLite.Net;
using Xamarin.Forms;

namespace AgendaApp.Repository {
    public class Repository<T> : IDisposable {
        public SQLiteConnection Connection { get; set; }

        public Repository() {
            var config = DependencyService.Get<Services.IConfig>();
            Connection = new SQLiteConnection(config.Plataforma, System.IO.Path.Combine(config.Diretorio, "banco-agenda.db3"));
            Connection.CreateTable<T>();
        }
        
        public void Insert(T objeto) {
            Connection.Insert(objeto);
        }

        public void Update(T objeto) {
            Connection.Update(objeto);
        }

        public void Delete(T objeto) {
            Connection.Delete(objeto);
        }

        public void Dispose() {
            Connection.Dispose();
        }
    }
}
