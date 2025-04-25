using System;
using System.Net;
using System.Data.SqlClient;

namespace ThothDataAccess
{
    public sealed class DbAccess
    {
        private readonly SqlConnection _connection;
        public SqlCommand sqlCommand { get; set; }

        public DbAccess()
        {
            string nomeServidor = Dns.GetHostName();
            string connString = string.Format("Data Source={0};Initial Catalog=TesteThoth;Integrated Security=True;", nomeServidor);
            _connection = new SqlConnection(connString);
        }

        /// <summary>
        /// Abre a conexão com o banco de dados
        /// </summary>
        /// <returns>True = A conexão foi aberta com sucesso / False = Não foi possível abrir a conexão</returns>
        public bool OpenConnection(bool startTransaction = false)
        {
            try
            {
                if (_connection.State == System.Data.ConnectionState.Closed)
                {
                    _connection.Open();
                }

                if (startTransaction)
                {
                    _connection.BeginTransaction();
                }

                sqlCommand = new SqlCommand
                {
                    Connection = _connection,
                    CommandType = System.Data.CommandType.Text
                };
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Fecha a conexão
        /// </summary>
        /// <returns>True = A conexão foi fechada com sucesso / False = Não foi possível fechar a conexão</returns>
        public bool CloseConnection()
        {
            try
            {
                if (_connection.State == System.Data.ConnectionState.Closed)
                {
                    return true;
                }
                _connection.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Finaliza a transação, gravando os dados no banco
        /// </summary>
        /// <returns>True = A transação foi finalizada com sucesso / False = Não foi possível finalizar a transação</returns>
        public bool CommitTransaction()
        {
            try
            {
                sqlCommand.Transaction.Commit();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Finaliza a transação, abandonando toda e qualquer modificação feita nos dados do banco
        /// </summary>
        /// <returns>true = O Rollback foi executado com sucesso / False = Não foi possível completar o Rollback</returns>
        public bool RollbackTransaction()
        {
            try
            {
                sqlCommand.Transaction.Rollback();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Executa o comando solicitado no banco de dados (Update, Delete, Insert sem Identity)
        /// </summary>
        /// <returns>True = O comando foi executado com sucesso / False = Não foi possivel executar o comando ou ocorreu algum erro na execução da query</returns>
        public bool ExecuteCommand()
        {
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Executa o comando solicitado no banco de dados (Insert com Identity)
        /// </summary>
        /// <param name="generatedId">Se for uma inclusão, houver um Identity na tabela e o Insert foi executado com sucesso, retorna o ID gerado na tabela</param>
        /// <returns>True = O comando foi executado com sucesso / False = Não foi possivel executar o comando ou ocorreu algum erro na execução da query</returns>
        public bool ExecuteCommand(out int generatedId)
        {
            generatedId = 0;
            try
            {
                generatedId = Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Executa os comandos SELECT
        /// </summary>
        /// <returns>Quando executado com sucesso, devolve uma SqlDataReader / Se houver erro, retorna nulo</returns>
        public SqlDataReader ExecuteReader()
        {
            try
            {
                return sqlCommand.ExecuteReader();
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Libera os recursos não gerenciados criados pelo Strem (SqlReader)
        /// </summary>
        /// <param name="disposing">True = Libera recursos gerenciados e não gerenciados</param>
        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose managed resources
                CloseConnection();
            }
            // free native resources
        }

        /// <summary>
        /// Chama o Dipose corretamente quando a classe for encerrada
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
        }
    }
}
