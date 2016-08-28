using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data;

namespace Negocios
{
    public class FilialNegocios
    {

        //Instanciar = criar um novo objeto em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public FilialColecao ConsultaPorCodigo(int IDPessoaFilial)
        {
            try
            {
                FilialColecao filialColecao = new FilialColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDPessoaFilial", IDPessoaFilial);

                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspFilialConsultarPorCodigo");

                foreach (DataRow linha in dataTable.Rows)
                {
                    Filial filial = new Filial();
                    filial.Pessoa = new Pessoa();
                    filial.Pessoa.IDPessoa = Convert.ToInt32(linha["IDPessoaFilial"]);
                    filial.Pessoa.CpfCnpj = linha["CpfCnpj"].ToString();
                    filial.Pessoa.Nome = linha["Nome"].ToString();

                    filial.Pessoa.PessoaTipo = new PessoaTipo();
                    filial.Pessoa.PessoaTipo.IDPessoaTipo = Convert.ToInt32(linha["IDPessoaTipo"]);
                    filial.Pessoa.PessoaTipo.Descricao = linha["DescricaoTipo"].ToString();
                    
                    filialColecao.Add(filial);
                }

                return filialColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Pessoa Filia por Codigo. Detalhes: " + ex.Message);
            }
        }

        public FilialColecao ConsultaPorNome(string Nome)
        {
            try
            {
                FilialColecao filialColecao = new FilialColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome", Nome);

                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspFilialConsultaPorNome");

                foreach (DataRow linha in dataTable.Rows)
                {
                    Filial filial = new Filial();
                    filial.Pessoa = new Pessoa();
                    filial.Pessoa.IDPessoa = Convert.ToInt32(linha["IDPessoaFilial"]);
                    filial.Pessoa.CpfCnpj = linha["CpfCnpj"].ToString();
                    filial.Pessoa.Nome = linha["Nome"].ToString();

                    filial.Pessoa.PessoaTipo = new PessoaTipo();
                    filial.Pessoa.PessoaTipo.IDPessoaTipo = Convert.ToInt32(linha["IDPessoaTipo"]);
                    filial.Pessoa.PessoaTipo.Descricao = linha["DescricaoTipo"].ToString();
                    
                    filialColecao.Add(filial);
                }

                return filialColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Pessoa Filial por Nome. Detalhes: " + ex.Message);
            }
        }
    }
}
