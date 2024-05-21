USE [master]
GO
/****** Object:  Database [AulaDB]    Script Date: 21/05/2024 00:29:02 ******/
CREATE DATABASE [AulaDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AulaDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\AulaDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AulaDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\AulaDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [AulaDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AulaDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AulaDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AulaDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AulaDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AulaDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AulaDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [AulaDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AulaDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AulaDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AulaDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AulaDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AulaDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AulaDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AulaDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AulaDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AulaDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [AulaDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AulaDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AulaDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AulaDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AulaDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AulaDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AulaDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AulaDB] SET RECOVERY FULL 
GO
ALTER DATABASE [AulaDB] SET  MULTI_USER 
GO
ALTER DATABASE [AulaDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AulaDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AulaDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AulaDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AulaDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AulaDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'AulaDB', N'ON'
GO
ALTER DATABASE [AulaDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [AulaDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [AulaDB]
GO
/****** Object:  Table [dbo].[Alunos]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alunos](
	[Id] [int] NOT NULL,
	[nome] [varchar](50) NULL,
	[mensalidade] [decimal](10, 3) NULL,
	[cidadeId] [int] NULL,
	[DataNascimento] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[carros]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[carros](
	[Id] [int] NOT NULL,
	[Marca] [varchar](30) NULL,
	[Modelo] [varchar](30) NULL,
	[Placa] [varchar](30) NULL,
	[Kilometragem] [decimal](19, 2) NULL,
	[Valor] [decimal](19, 2) NULL,
	[tipo] [varchar](30) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[id] [int] NOT NULL,
	[nome] [varchar](30) NULL,
	[telefone] [varchar](30) NULL,
	[VeiculosComprados] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dependente]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dependente](
	[id] [int] NOT NULL,
	[FuncionarioId] [int] NOT NULL,
	[Nome] [varchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Funcionario]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcionario](
	[id] [int] NOT NULL,
	[Nome] [varchar](150) NOT NULL,
	[cpf] [varchar](15) NOT NULL,
	[Telefone] [varchar](150) NOT NULL,
	[salario] [decimal](18, 2) NOT NULL,
	[FormacaoAcademica] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[jogos]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[jogos](
	[id] [int] NOT NULL,
	[descricao] [varchar](50) NULL,
	[valor_locacao] [decimal](18, 2) NULL,
	[data_aquisicao] [datetime] NULL,
	[categoriaID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[motos]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[motos](
	[Id] [int] NOT NULL,
	[Marca] [varchar](30) NULL,
	[Modelo] [varchar](30) NULL,
	[Placa] [varchar](30) NULL,
	[Kilometragem] [decimal](19, 2) NULL,
	[Valor] [decimal](19, 2) NULL,
	[cilindrada] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pessoa]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pessoa](
	[ID] [int] NOT NULL,
	[Nome] [nvarchar](100) NULL,
	[Telefone] [nvarchar](20) NULL,
	[Tipo] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[veiculo]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[veiculo](
	[Id] [int] NOT NULL,
	[Marca] [varchar](30) NULL,
	[Modelo] [varchar](30) NULL,
	[Placa] [varchar](30) NULL,
	[preco] [decimal](19, 2) NULL,
	[tipo] [varchar](30) NULL,
	[foto] [varbinary](max) NULL,
	[Ano] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vendas]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendas](
	[VendaID] [int] IDENTITY(1,1) NOT NULL,
	[VeiculoID] [int] NULL,
	[CompradorID] [int] NULL,
	[VendedorID] [int] NULL,
	[DataVenda] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[VendaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vendedores]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vendedores](
	[Id] [int] NOT NULL,
	[nome] [varchar](30) NULL,
	[telefone] [varchar](30) NULL,
	[Vendas] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[carros] ([Id], [Marca], [Modelo], [Placa], [Kilometragem], [Valor], [tipo]) VALUES (1, N'Volkswagen', N'Fox', N'aaaa0000', CAST(150.00 AS Decimal(19, 2)), CAST(15000.00 AS Decimal(19, 2)), N'Hatch')
INSERT [dbo].[carros] ([Id], [Marca], [Modelo], [Placa], [Kilometragem], [Valor], [tipo]) VALUES (2, N'Volkswagen', N'gol', N'aaaaa0001', CAST(1.00 AS Decimal(19, 2)), CAST(40000.00 AS Decimal(19, 2)), N'Hatch')
INSERT [dbo].[carros] ([Id], [Marca], [Modelo], [Placa], [Kilometragem], [Valor], [tipo]) VALUES (1, N'Ford', N'KA sport 1.6', NULL, CAST(0.00 AS Decimal(19, 2)), CAST(35000.00 AS Decimal(19, 2)), NULL)
GO
INSERT [dbo].[clientes] ([id], [nome], [telefone], [VeiculosComprados]) VALUES (1, N'Jose', N'11999999', 0)
GO
INSERT [dbo].[Funcionario] ([id], [Nome], [cpf], [Telefone], [salario], [FormacaoAcademica]) VALUES (1, N'aaaa', N'12314', N'21413431', CAST(1234.00 AS Decimal(18, 2)), N'sim')
GO
INSERT [dbo].[jogos] ([id], [descricao], [valor_locacao], [data_aquisicao], [categoriaID]) VALUES (1, N'1', CAST(1.00 AS Decimal(18, 2)), CAST(N'2011-11-11T00:00:00.000' AS DateTime), 11)
GO
INSERT [dbo].[veiculo] ([Id], [Marca], [Modelo], [Placa], [preco], [tipo], [foto], [Ano]) VALUES (1, N'volkswagen', N'fox', N'0000', CAST(0.00 AS Decimal(19, 2)), N'carro', NULL, NULL)
GO
INSERT [dbo].[vendedores] ([Id], [nome], [telefone], [Vendas]) VALUES (1, N'evandro', N'1', NULL)
INSERT [dbo].[vendedores] ([Id], [nome], [telefone], [Vendas]) VALUES (2, N'evan', N'12', NULL)
GO
ALTER TABLE [dbo].[Vendas]  WITH CHECK ADD FOREIGN KEY([CompradorID])
REFERENCES [dbo].[Pessoa] ([ID])
GO
ALTER TABLE [dbo].[Vendas]  WITH CHECK ADD FOREIGN KEY([VeiculoID])
REFERENCES [dbo].[veiculo] ([Id])
GO
ALTER TABLE [dbo].[Vendas]  WITH CHECK ADD FOREIGN KEY([VendedorID])
REFERENCES [dbo].[Pessoa] ([ID])
GO
/****** Object:  StoredProcedure [dbo].[spAlteraCarro]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spAlteraCarro]
(
 @id int,
 @marca varchar(30),
 @modelo varchar(30),
 @placa varchar(30),
 @kilometragem decimal(19,2),
 @valor decimal(19,2),
 @Tipo varchar(30)
)
as
begin
 update carros set
 marca = @marca, modelo = @modelo, placa = @placa, kilometragem = @kilometragem, valor = @valor, tipo = @Tipo where id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[spAlteraCliente]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spAlteraCliente]
(
 @id int,
 @nome varchar(30),
 @telefone varchar(30),
 @veiculosComprados int
)
as
begin
 update clientes set
 nome = @nome, @telefone = @telefone, veiculosComprados = @veiculosComprados where id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[spAlteramoto]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spAlteramoto]
(
 @id int,
 @marca varchar(30),
 @modelo varchar(30),
 @placa varchar(30),
 @kilometragem decimal(19,2),
 @valor decimal(19,2),
 @cilindrada int
)
as
begin
 update motos set
 marca = @marca, modelo = @modelo, placa = @placa, kilometragem = @kilometragem, valor = @valor, cilindrada = @cilindrada where id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[SpAlteraPessoa]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Stored procedure para alterar uma pessoa pelo ID
CREATE PROCEDURE [dbo].[SpAlteraPessoa]
(
    @ID INT,
    @Nome NVARCHAR(100),
    @Telefone NVARCHAR(20),
    @Tipo VARCHAR(20)
)
AS
BEGIN
    UPDATE Pessoa 
    SET 
        Nome = @Nome, 
        Telefone = @Telefone, 
        Tipo = @Tipo 
    WHERE 
        ID = @ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[spAlteraVeiculo]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[spAlteraVeiculo]
(
 @id int,
 @marca varchar(30),
 @modelo varchar(30),
 @ano int,
 @placa varchar(30),
 @valor decimal(19,2),
 @Tipo varchar(30),
 @Imagem varbinary(max)
)
as
begin
 update veiculo set
 Marca = @marca, Modelo = @modelo, ano = @ano, placa = @placa, foto = @Imagem, valor = @valor, tipo = @Tipo where id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[SpAlteraVenda]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpAlteraVenda]
(
    @VendaID INT,
    @VeiculoID INT,
    @CompradorID INT,
    @VendedorID INT,
    @DataVenda DATETIME
)
AS
BEGIN
    UPDATE Vendas 
    SET 
        VeiculoID = @VeiculoID, 
        CompradorID = @CompradorID, 
        VendedorID = @VendedorID, 
        DataVenda = @DataVenda 
    WHERE 
        VendaID = @VendaID;
END;
GO
/****** Object:  StoredProcedure [dbo].[spAlteraVendedor]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[spAlteraVendedor]
(
 @id int,
 @nome varchar(30),
 @telefone varchar(30)
)
as
begin
 update vendedores set
 nome = @nome, telefone = @telefone where id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[spConsultaCarro]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spConsultaCarro]
(
 @id int
)
as
begin
 select * from carros where id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[spConsultacliente]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spConsultacliente]
(
 @id int
)
as
begin
 select * from clientes where id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[spConsultamoto]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spConsultamoto]
(
 @id int
)
as
begin
 select * from motos where id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[SPConsultaPessoa]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Stored procedure para consultar uma pessoa pelo ID
CREATE PROCEDURE [dbo].[SPConsultaPessoa]
(
    @ID INT
)
AS
BEGIN
    SELECT *
    FROM Pessoa
    WHERE ID = @ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[SPConsultaVeiculo]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Stored procedure para consultar um veículo pelo ID
CREATE PROCEDURE [dbo].[SPConsultaVeiculo]
(
    @id int
)
AS
BEGIN
    SELECT *
    FROM veiculo
    WHERE id = @id;
END;
GO
/****** Object:  StoredProcedure [dbo].[SPConsultaVenda]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPConsultaVenda]
(
    @VendaID INT
)
AS
BEGIN
    SELECT *
    FROM Vendas
    WHERE VendaID = @VendaID;
END;
GO
/****** Object:  StoredProcedure [dbo].[spConsultavendedor]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[spConsultavendedor]
(
 @id int
)
as
begin
 select * from vendedores where id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[spExcluiCarros]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spExcluiCarros]
(
 @id int
)
as
begin
 delete Carros where id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[spExcluiCliente]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spExcluiCliente]
(
 @id int
)
as
begin
 delete Clientes where id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[spExcluiMoto]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spExcluiMoto]
(
 @id int
)
as
begin
 delete Motos where id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[SpExcluiPessoa]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Stored procedure para excluir uma pessoa pelo ID
CREATE PROCEDURE [dbo].[SpExcluiPessoa]
(
    @ID INT
)
AS
BEGIN
    DELETE FROM Pessoa
    WHERE ID = @ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[SpExcluiVeiculo]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Stored procedure para excluir um veículo pelo ID
CREATE PROCEDURE [dbo].[SpExcluiVeiculo]
(
    @id int
)
AS
BEGIN
    DELETE FROM veiculo
    WHERE id = @id;
END;
GO
/****** Object:  StoredProcedure [dbo].[SpExcluiVenda]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpExcluiVenda]
(
    @VendaID INT
)
AS
BEGIN
    DELETE FROM Vendas
    WHERE VendaID = @VendaID;
END;
GO
/****** Object:  StoredProcedure [dbo].[spExcluiVendedor]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spExcluiVendedor]
(
 @id int
)
as
begin
 delete vendedores where id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[spIncluiCarro]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spIncluiCarro]
(
 @id int,
 @marca varchar(30),
 @modelo varchar(30),
 @placa varchar(30),
 @kilometragem decimal(19,2),
 @valor decimal(19,2),
 @tipo varchar(30)
)
as
begin
 insert into carros
 (id, marca, modelo, placa, kilometragem, valor, tipo)
 values
 (@id, @marca, @modelo, @placa, @kilometragem, @valor, @tipo)
end
GO
/****** Object:  StoredProcedure [dbo].[spIncluiCliente]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spIncluiCliente]
(
 @id int,
 @nome varchar(30),
 @telefone varchar(30),
 @veiculosComprados int
)
as
begin
 insert into clientes
 (id, nome, telefone, veiculoscomprados)
 values
 (@id, @nome, @telefone, @veiculosComprados)
end
GO
/****** Object:  StoredProcedure [dbo].[spIncluimoto]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spIncluimoto]
(
 @id int,
 @marca varchar(30),
 @modelo varchar(30),
 @placa varchar(30),
 @kilometragem decimal(19,2),
 @valor decimal(19,2),
 @cilindrada int
)
as
begin
 insert into motos
 (id, marca, modelo, placa, kilometragem, valor, cilindrada)
 values
 (@id, @marca, @modelo, @placa, @kilometragem, @valor, @cilindrada)
end
GO
/****** Object:  StoredProcedure [dbo].[spIncluiVendedor]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[spIncluiVendedor]
(
 @id int,
 @nome varchar(30),
 @telefone varchar(30)
)
as
begin
 insert into vendedores
 (id, nome, telefone, vendas)
 values
 (@id, @nome, @telefone, null)
end
GO
/****** Object:  StoredProcedure [dbo].[SpInserePessoa]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Stored procedure para inserir uma nova pessoa
CREATE   PROCEDURE [dbo].[SpInserePessoa]
(
	@id int,
    @Nome NVARCHAR(100),
    @Telefone NVARCHAR(20),
    @Tipo VARCHAR(20)
)
AS
BEGIN
    INSERT INTO Pessoa (Id, Nome, Telefone, Tipo)
    VALUES (@Id, @Nome, @Telefone, @Tipo);
END;
GO
/****** Object:  StoredProcedure [dbo].[SpInsereVeiculo]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpInsereVeiculo]
(
    @marca varchar(30),
    @modelo varchar(30),
    @placa varchar(30),
    @preco decimal(19,2),
    @Tipo varchar(30),
    @Imagem varbinary(max),
	@ano int
)
AS
BEGIN
    INSERT INTO veiculo (Marca, Modelo, placa, foto, preco, tipo, ano)
    VALUES (@marca, @modelo, @placa, @Imagem, @preco, @Tipo, @ano);
END;
GO
/****** Object:  StoredProcedure [dbo].[SpInsereVenda]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpInsereVenda]
(
    @VeiculoID INT,
    @CompradorID INT,
    @VendedorID INT,
    @DataVenda DATETIME
)
AS
BEGIN
    INSERT INTO Vendas (VeiculoID, CompradorID, VendedorID, DataVenda)
    VALUES (@VeiculoID, @CompradorID, @VendedorID, @DataVenda);
END;
GO
/****** Object:  StoredProcedure [dbo].[spListagemCarros]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[spListagemCarros]
as
select * from carros
GO
/****** Object:  StoredProcedure [dbo].[spListagemClientes]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[spListagemClientes]
as
select * from Clientes
GO
/****** Object:  StoredProcedure [dbo].[spListagemMotos]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[spListagemMotos]
as
select * from Motos
GO
/****** Object:  StoredProcedure [dbo].[SpListagemPessoa]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Stored procedure para listar todas as pessoas
CREATE PROCEDURE [dbo].[SpListagemPessoa]
AS
BEGIN
    SELECT *
    FROM Pessoa;
END;
GO
/****** Object:  StoredProcedure [dbo].[spListagemVeiculo]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Stored procedure para listar todos os veículos
CREATE PROCEDURE [dbo].[spListagemVeiculo]
AS
BEGIN
    SELECT *
    FROM veiculo;
END;
GO
/****** Object:  StoredProcedure [dbo].[SpListagemVenda]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpListagemVenda]
AS
BEGIN
    SELECT *
    FROM Vendas;
END;
GO
/****** Object:  StoredProcedure [dbo].[spListagemVendedores]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[spListagemVendedores]
as
select * from vendedores
GO
/****** Object:  StoredProcedure [dbo].[spProximoId]    Script Date: 21/05/2024 00:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spProximoId]
(@tabela varchar(max))
as
begin
 exec('select isnull(max(id) +1, 1) as MAIOR from '
+@tabela)
end
GO
USE [master]
GO
ALTER DATABASE [AulaDB] SET  READ_WRITE 
GO
