using System.Collections.Generic;
using AgendaApp.Model;

namespace AgendaApp.Repository {
    public class ContatoRepository : Repository<Contato> {
        public IEnumerable<Contato> GetAll() {
            return Connection.Table<Contato>();
        }
    }
}
