using System;
using System.Collections.Generic;
using System.Linq;
using AppWithSqlite.Interface;
using AppWithSqlite.Model;
using Xamarin.Forms;

namespace AppWithSqlite {
    public class AcessoDados : IDisposable {
        //private SQLiteConnection _connection;

        //public AcessoDados() {
        //    var config = DependencyService.Get<IConfig>();
        //    _connection = new SQLiteConnection(config.Plataforma, System.IO.Path.Combine(config.DiretorioDB, "bancodados.db3"));
        //    _connection.CreateCommand("CREATE TABLE CONTATO {" +
        //                              "    [Id] INT IDENTITY PRIMARY KEY," +
        //                              "    [Nome] VARCHAR(100)," +
        //                              "    [Email] VARCHAR(100)," +
        //                              "    [Telefone] VARCHAR(15)" +
        //                              "}");
        //}

        //public void Insert(Contato contato) {
        //    _connection.CreateCommand($"INSERT INTO CONTATO (Nome, Email, Telefone) VALUES ('{contato.Nome}', '{contato.Email}', '{contato.Telefone}')");
        //}

        //public void Update(Contato contato) {
        //    _connection.CreateCommand($"UPDATE CONTATO SET Nome = '{contato.Nome}', Email = '{contato.Email}', Telefone = '{contato.Telefone}' WHERE Id = {contato.Id}");
        //}

        //public void Delete(Contato contato) {
        //    _connection.CreateCommand($"DELETE FROM CONTATO WHERE Id = {contato.Id}");
        //}

        //public Contato ObterPorId(int id) {
        //    return _connection.CreateCommand($"SELECT * FROM CONTATO WHERE Id = {id}");
        //}

        //public List<Contato> Listar() {
        //    return _connection.CreateCommand("SELECT * FROM CONTATO ORDER BY Id");
        //}

        public void Dispose() {
            //_connection.Dispose();
        }
    }
}
