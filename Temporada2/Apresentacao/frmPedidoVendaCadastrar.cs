using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmPedidoVendaCadastrar : Form
    {
        public frmPedidoVendaCadastrar()
        {
            InitializeComponent();
        }

        private void btnPesquisarEmitente_Click(object sender, EventArgs e)
        {
            frmFilialPesquisar frmFilialPesquisar = new frmFilialPesquisar();            
            frmFilialPesquisar.ShowDialog();
        }
    }
}
