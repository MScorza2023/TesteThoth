using System;
using ThothEntity;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;

namespace ThothDataAccess
{
    public class CompromissoDal
    {
        private static readonly DbAccess dba = new DbAccess();
        private Compromisso compromisso;

        public bool AlterarCompromisso(Compromisso compromisso)
        {
            string sql = String.Format("Update Compromisso " +
                                       "Set HorarioInicial = '{0}', HorarioFinal = '{1}', " +
                                       "DiaInteiro = {2}, Descricao = '{3}', Local = '{4}' " +
                                       "Where IdCompromisso = {5} And IdUsuario = {6} ",
                                       compromisso.HorarioInicial,
                                       compromisso.HorarioFinal,
                                       Convert.ToInt32(compromisso.DiaTodo),
                                       compromisso.Descricao,
                                       compromisso.Local,
                                       compromisso.IdCompromisso,
                                       compromisso.Usuario.IdUsuario);

            dba.OpenConnection();
            dba.sqlCommand.CommandText = sql;
            try
            {
                dba.ExecuteCommand();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar compromisso: " + ex.Message);
            }
            finally
            {
                dba.CloseConnection();
            }

            return true;
        }

        public bool ExcluirCompromisso(int idUsuario, int idCompromisso)
        {
            string sql = string.Format("Delete From Compromisso " +
                                       "Where IdCompromisso = {0} " +
                                       "And IdUsuario = {1} ",
                                       idCompromisso,
                                       idUsuario);

            dba.OpenConnection();
            dba.sqlCommand.CommandText = sql;
            try
            {
                dba.ExecuteCommand();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir compromisso: " + ex.Message);
            }
            finally
            {
                dba.CloseConnection();
            }

            return true;
        }

        public bool ExisteCompromisso(int idUsuario, string dataAgenda, int idCompromisso)
        {
            bool existe = false;
            string sql = string.Format("Select 1 From Compromisso " +
                                       "Where IdUsuario = {0} " +
                                       "And IdCompromisso <> {2} " +
                                       "And Convert(DateTime, DataCompromisso, 112) = '{1}' ",
                                       idUsuario,
                                       dataAgenda.Substring(0, 4) + dataAgenda.Substring(4, 2) + dataAgenda.Substring(6, 2),
                                       idCompromisso);

            dba.OpenConnection();
            dba.sqlCommand.CommandText = sql;
            SqlDataReader reader = dba.ExecuteReader();
            while (reader.Read())
            {
                existe = true;
            }
            reader.Close();
            dba.CloseConnection();

            return existe;
        }

        public int InserirCompromisso(Compromisso compromisso)
        {
            int novoId = 0;
            string sql = string.Format("Insert Into Compromisso (IdUsuario, DataCompromisso, HorarioInicial, " +
                                       "HorarioFinal, DiaInteiro, Descricao, Local) " +
                                       "Values ({0}, Convert(DateTime, '{1}', 112), '{2}', '{3}', {4}, '{5}', '{6}')",
                                       compromisso.Usuario.IdUsuario,
                                       compromisso.Data.ToString("yyyyMMdd"),
                                       compromisso.HorarioInicial,
                                       compromisso.HorarioFinal,
                                       Convert.ToInt32(compromisso.DiaTodo),
                                       compromisso.Descricao,
                                       compromisso.Local);

            dba.OpenConnection();
            dba.sqlCommand.CommandText = sql;
            try
            {
                dba.ExecuteCommand();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir compromisso: " + ex.Message);
            }

            sql = "SELECT ID = SCOPE_IDENTITY();";
            dba.sqlCommand.CommandText = sql;
            SqlDataReader reader = dba.ExecuteReader();
            while (reader.Read())
            {
                novoId = Convert.ToInt32(reader["ID"]);
            }
            reader.Close();
            dba.CloseConnection();

            return novoId;
        }

        public List<Compromisso> ListarCompromissos(int idUsuario, string dataAgenda)
        {
            List<Compromisso> compromissos = new List<Compromisso>();
            string sql = string.Format("Select IdUsuario, IdCompromisso, DataCompromisso, HorarioInicial, " +
                                       "HorarioFinal, DiaInteiro, Descricao, Local " +
                                       "From Compromisso " +
                                       "Where IdUsuario = {0} " +
                                       "And Convert(Char(8), DataCompromisso, 112) = '{1}' ",
                                       idUsuario,
                                       dataAgenda.Substring(0, 4) + dataAgenda.Substring(4, 2) + dataAgenda.Substring(6, 2));

            dba.OpenConnection();
            dba.sqlCommand.CommandText = sql;
            SqlDataReader reader = dba.ExecuteReader();

            while (reader.Read())
            {
                Usuario usuario = new Usuario
                {
                    IdUsuario = Convert.ToInt32(reader["IdUsuario"])
                };

                compromisso = new Compromisso
                {
                    Usuario = usuario,
                    IdCompromisso = Convert.ToInt32(reader["IdCompromisso"]),
                    Data = Convert.ToDateTime(reader["DataCompromisso"]),
                    HorarioInicial = reader["HorarioInicial"].ToString(),
                    HorarioFinal = reader["HorarioFinal"].ToString(),
                    DiaTodo = Convert.ToInt32(reader["DiaInteiro"]) == 0 ? true : false,
                    Descricao = reader["Descricao"].ToString(),
                    Local = reader["Local"].ToString()
                };
                compromissos.Add(compromisso);
            }
            reader.Close();
            dba.CloseConnection();

            return compromissos;
        }
    }
}
