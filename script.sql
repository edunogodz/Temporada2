CREATE TABLE [dbo].[tblCliente](
	[IDPessoaCliente] [int] NOT NULL,
 CONSTRAINT [PK_tblCliente] PRIMARY KEY CLUSTERED 
(
	[IDPessoaCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblEstoque]    Script Date: 27/07/2016 00:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEstoque](
	[IDPessoaFilial] [int] NOT NULL,
	[IDProduto] [int] NOT NULL,
	[Quantidade] [int] NOT NULL,
 CONSTRAINT [PK_tblEstoque] PRIMARY KEY CLUSTERED 
(
	[IDPessoaFilial] ASC,
	[IDProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblEstoqueMovimentado]    Script Date: 27/07/2016 00:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEstoqueMovimentado](
	[IDEstoqueMovimentado] [int] IDENTITY(1,1) NOT NULL,
	[IDPessoaFilial] [int] NOT NULL,
	[IDProduto] [int] NOT NULL,
	[Quantidade] [int] NOT NULL,
	[DataHora] [datetime] NOT NULL,
	[EntrouSaiu] [char](1) NOT NULL,
 CONSTRAINT [PK_tblEstoqueMovimentado] PRIMARY KEY CLUSTERED 
(
	[IDEstoqueMovimentado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblEstoqueReservado]    Script Date: 27/07/2016 00:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEstoqueReservado](
	[IDPessoaFilial] [int] NOT NULL,
	[IDProduto] [int] NOT NULL,
	[Quantidade] [int] NOT NULL,
 CONSTRAINT [PK_tblEstoqeReservado] PRIMARY KEY CLUSTERED 
(
	[IDPessoaFilial] ASC,
	[IDProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblFilial]    Script Date: 27/07/2016 00:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblFilial](
	[IDPessoaFilial] [int] NOT NULL,
 CONSTRAINT [PK_tblFilial] PRIMARY KEY CLUSTERED 
(
	[IDPessoaFilial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblFornecedor]    Script Date: 27/07/2016 00:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblFornecedor](
	[IDPessoaFornecedor] [int] NOT NULL,
 CONSTRAINT [PK_tblFornecedor] PRIMARY KEY CLUSTERED 
(
	[IDPessoaFornecedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblOperacao]    Script Date: 27/07/2016 00:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblOperacao](
	[IDOperacao] [int] NOT NULL,
	[Descricao] [varchar](20) NOT NULL,
 CONSTRAINT [PK_tblOperacao] PRIMARY KEY CLUSTERED 
(
	[IDOperacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPedido]    Script Date: 27/07/2016 00:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPedido](
	[IDPedido] [int] IDENTITY(1,1) NOT NULL,
	[DataHora] [datetime] NOT NULL,
	[IDOperacao] [int] NOT NULL,
	[IDSituacao] [int] NOT NULL,
	[IDPessoaEmitente] [int] NOT NULL,
	[IDPessoaDestinatario] [int] NOT NULL,
 CONSTRAINT [PK_tblPedido] PRIMARY KEY CLUSTERED 
(
	[IDPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblPedidoItem]    Script Date: 27/07/2016 00:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPedidoItem](
	[IDPedido] [int] NOT NULL,
	[IDProduto] [int] NOT NULL,
	[Quantidade] [int] NOT NULL,
	[ValorUnitario] [decimal](18, 2) NOT NULL,
	[PercentualDesconto] [decimal](5, 2) NOT NULL,
	[ValorDesconto] [decimal](18, 2) NOT NULL,
	[ValorTotal] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_tblPedidoItem] PRIMARY KEY CLUSTERED 
(
	[IDPedido] ASC,
	[IDProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblPessoa]    Script Date: 27/07/2016 00:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPessoa](
	[IDPessoa] [int] IDENTITY(1,1) NOT NULL,
	[IDPessoaTipo] [int] NOT NULL,
 CONSTRAINT [PK_tblPessoa] PRIMARY KEY CLUSTERED 
(
	[IDPessoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblPessoaFisica]    Script Date: 27/07/2016 00:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPessoaFisica](
	[IDPessoaFisica] [int] NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[CPF] [varchar](11) NOT NULL,
	[RG] [varchar](20) NULL,
	[DataNascimento] [date] NOT NULL,
 CONSTRAINT [PK_tblPessoaFisica] PRIMARY KEY CLUSTERED 
(
	[IDPessoaFisica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPessoaJuridica]    Script Date: 27/07/2016 00:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPessoaJuridica](
	[IDPessoaJuridica] [int] NOT NULL,
	[NomeFantasia] [varchar](50) NOT NULL,
	[Razao Social] [varchar](50) NOT NULL,
	[CNPJ] [varchar](14) NOT NULL,
	[InscricaoEstadual] [varchar](20) NULL,
	[DataFundacao] [date] NOT NULL,
 CONSTRAINT [PK_tblPessoaJuridica] PRIMARY KEY CLUSTERED 
(
	[IDPessoaJuridica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPessoaTipo]    Script Date: 27/07/2016 00:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPessoaTipo](
	[IDPessoaTipo] [int] NOT NULL,
	[Descricao] [varchar](20) NOT NULL,
 CONSTRAINT [PK_tblPessoaTipo] PRIMARY KEY CLUSTERED 
(
	[IDPessoaTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPreco]    Script Date: 27/07/2016 00:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPreco](
	[IDProduto] [int] NOT NULL,
	[Preco] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_tblPreco] PRIMARY KEY CLUSTERED 
(
	[IDProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblProduto]    Script Date: 27/07/2016 00:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblProduto](
	[IDProduto] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](100) NOT NULL,
 CONSTRAINT [PK_tblProduto] PRIMARY KEY CLUSTERED 
(
	[IDProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblSituacao]    Script Date: 27/07/2016 00:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblSituacao](
	[IDSituacao] [int] NOT NULL,
	[Descricao] [varchar](20) NOT NULL,
 CONSTRAINT [PK_tblSituacao] PRIMARY KEY CLUSTERED 
(
	[IDSituacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tblPedido] ADD  CONSTRAINT [DF_tblPedido_DataHora]  DEFAULT (getdate()) FOR [DataHora]
GO
ALTER TABLE [dbo].[tblCliente]  WITH CHECK ADD  CONSTRAINT [FK_tblCliente_tblPessoa] FOREIGN KEY([IDPessoaCliente])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
GO
ALTER TABLE [dbo].[tblCliente] CHECK CONSTRAINT [FK_tblCliente_tblPessoa]
GO
ALTER TABLE [dbo].[tblEstoque]  WITH CHECK ADD  CONSTRAINT [FK_tblEstoque_tblFilial] FOREIGN KEY([IDPessoaFilial])
REFERENCES [dbo].[tblFilial] ([IDPessoaFilial])
GO
ALTER TABLE [dbo].[tblEstoque] CHECK CONSTRAINT [FK_tblEstoque_tblFilial]
GO
ALTER TABLE [dbo].[tblEstoque]  WITH CHECK ADD  CONSTRAINT [FK_tblEstoque_tblProduto] FOREIGN KEY([IDProduto])
REFERENCES [dbo].[tblProduto] ([IDProduto])
GO
ALTER TABLE [dbo].[tblEstoque] CHECK CONSTRAINT [FK_tblEstoque_tblProduto]
GO
ALTER TABLE [dbo].[tblEstoqueMovimentado]  WITH CHECK ADD  CONSTRAINT [FK_tblEstoqueMovimentado_tblFilial] FOREIGN KEY([IDPessoaFilial])
REFERENCES [dbo].[tblFilial] ([IDPessoaFilial])
GO
ALTER TABLE [dbo].[tblEstoqueMovimentado] CHECK CONSTRAINT [FK_tblEstoqueMovimentado_tblFilial]
GO
ALTER TABLE [dbo].[tblEstoqueMovimentado]  WITH CHECK ADD  CONSTRAINT [FK_tblEstoqueMovimentado_tblProduto] FOREIGN KEY([IDProduto])
REFERENCES [dbo].[tblProduto] ([IDProduto])
GO
ALTER TABLE [dbo].[tblEstoqueMovimentado] CHECK CONSTRAINT [FK_tblEstoqueMovimentado_tblProduto]
GO
ALTER TABLE [dbo].[tblEstoqueReservado]  WITH CHECK ADD  CONSTRAINT [FK_tblEstoqeReservado_tblEstoque] FOREIGN KEY([IDPessoaFilial], [IDProduto])
REFERENCES [dbo].[tblEstoque] ([IDPessoaFilial], [IDProduto])
GO
ALTER TABLE [dbo].[tblEstoqueReservado] CHECK CONSTRAINT [FK_tblEstoqeReservado_tblEstoque]
GO
ALTER TABLE [dbo].[tblFilial]  WITH CHECK ADD  CONSTRAINT [FK_tblFilial_tblPessoa] FOREIGN KEY([IDPessoaFilial])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
GO
ALTER TABLE [dbo].[tblFilial] CHECK CONSTRAINT [FK_tblFilial_tblPessoa]
GO
ALTER TABLE [dbo].[tblFornecedor]  WITH CHECK ADD  CONSTRAINT [FK_tblFornecedor_tblPessoa] FOREIGN KEY([IDPessoaFornecedor])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
GO
ALTER TABLE [dbo].[tblFornecedor] CHECK CONSTRAINT [FK_tblFornecedor_tblPessoa]
GO
ALTER TABLE [dbo].[tblPedido]  WITH CHECK ADD  CONSTRAINT [FK_tblPedido_tblOperacao] FOREIGN KEY([IDOperacao])
REFERENCES [dbo].[tblOperacao] ([IDOperacao])
GO
ALTER TABLE [dbo].[tblPedido] CHECK CONSTRAINT [FK_tblPedido_tblOperacao]
GO
ALTER TABLE [dbo].[tblPedido]  WITH CHECK ADD  CONSTRAINT [FK_tblPedido_tblPessoa_Destinatario] FOREIGN KEY([IDPessoaDestinatario])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
GO
ALTER TABLE [dbo].[tblPedido] CHECK CONSTRAINT [FK_tblPedido_tblPessoa_Destinatario]
GO
ALTER TABLE [dbo].[tblPedido]  WITH CHECK ADD  CONSTRAINT [FK_tblPedido_tblPessoaEmitente] FOREIGN KEY([IDPessoaEmitente])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
GO
ALTER TABLE [dbo].[tblPedido] CHECK CONSTRAINT [FK_tblPedido_tblPessoaEmitente]
GO
ALTER TABLE [dbo].[tblPedido]  WITH CHECK ADD  CONSTRAINT [FK_tblPedido_tblSituacao] FOREIGN KEY([IDSituacao])
REFERENCES [dbo].[tblSituacao] ([IDSituacao])
GO
ALTER TABLE [dbo].[tblPedido] CHECK CONSTRAINT [FK_tblPedido_tblSituacao]
GO
ALTER TABLE [dbo].[tblPedidoItem]  WITH CHECK ADD  CONSTRAINT [FK_tblPedidoItem_tblPedido] FOREIGN KEY([IDPedido])
REFERENCES [dbo].[tblPedido] ([IDPedido])
GO
ALTER TABLE [dbo].[tblPedidoItem] CHECK CONSTRAINT [FK_tblPedidoItem_tblPedido]
GO
ALTER TABLE [dbo].[tblPedidoItem]  WITH CHECK ADD  CONSTRAINT [FK_tblPedidoItem_tblProduto] FOREIGN KEY([IDProduto])
REFERENCES [dbo].[tblProduto] ([IDProduto])
GO
ALTER TABLE [dbo].[tblPedidoItem] CHECK CONSTRAINT [FK_tblPedidoItem_tblProduto]
GO
ALTER TABLE [dbo].[tblPessoa]  WITH CHECK ADD  CONSTRAINT [FK_tblPessoa_tblPessoaTipo] FOREIGN KEY([IDPessoaTipo])
REFERENCES [dbo].[tblPessoaTipo] ([IDPessoaTipo])
GO
ALTER TABLE [dbo].[tblPessoa] CHECK CONSTRAINT [FK_tblPessoa_tblPessoaTipo]
GO
ALTER TABLE [dbo].[tblPessoaFisica]  WITH CHECK ADD  CONSTRAINT [FK_tblPessoaFisica_tblPessoa] FOREIGN KEY([IDPessoaFisica])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
GO
ALTER TABLE [dbo].[tblPessoaFisica] CHECK CONSTRAINT [FK_tblPessoaFisica_tblPessoa]
GO
ALTER TABLE [dbo].[tblPessoaJuridica]  WITH CHECK ADD  CONSTRAINT [FK_tblPessoaJuridica_tblPessoa] FOREIGN KEY([IDPessoaJuridica])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
GO
ALTER TABLE [dbo].[tblPessoaJuridica] CHECK CONSTRAINT [FK_tblPessoaJuridica_tblPessoa]
GO
ALTER TABLE [dbo].[tblPreco]  WITH CHECK ADD  CONSTRAINT [FK_tblPreco_tblProduto] FOREIGN KEY([IDProduto])
REFERENCES [dbo].[tblProduto] ([IDProduto])
GO
ALTER TABLE [dbo].[tblPreco] CHECK CONSTRAINT [FK_tblPreco_tblProduto]
GO
/****** Object:  StoredProcedure [dbo].[uspFilialInserir]    Script Date: 27/07/2016 00:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspFilialInserir]
	@IDPessoaFilial as Int

AS
BEGIN
--Exceção(try/CATCH)
--Transação

	BEGIN TRY
		BEGIN TRAN

		--Não deixa inserir Pessoa que já é Filial
		if (exists(SELECT IDPessoaFilial FROM tblFilial WHERE IDPessoaFilial = @IDPessoaFilial))
			RAISERROR('Filial já existe',14,1);

		--1º Inserir na tabela tblFilial
		Insert into tblFilial(IDPessoaFilial) values(@IDPessoaFilial);
		
		Select @IDPessoaFilial as Retorno;

		COMMIT TRAN
	END TRY

	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() as Retorno;

	END CATCH
	

END
GO
/****** Object:  StoredProcedure [dbo].[uspPessoaFisicaInserir]    Script Date: 27/07/2016 00:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPessoaFisicaInserir]
	@Nome AS Varchar(50),
	@CPF As Varchar(11),
	@RG As Varchar(20),
	@DataNascimento as Date

AS
BEGIN
--Exceção(try/CATCH)
--Transação

	BEGIN TRY
		BEGIN TRAN

		--Não deixa inserir CPF igual no banco
		if (exists(SELECT IDPessoaFisica FROM tblPessoaFisica WHERE CPF = @CPF))
			RAISERROR('CPF já existe',14,1);

		Declare @IDPessoa as Int;

		--1º Inserir na tabela Pessoa
		Insert into tblPessoa(IDPessoaTipo) values(1);

		set @IDPessoa = @@IDENTITY;

		--2º Inserir na tabela PessoaFisica
		Insert into tblPessoaFisica(IDPessoaFisica,Nome,CPF,RG,DataNascimento)
		Values (@IDPessoa,@Nome,@CPF,@RG,@DataNascimento);
		
		Select @IDPessoa as Retorno;

		COMMIT TRAN
	END TRY

	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() as Retorno;

	END CATCH
	

END
GO
/****** Object:  StoredProcedure [dbo].[uspPessoaJuridicaInserir]    Script Date: 27/07/2016 00:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPessoaJuridicaInserir]
	@NomeFantasia AS Varchar(50),
	@RazaoSocial As Varchar(50),
	@CNPJ As Varchar(14),
	@InscricaoEstadual As Varchar(20),
	@DataFundacao as Date

AS
BEGIN
--Exceção(try/CATCH)
--Transação

	BEGIN TRY
		BEGIN TRAN

		--Não deixa inserir CNPJ igual no banco
		if (exists(SELECT IDPessoaJuridica FROM tblPessoaJuridica WHERE CNPJ = @CNPJ))
			RAISERROR('CNPJ já existe',14,1);

		Declare @IDPessoa as Int;

		--1º Inserir na tabela Pessoa
		Insert into tblPessoa(IDPessoaTipo) values(2);

		set @IDPessoa = @@IDENTITY;

		--2º Inserir na tabela PessoaFisica
		Insert into tblPessoaJuridica
		(
			IDPessoaJuridica,
			NomeFantasia,
			[Razao Social],
			CNPJ,
			InscricaoEstadual,
			DataFundacao
		)
		Values 
		(
			@IDPessoa,
			@NomeFantasia,
			@RazaoSocial,
			@CNPJ,
			@InscricaoEstadual,
			@DataFundacao
		);
		
		Select @IDPessoa as Retorno;

		COMMIT TRAN
	END TRY

	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() as Retorno;

	END CATCH
	

END
GO
