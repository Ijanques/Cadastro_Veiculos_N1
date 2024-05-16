USE [master]
GO
/****** Object:  Database [AulaDB]    Script Date: 15/05/2024 22:26:34 ******/
CREATE DATABASE [AulaDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AulaDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\AulaDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AulaDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\AulaDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [AulaDB] SET COMPATIBILITY_LEVEL = 160
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
/****** Object:  Table [dbo].[carros]    Script Date: 15/05/2024 22:26:35 ******/
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
/****** Object:  Table [dbo].[clientes]    Script Date: 15/05/2024 22:26:35 ******/
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
/****** Object:  Table [dbo].[motos]    Script Date: 15/05/2024 22:26:35 ******/
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
/****** Object:  Table [dbo].[vendedores]    Script Date: 15/05/2024 22:26:35 ******/
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
INSERT [dbo].[carros] ([Id], [Marca], [Modelo], [Placa], [Kilometragem], [Valor], [tipo]) VALUES (1, N'volkswagen', N'fox', N'aaa0000', CAST(15000.00 AS Decimal(19, 2)), CAST(50000.00 AS Decimal(19, 2)), N'hatch')
GO
INSERT [dbo].[clientes] ([id], [nome], [telefone], [VeiculosComprados]) VALUES (1, N'Jose', N'11999999', 0)
GO
INSERT [dbo].[vendedores] ([Id], [nome], [telefone], [Vendas]) VALUES (1, N'Evandro', N'9999999', 0)
GO
/****** Object:  StoredProcedure [dbo].[spAlteraCarro]    Script Date: 15/05/2024 22:26:35 ******/
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
/****** Object:  StoredProcedure [dbo].[spAlteraCliente]    Script Date: 15/05/2024 22:26:35 ******/
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
/****** Object:  StoredProcedure [dbo].[spAlteramoto]    Script Date: 15/05/2024 22:26:35 ******/
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
/****** Object:  StoredProcedure [dbo].[spAlteraVendedor]    Script Date: 15/05/2024 22:26:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spAlteraVendedor]
(
 @id int,
 @nome varchar(30),
 @telefone varchar(30),
 @Vendas int
)
as
begin
 update vendedores set
 nome = @nome, @telefone = @telefone, vendas = @vendas where id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[spConsultaCarro]    Script Date: 15/05/2024 22:26:35 ******/
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
/****** Object:  StoredProcedure [dbo].[spConsultacliente]    Script Date: 15/05/2024 22:26:35 ******/
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
/****** Object:  StoredProcedure [dbo].[spConsultamoto]    Script Date: 15/05/2024 22:26:35 ******/
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
/****** Object:  StoredProcedure [dbo].[spConsultavendedor]    Script Date: 15/05/2024 22:26:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spConsultavendedor]
(
 @id int
)
as
begin
 select * from motos where id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[spExcluiCarros]    Script Date: 15/05/2024 22:26:35 ******/
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
/****** Object:  StoredProcedure [dbo].[spExcluiCliente]    Script Date: 15/05/2024 22:26:35 ******/
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
/****** Object:  StoredProcedure [dbo].[spExcluiMoto]    Script Date: 15/05/2024 22:26:35 ******/
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
/****** Object:  StoredProcedure [dbo].[spExcluiVendedor]    Script Date: 15/05/2024 22:26:35 ******/
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
/****** Object:  StoredProcedure [dbo].[spIncluiCarro]    Script Date: 15/05/2024 22:26:35 ******/
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
/****** Object:  StoredProcedure [dbo].[spIncluiCliente]    Script Date: 15/05/2024 22:26:35 ******/
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
/****** Object:  StoredProcedure [dbo].[spIncluimoto]    Script Date: 15/05/2024 22:26:35 ******/
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
/****** Object:  StoredProcedure [dbo].[spIncluiVendedor]    Script Date: 15/05/2024 22:26:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spIncluiVendedor]
(
 @id int,
 @nome varchar(30),
 @telefone varchar(30),
 @vendas int
)
as
begin
 insert into vendedores
 (id, nome, telefone, vendas)
 values
 (@id, @nome, @telefone, @vendas)
end
GO
/****** Object:  StoredProcedure [dbo].[spListagemCarros]    Script Date: 15/05/2024 22:26:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[spListagemCarros]
as
select * from carros
GO
/****** Object:  StoredProcedure [dbo].[spListagemClientes]    Script Date: 15/05/2024 22:26:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[spListagemClientes]
as
select * from Clientes
GO
/****** Object:  StoredProcedure [dbo].[spListagemMotos]    Script Date: 15/05/2024 22:26:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[spListagemMotos]
as
select * from Motos
GO
/****** Object:  StoredProcedure [dbo].[spListagemVendedores]    Script Date: 15/05/2024 22:26:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[spListagemVendedores]
as
select * from vendedores
GO
/****** Object:  StoredProcedure [dbo].[spProximoId]    Script Date: 15/05/2024 22:26:35 ******/
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
