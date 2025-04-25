using System;
using ThothEntity;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace ThothDataAccess
{
    public class UsuarioDal
    {
        private static readonly DbAccess dba = new DbAccess();
        private Usuario usuario;

        public bool AlterarUsuario(Usuario usuario)
        {
            string sql = string.Format("Update Usuario Set NomeUsuario = '{0}', Login = '{1}', Senha = '{2}' Where IdUsuario = {3}",
                usuario.NomeUsuario, usuario.Login, usuario.Senha, usuario.IdUsuario);

            dba.OpenConnection();
            dba.sqlCommand.CommandText = sql;
            try
            {
                dba.ExecuteCommand();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar usuário: " + ex.Message);
            }
            finally
            {
                dba.CloseConnection();
            }

            return true;
        }

        public bool ExcluirUsuario(int idUsuario)
        {
            string sql = string.Format("Delete From Usuario Where IdUsuario = {0}", idUsuario);

            dba.OpenConnection();
            dba.sqlCommand.CommandText = sql;
            try
            {
                dba.ExecuteCommand();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir usuário: " + ex.Message);
            }
            finally
            {
                dba.CloseConnection();
            }

            return true;
        }

        public int IncluirUsuario(Usuario usuario)
        {
            int novoId = 0;
            string sql = string.Format("Insert Into Usuario (NomeUsuario, Login, Senha) Values ('{0}', '{1}', '{2}')",
                usuario.NomeUsuario, usuario.Login, usuario.Senha);

            dba.OpenConnection();
            dba.sqlCommand.CommandText = sql;
            try
            {
                dba.ExecuteCommand();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir usuário: " + ex.Message);
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

        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            string sql = "Select IdUsuario, NomeUsuario, Login, Senha From Usuario";

            dba.OpenConnection();
            dba.sqlCommand.CommandText = sql;
            SqlDataReader reader = dba.ExecuteReader();
            while (reader.Read())
            {
                usuario = new Usuario
                {
                    IdUsuario = (int)reader["IdUsuario"],
                    NomeUsuario = (string)reader["NomeUsuario"],
                    Login = (string)reader["Login"],
                    Senha = (string)reader["Senha"]
                };
                usuarios.Add(usuario);
            }
            reader.Close();
            dba.CloseConnection();

            return usuarios;
        }

        public bool LoginJaExiste(string login, out int id)
        {
            id = 0;
            string sql = string.Format("Select IdUsuario From Usuario Where Login = '{0}'", login);

            dba.OpenConnection();
            dba.sqlCommand.CommandText = sql;
            SqlDataReader reader = dba.ExecuteReader();
            while (reader.Read())
            {
                id = (int)reader["IdUsuario"];
            }
            reader.Close();
            dba.CloseConnection();

            return id > 0;
        }

        public bool NomeJaExiste(object nome, out int id)
        {
            id = 0;
            string sql = string.Format("Select IdUsuario From Usuario Where NomeUsuario = '{0}'", nome);

            dba.OpenConnection();
            dba.sqlCommand.CommandText = sql;
            SqlDataReader reader = dba.ExecuteReader();
            while (reader.Read())
            {
                id = (int)reader["IdUsuario"];
            }
            reader.Close();
            dba.CloseConnection();

            return id > 0;
        }

        public int ObterIdUsuario(string login)
        {
            int idUsuario = 0;
            string sql = string.Format("Select IdUsuario From Usuario Where Login = '{0}'", login);

            dba.OpenConnection();
            dba.sqlCommand.CommandText = sql;
            SqlDataReader reader = dba.ExecuteReader();
            while (reader.Read())
            {
                idUsuario = (int)reader["IdUsuario"];
            }
            reader.Close();
            dba.CloseConnection();

            return idUsuario;
        }

        public string ObterSenha(int idUsuario)
        {
            string senha = string.Empty;
            string sql = string.Format("Select Senha From Usuario Where IdUsuario = {0}", idUsuario);

            dba.OpenConnection();
            dba.sqlCommand.CommandText = sql;
            SqlDataReader reader = dba.ExecuteReader();
            while (reader.Read())
            {
                senha = (string)reader["Senha"];
            }
            reader.Close();
            dba.CloseConnection();

            return senha;
        }

        public bool ValidarSenha(int idUsuario, string senha, out string nome)
        {
            bool senhaValida = false;

            nome = null;
            string sql = string.Format("Select NomeUsuario From Usuario Where IdUsuario = {0} And Senha = '{1}'", idUsuario, senha);

            dba.OpenConnection();
            dba.sqlCommand.CommandText = sql;
            SqlDataReader reader = dba.ExecuteReader();
            while (reader.Read())
            {
                senhaValida = true;
                nome = (string)reader["NomeUsuario"];
            }
            reader.Close();
            dba.CloseConnection();
            
            return senhaValida;
        }
    }
}
