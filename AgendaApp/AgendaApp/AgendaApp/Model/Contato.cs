using SQLite.Net.Attributes;

namespace AgendaApp.Model {
    public class Contato {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Celular { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
