using System;
using System.Data;
using System.Data.SQLite;

namespace CrudWebForms_SQLite.Models
{
    public class AlunoDB
    {
        public static DataTable Select()
        {
            string sql = "SELECT * FROM Aluno";
            return GenericDB.LeDados<SQLiteConnection, SQLiteDataAdapter>(sql);
        }

        public static void Insert(string[] parameters)
        {
            string sql = "INSERT INTO Aluno (nome, email, idade) VALUES (@nome, @email, @idade)";
            SQLiteParameter[] p = new SQLiteParameter[3];
            p[0] = new SQLiteParameter("@nome", parameters[0]);
            p[1] = new SQLiteParameter("@email", parameters[1]);
            p[2] = new SQLiteParameter("@idade", Convert.ToInt32(parameters[2]));
            GenericDB.CrudDados<SQLiteConnection, SQLiteDataAdapter>(sql, p, "INSERT");
        }

        public static DataTable SelectById(string codigo)
        {
            string sql = "SELECT * FROM Aluno WHERE id = @id";
            SQLiteParameter[] p = new SQLiteParameter[1];
            p[0] = new SQLiteParameter("@id", Convert.ToInt32(codigo));
            return GenericDB.LeDadosAlunoBy<SQLiteConnection, SQLiteDataAdapter>(sql, p);
        }

        public static void Delete(string[] parameters)
        {
            string sql = "DELETE FROM Aluno WHERE id = @id";
            SQLiteParameter[] p = new SQLiteParameter[1];
            p[0] = new SQLiteParameter("@id", Convert.ToInt32(parameters[0]));
            GenericDB.CrudDados<SQLiteConnection, SQLiteDataAdapter>(sql, p, "DELETE");
        }

        public static void Update(string[] parameters)
        {
            string sql = "UPDATE Aluno SET nome = @nome, email = @email, idade = @idade where id = @id";
            SQLiteParameter[] p = new SQLiteParameter[4];
            p[0] = new SQLiteParameter("@id", Convert.ToInt32(parameters[0]));
            p[1] = new SQLiteParameter("@nome", parameters[1]);
            p[2] = new SQLiteParameter("@email", parameters[2]);
            p[3] = new SQLiteParameter("@idade", Convert.ToInt32(parameters[3]));
            GenericDB.CrudDados<SQLiteConnection, SQLiteDataAdapter>(sql, p, "UPDATE");
        }
    }
}
