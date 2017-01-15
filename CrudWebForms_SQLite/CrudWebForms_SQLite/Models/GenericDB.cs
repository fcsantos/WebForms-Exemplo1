using System;
using System.Data;
using System.Data.SQLite;

namespace CrudWebForms_SQLite.Models
{
    public class GenericDB
    {
        public static DataTable LeDados<S, T>(string query) where S : IDbConnection, new() where T : IDbDataAdapter, IDisposable, new()
        {
            using (var conn = new S())
            {
                try
                {
                    using (var da = new T())
                    {
                        using (da.SelectCommand = conn.CreateCommand())
                        {
                            da.SelectCommand.CommandText = query;
                            da.SelectCommand.Connection.ConnectionString = Conexao.strConexao;
                            DataSet ds = new DataSet();
                            da.Fill(ds);
                            return ds.Tables[0];
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {                    
                    conn.Close();
                }
            }
        }

        public static DataTable LeDadosAlunoBy<S, T>(string query, SQLiteParameter[] parameters) where S : IDbConnection, new() where T : IDbDataAdapter, IDisposable, new()
        {
            using (var conn = new S())
            {
                try
                {
                    using (var da = new T())
                    {
                        using (da.SelectCommand = conn.CreateCommand())
                        {
                            da.SelectCommand.CommandText = query;
                            da.SelectCommand.Connection.ConnectionString = Conexao.strConexao;
                            foreach (var item in parameters)
                            {
                                da.SelectCommand.Parameters.Add(item);
                            }
                            DataSet ds = new DataSet();
                            da.Fill(ds);
                            return ds.Tables[0];
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public static void CrudDados<S, T>(string query, SQLiteParameter[] parameters, string tipoOP) where S : IDbConnection, new() where T : IDbDataAdapter, IDisposable, new()
        {
            using (var conn = new S())
            {
                try
                {
                    using (var da = new T())
                    {
                        if (tipoOP == "INSERT")
                        {
                            using (da.InsertCommand = conn.CreateCommand())
                            {
                                da.InsertCommand.CommandText = query;
                                da.InsertCommand.Connection.ConnectionString = Conexao.strConexao;
                                foreach (var item in parameters)
                                {
                                    da.InsertCommand.Parameters.Add(item);
                                }
                                conn.Open();
                                da.InsertCommand.Prepare();
                                var result = da.InsertCommand.ExecuteNonQuery();
                            }
                        }
                        else if (tipoOP == "DELETE")
                        {
                            using (da.DeleteCommand = conn.CreateCommand())
                            {
                                da.DeleteCommand.CommandText = query;
                                da.DeleteCommand.Connection.ConnectionString = Conexao.strConexao;
                                foreach (var item in parameters)
                                {
                                    da.DeleteCommand.Parameters.Add(item);
                                }
                                conn.Open();
                                da.DeleteCommand.Prepare();                                
                                var result = da.DeleteCommand.ExecuteNonQuery();
                            }
                        }
                        else if (tipoOP == "UPDATE")
                        {
                            using (da.UpdateCommand = conn.CreateCommand())
                            {
                                da.UpdateCommand.CommandText = query;
                                da.UpdateCommand.Connection.ConnectionString = Conexao.strConexao;
                                foreach (var item in parameters)
                                {
                                    da.UpdateCommand.Parameters.Add(item);
                                }
                                conn.Open();
                                da.UpdateCommand.Prepare();
                                var result = da.UpdateCommand.ExecuteNonQuery();
                            }
                        }                        
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {                    
                    conn.Close();
                }             
            }
        }
    }
}
