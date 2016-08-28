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
    public class PedidoItemNegocios
    {
        //Instanciar = criar um novo objeto em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(PedidoItem pedidoItem)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDPedido", pedidoItem.Pedido.IDPedido);
                acessoDadosSqlServer.AdicionarParametros("@IDProduto", pedidoItem.Produto.IDProduto);
                acessoDadosSqlServer.AdicionarParametros("@Quantidade", pedidoItem.Quantidade);
                acessoDadosSqlServer.AdicionarParametros("@ValorUnitario", pedidoItem.ValorUnitario);
                acessoDadosSqlServer.AdicionarParametros("@PercentualDesconto", pedidoItem.Quantidade);
                acessoDadosSqlServer.AdicionarParametros("@ValorDesconto", pedidoItem.ValorUnitario);
                acessoDadosSqlServer.AdicionarParametros("@ValorTotal", pedidoItem.ValorUnitario);
                string idPedido = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPedidoItemInserir").ToString();
                return idPedido;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public PedidoItemColecao Consultar(int idPedido)
        {
            try
            {
                PedidoItemColecao pedidoItemColecao = new PedidoItemColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDPedido", idPedido);

                DataTable dataTableItemPedido = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspPedidoItemConsultar");

                foreach (DataRow linha in dataTableItemPedido.Rows)
                {
                    PedidoItem pedidoItem = new PedidoItem();

                    pedidoItem.Pedido = new Pedido();
                    pedidoItem.Pedido.IDPedido = Convert.ToInt32(linha["IDPedido"]);
                    
                    pedidoItem.Produto = new Produto();
                    pedidoItem.Produto.IDProduto = Convert.ToInt32(linha["IDProduto"]);
                    pedidoItem.Produto.Descricao = linha["DescProduto"].ToString();
                    
                    pedidoItem.Quantidade = Convert.ToInt32(linha["Quantidade"]);
                    pedidoItem.ValorUnitario = Convert.ToDecimal(linha["ValorUnitario"]);
                    pedidoItem.PercentualDesconto = Convert.ToDecimal(linha["PercentualDesconto"]);
                    pedidoItem.ValorDesconto = Convert.ToDecimal(linha["ValorDesconto"]);
                    pedidoItem.ValorTotal = Convert.ToDecimal(linha["ValorTotal"]);

                    pedidoItemColecao.Add(pedidoItem);
                }

                return pedidoItemColecao;


            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar o item do pedido. Detalhes: " + ex.Message);
            }
        }
    }
}
