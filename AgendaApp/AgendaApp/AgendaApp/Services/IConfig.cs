using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Interop;

namespace AgendaApp.Services {
    public class IConfig {
        public ISQLitePlatform Plataforma { get; set; }
        public string Diretorio { get; set; }
    }
}
