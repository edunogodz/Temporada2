namespace Apresentacao
{
    partial class frmPedidoVendaCadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEmitente = new System.Windows.Forms.Label();
            this.txtEmitente = new System.Windows.Forms.TextBox();
            this.btnPesquisarEmitente = new System.Windows.Forms.Button();
            this.btnPesquisarDestinatario = new System.Windows.Forms.Button();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtOperacao = new System.Windows.Forms.TextBox();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.txtDataHora = new System.Windows.Forms.TextBox();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.grpItens = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtItens = new System.Windows.Forms.TextBox();
            this.lblItens = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.txtPercentualDesconto = new System.Windows.Forms.TextBox();
            this.lblPercentualDesconto = new System.Windows.Forms.Label();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtProdutoCodigo = new System.Windows.Forms.TextBox();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.txtProdutoDescricao = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.dgwItens = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.grpItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItens)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmitente
            // 
            this.lblEmitente.AutoSize = true;
            this.lblEmitente.Location = new System.Drawing.Point(6, 2);
            this.lblEmitente.Name = "lblEmitente";
            this.lblEmitente.Size = new System.Drawing.Size(48, 13);
            this.lblEmitente.TabIndex = 0;
            this.lblEmitente.Text = "Emitente";
            // 
            // txtEmitente
            // 
            this.txtEmitente.Location = new System.Drawing.Point(6, 17);
            this.txtEmitente.Name = "txtEmitente";
            this.txtEmitente.Size = new System.Drawing.Size(492, 20);
            this.txtEmitente.TabIndex = 1;
            // 
            // btnPesquisarEmitente
            // 
            this.btnPesquisarEmitente.Location = new System.Drawing.Point(505, 14);
            this.btnPesquisarEmitente.Name = "btnPesquisarEmitente";
            this.btnPesquisarEmitente.Size = new System.Drawing.Size(40, 23);
            this.btnPesquisarEmitente.TabIndex = 2;
            this.btnPesquisarEmitente.Text = "...";
            this.btnPesquisarEmitente.UseVisualStyleBackColor = true;
            this.btnPesquisarEmitente.Click += new System.EventHandler(this.btnPesquisarEmitente_Click);
            // 
            // btnPesquisarDestinatario
            // 
            this.btnPesquisarDestinatario.Location = new System.Drawing.Point(505, 66);
            this.btnPesquisarDestinatario.Name = "btnPesquisarDestinatario";
            this.btnPesquisarDestinatario.Size = new System.Drawing.Size(40, 23);
            this.btnPesquisarDestinatario.TabIndex = 5;
            this.btnPesquisarDestinatario.Text = "...";
            this.btnPesquisarDestinatario.UseVisualStyleBackColor = true;
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Location = new System.Drawing.Point(6, 69);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(492, 20);
            this.txtDestinatario.TabIndex = 4;
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Location = new System.Drawing.Point(6, 50);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(63, 13);
            this.lblDestinatario.TabIndex = 3;
            this.lblDestinatario.Text = "Destinatario";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(551, 2);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 6;
            this.lblNumero.Text = "Numero";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(551, 17);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(106, 20);
            this.txtNumero.TabIndex = 7;
            this.txtNumero.TabStop = false;
            // 
            // txtOperacao
            // 
            this.txtOperacao.Location = new System.Drawing.Point(551, 69);
            this.txtOperacao.Name = "txtOperacao";
            this.txtOperacao.ReadOnly = true;
            this.txtOperacao.Size = new System.Drawing.Size(106, 20);
            this.txtOperacao.TabIndex = 9;
            this.txtOperacao.TabStop = false;
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Location = new System.Drawing.Point(551, 50);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(54, 13);
            this.lblOperacao.TabIndex = 8;
            this.lblOperacao.Text = "Operacao";
            // 
            // txtSituacao
            // 
            this.txtSituacao.Location = new System.Drawing.Point(670, 69);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.ReadOnly = true;
            this.txtSituacao.Size = new System.Drawing.Size(106, 20);
            this.txtSituacao.TabIndex = 13;
            this.txtSituacao.TabStop = false;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(670, 50);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(49, 13);
            this.lblSituacao.TabIndex = 12;
            this.lblSituacao.Text = "Situacao";
            // 
            // txtDataHora
            // 
            this.txtDataHora.Location = new System.Drawing.Point(670, 17);
            this.txtDataHora.Name = "txtDataHora";
            this.txtDataHora.ReadOnly = true;
            this.txtDataHora.Size = new System.Drawing.Size(106, 20);
            this.txtDataHora.TabIndex = 11;
            this.txtDataHora.TabStop = false;
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Location = new System.Drawing.Point(670, 2);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(58, 13);
            this.lblDataHora.TabIndex = 10;
            this.lblDataHora.Text = "Data/Hora";
            // 
            // grpItens
            // 
            this.grpItens.Controls.Add(this.btnExcluir);
            this.grpItens.Controls.Add(this.btnAlterar);
            this.grpItens.Controls.Add(this.txtValor);
            this.grpItens.Controls.Add(this.lblValor);
            this.grpItens.Controls.Add(this.txtItens);
            this.grpItens.Controls.Add(this.lblItens);
            this.grpItens.Controls.Add(this.txtEstoque);
            this.grpItens.Controls.Add(this.lblEstoque);
            this.grpItens.Controls.Add(this.txtPercentualDesconto);
            this.grpItens.Controls.Add(this.lblPercentualDesconto);
            this.grpItens.Controls.Add(this.txtValorUnitario);
            this.grpItens.Controls.Add(this.lblValorUnitario);
            this.grpItens.Controls.Add(this.btnInserir);
            this.grpItens.Controls.Add(this.txtQuantidade);
            this.grpItens.Controls.Add(this.lblQuantidade);
            this.grpItens.Controls.Add(this.txtProdutoCodigo);
            this.grpItens.Controls.Add(this.btnPesquisarProduto);
            this.grpItens.Controls.Add(this.txtProdutoDescricao);
            this.grpItens.Controls.Add(this.lblProduto);
            this.grpItens.Controls.Add(this.dgwItens);
            this.grpItens.Location = new System.Drawing.Point(6, 95);
            this.grpItens.Name = "grpItens";
            this.grpItens.Size = new System.Drawing.Size(773, 273);
            this.grpItens.TabIndex = 14;
            this.grpItens.TabStop = false;
            this.grpItens.Text = "Itens";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(713, 246);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(55, 23);
            this.btnExcluir.TabIndex = 23;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(649, 246);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(55, 23);
            this.btnAlterar.TabIndex = 22;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(175, 247);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(74, 20);
            this.txtValor.TabIndex = 21;
            this.txtValor.TabStop = false;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(138, 251);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 20;
            this.lblValor.Text = "Valor:";
            // 
            // txtItens
            // 
            this.txtItens.Location = new System.Drawing.Point(42, 247);
            this.txtItens.Name = "txtItens";
            this.txtItens.ReadOnly = true;
            this.txtItens.Size = new System.Drawing.Size(74, 20);
            this.txtItens.TabIndex = 19;
            this.txtItens.TabStop = false;
            // 
            // lblItens
            // 
            this.lblItens.AutoSize = true;
            this.lblItens.Location = new System.Drawing.Point(6, 251);
            this.lblItens.Name = "lblItens";
            this.lblItens.Size = new System.Drawing.Size(33, 13);
            this.lblItens.TabIndex = 18;
            this.lblItens.Text = "Itens:";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(676, 30);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.ReadOnly = true;
            this.txtEstoque.Size = new System.Drawing.Size(74, 20);
            this.txtEstoque.TabIndex = 17;
            this.txtEstoque.TabStop = false;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(676, 16);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(46, 13);
            this.lblEstoque.TabIndex = 16;
            this.lblEstoque.Text = "Estoque";
            // 
            // txtPercentualDesconto
            // 
            this.txtPercentualDesconto.Location = new System.Drawing.Point(579, 30);
            this.txtPercentualDesconto.Name = "txtPercentualDesconto";
            this.txtPercentualDesconto.ReadOnly = true;
            this.txtPercentualDesconto.Size = new System.Drawing.Size(74, 20);
            this.txtPercentualDesconto.TabIndex = 15;
            this.txtPercentualDesconto.TabStop = false;
            // 
            // lblPercentualDesconto
            // 
            this.lblPercentualDesconto.AutoSize = true;
            this.lblPercentualDesconto.Location = new System.Drawing.Point(579, 16);
            this.lblPercentualDesconto.Name = "lblPercentualDesconto";
            this.lblPercentualDesconto.Size = new System.Drawing.Size(64, 13);
            this.lblPercentualDesconto.TabIndex = 14;
            this.lblPercentualDesconto.Text = "% Desconto";
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(496, 30);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.ReadOnly = true;
            this.txtValorUnitario.Size = new System.Drawing.Size(74, 20);
            this.txtValorUnitario.TabIndex = 13;
            this.txtValorUnitario.TabStop = false;
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Location = new System.Drawing.Point(496, 16);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(70, 13);
            this.lblValorUnitario.TabIndex = 12;
            this.lblValorUnitario.Text = "Valor Unitario";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(431, 29);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(55, 23);
            this.btnInserir.TabIndex = 11;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(363, 30);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(62, 20);
            this.txtQuantidade.TabIndex = 10;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(363, 16);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 9;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txtProdutoCodigo
            // 
            this.txtProdutoCodigo.Location = new System.Drawing.Point(9, 30);
            this.txtProdutoCodigo.Name = "txtProdutoCodigo";
            this.txtProdutoCodigo.ReadOnly = true;
            this.txtProdutoCodigo.Size = new System.Drawing.Size(30, 20);
            this.txtProdutoCodigo.TabIndex = 8;
            this.txtProdutoCodigo.TabStop = false;
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.Location = new System.Drawing.Point(317, 29);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(40, 23);
            this.btnPesquisarProduto.TabIndex = 5;
            this.btnPesquisarProduto.Text = "...";
            this.btnPesquisarProduto.UseVisualStyleBackColor = true;
            // 
            // txtProdutoDescricao
            // 
            this.txtProdutoDescricao.Location = new System.Drawing.Point(45, 30);
            this.txtProdutoDescricao.Name = "txtProdutoDescricao";
            this.txtProdutoDescricao.Size = new System.Drawing.Size(266, 20);
            this.txtProdutoDescricao.TabIndex = 4;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(6, 16);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 3;
            this.lblProduto.Text = "Produto";
            // 
            // dgwItens
            // 
            this.dgwItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwItens.Location = new System.Drawing.Point(7, 59);
            this.dgwItens.Name = "dgwItens";
            this.dgwItens.Size = new System.Drawing.Size(761, 181);
            this.dgwItens.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(658, 376);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(58, 23);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(594, 376);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(55, 23);
            this.btnFinalizar.TabIndex = 24;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(719, 376);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(55, 23);
            this.btnFechar.TabIndex = 26;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // frmPedidoVendaCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.grpItens);
            this.Controls.Add(this.txtSituacao);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.txtDataHora);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.txtOperacao);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.btnPesquisarDestinatario);
            this.Controls.Add(this.txtDestinatario);
            this.Controls.Add(this.lblDestinatario);
            this.Controls.Add(this.btnPesquisarEmitente);
            this.Controls.Add(this.txtEmitente);
            this.Controls.Add(this.lblEmitente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPedidoVendaCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido de Venda";
            this.grpItens.ResumeLayout(false);
            this.grpItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmitente;
        private System.Windows.Forms.TextBox txtEmitente;
        private System.Windows.Forms.Button btnPesquisarEmitente;
        private System.Windows.Forms.Button btnPesquisarDestinatario;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtOperacao;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.TextBox txtDataHora;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.GroupBox grpItens;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtItens;
        private System.Windows.Forms.Label lblItens;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.TextBox txtPercentualDesconto;
        private System.Windows.Forms.Label lblPercentualDesconto;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.Label lblValorUnitario;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtProdutoCodigo;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.TextBox txtProdutoDescricao;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.DataGridView dgwItens;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnFechar;
    }
}