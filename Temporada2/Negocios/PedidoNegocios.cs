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
    public class PedidoNegocios
    {
        //Instanciar = criar um novo objeto em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Pedido pedido)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDOperacao", pedido.Operacao.IDOperacao);
                acessoDadosSqlServer.AdicionarParametros("@IDSituacao", pedido.Situacao.IDSituacao);
                acessoDadosSqlServer.AdicionarParametros("@IDPessoaEmitente", pedido.Emitente.IDPessoa);
                acessoDadosSqlServer.AdicionarParametros("@IDPessoaDestinatario", pedido.Destinatario.IDPessoa);
                string idPedido = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPedidoInserir").ToString();
                return idPedido;
            }
            catch (Exception exception)
            {

                return exception.Message;
            }

        }

        public PedidoColecao ConsultaPorData(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                PedidoColecao pedidoColecao = new PedidoColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@DataInicial", dataInicial);
                acessoDadosSqlServer.AdicionarParametros("@DataFinal", dataFinal);
                          
                DataTable dataTablePedido = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspPedidoConsultarPorData");

                foreach (DataRow linha in dataTablePedido.Rows)
                {
                    Pedido pedido = new Pedido();
                    pedido.IDPedido = Convert.ToInt32(linha["IDPedido"]);
                    pedido.DataHora = Convert.ToDateTime(linha["DataHora"]);

                    pedido.Operacao = new Operacao();
                    pedido.Operacao.IDOperacao = Convert.ToInt32(linha["IDOperacao"]);
                    pedido.Operacao.Descricao = linha["DescOperacao"].ToString();

                    pedido.Situacao = new Situacao();
                    pedido.Situacao.IDSituacao = Convert.ToInt32(linha["IDSituacao"]);
                    pedido.Situacao.Descricao = linha["DescSituacao"].ToString();

                    pedido.Emitente = new Pessoa();
                    pedido.Emitente.IDPessoa = Convert.ToInt32(linha["IDPessoaEmitente"]);
                    pedido.Emitente.Nome = linha["NomeEmitente"].ToString();

                    pedido.Destinatario = new Pessoa();
                    pedido.Destinatario.IDPessoa = Convert.ToInt32(linha["IDPessoaDestinatario"]);
                    pedido.Destinatario.Nome = linha["NomeDestinatario"].ToString();                    
                    pedidoColecao.Add(pedido);
                }

                return pedidoColecao;


            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar pedido por data. Detalhes: " + ex.Message);
            }
        }
    }
}
