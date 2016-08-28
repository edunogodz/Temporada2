using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ObjetoTransferencia;
using Negocios;



namespace Apresentacao
{
    public partial class frmFilialPesquisar : Form
    {
        public frmFilialPesquisar()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FilialNegocios filialNegocios = new FilialNegocios();
            
            //Digitou numero ou nome
            int codigoDigitado;

            FilialColecao filialColecao = new FilialColecao();

            if (int.TryParse(txtPesquisar.Text, out codigoDigitado))
            {
                //Conseguiu, é um numero
                filialColecao = filialNegocios.ConsultaPorCodigo(codigoDigitado);
            }
            else
            {
                //Não conseguiu eh um texto
                filialColecao = filialNegocios.ConsultaPorNome(txtPesquisar.Text);
            }

            dgwPesquisar.DataSource = null;

            var novafilialColecao = filialColecao.Select(filial => new
            {
                IdPessoaFilial = filial.Pessoa.IDPessoa,
                Nome = filial.Pessoa.Nome,
                CpfCnpj = filial.Pessoa.CpfCnpj,
                IdPessoTipo = filial.Pessoa.PessoaTipo.IDPessoaTipo,
                Descricao = filial.Pessoa.PessoaTipo.Descricao
            }).ToList();

            dgwPesquisar.AutoResizeColumns();

            //Tamanho coluna Nome que é a coluna 1
            //dgwPrincipal.Columns[1].Width = 252;

            dgwPesquisar.DataSource = novafilialColecao;

            dgwPesquisar.Update();
            dgwPesquisar.Refresh();

        }
    }
}
