using System.Configuration;

namespace CrudWebForms_SQLite.Models
{
    public class Conexao
    {
        public static string strConexao = ConfigurationManager.ConnectionStrings["conexaoSQLite"].ConnectionString;
    }
}
