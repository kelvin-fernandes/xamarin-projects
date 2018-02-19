namespace AppWithSqlite.Model {
	public class Contato {
		public int Id { get; set; }

		public string Nome { get; set; }

		public string Email { get; set; }

		public string Telefone { get; set; }

		public override string ToString() {
			return $"Nome = {Nome} | Email = {Email} | Telefone = {Telefone}";
		}
	}
}
