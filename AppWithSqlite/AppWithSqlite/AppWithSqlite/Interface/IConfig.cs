namespace AppWithSqlite.Interface {
    public interface IConfig {
        string DiretorioDB { get; }
        ISQLitePlatform Plataforma { get; }
    }
}
