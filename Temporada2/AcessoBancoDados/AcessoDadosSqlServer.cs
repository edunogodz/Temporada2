using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.SqlClient;


namespace AcessoBancoDados
{
    public class AcessoDadosSqlServer
    {
        //Criar a Conexao
        private SqlConnection CriarConexao()
        {
            string strPass = "Senha do Banco";
            return new SqlConnection(@"Data Source=NOGODZ\SQLEXPRESS;Initial Catalog=NomedoBanco;User ID=sa;Password='" + strPass + "'");            
            //return new SqlConnection(Settings.Default.stringConexao);
        }

        //Parametros que vao para o banco
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }

        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }

        //Persistencia -Inserir., Alterar, Excluir
        public object ExecutarManipulacao(CommandType commandType, String nomeStoredProcedureOuTextoSql)
        {
            try
            {
                //Criar a conexao
                SqlConnection sqlConnection = CriarConexao();
                //abrir conexao
                sqlConnection.Open();
                //criar o comando que vai levar a informação para o banco
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //Colocando as coisas dentro do comando (dentro da caia que vai trafegar na conexao)
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200;//Em segundos

                //Adicionar os parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        
        //Consultar registros do banco de dados
        public DataTable ExecutarConsulta(CommandType commandType, String nomeStoredProcedureOuTextoSql)
        {
            try
            {
                //Criar a conexao
                SqlConnection sqlConnection = CriarConexao();
                //abrir conexao
                sqlConnection.Open();
                //criar o comando que vai levar a informação para o banco
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //Colocando as coisas dentro do comando (dentro da caia que vai trafegar na conexao)
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200;//Em segundos

                //Adicionar os parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //criar um adaptador
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                //Datatable = Tabela de dados vazia onde vou colocar os dados que vem do banco
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                return dataTable;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
