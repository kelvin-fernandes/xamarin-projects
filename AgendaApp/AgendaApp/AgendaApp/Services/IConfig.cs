using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Interop;

namespace AgendaApp.Services {
    public interface IConfig {
        ISQLitePlatform Plataforma { get; }
        string Diretorio { get; }
    }
}
