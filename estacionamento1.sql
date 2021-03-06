USE [master]
GO
/****** Object:  Database [bdEstacionamento1]    Script Date: 04/09/2020 22:25:56 ******/
CREATE DATABASE [bdEstacionamento1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'bdEstacionamento1', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\bdEstacionamento1.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'bdEstacionamento1_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\bdEstacionamento1_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [bdEstacionamento1] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bdEstacionamento1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bdEstacionamento1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bdEstacionamento1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bdEstacionamento1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bdEstacionamento1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bdEstacionamento1] SET ARITHABORT OFF 
GO
ALTER DATABASE [bdEstacionamento1] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [bdEstacionamento1] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [bdEstacionamento1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bdEstacionamento1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bdEstacionamento1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bdEstacionamento1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bdEstacionamento1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bdEstacionamento1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bdEstacionamento1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bdEstacionamento1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bdEstacionamento1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [bdEstacionamento1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bdEstacionamento1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bdEstacionamento1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bdEstacionamento1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bdEstacionamento1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bdEstacionamento1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bdEstacionamento1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bdEstacionamento1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [bdEstacionamento1] SET  MULTI_USER 
GO
ALTER DATABASE [bdEstacionamento1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bdEstacionamento1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bdEstacionamento1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bdEstacionamento1] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [bdEstacionamento1]
GO
/****** Object:  StoredProcedure [dbo].[AlterarCliente]    Script Date: 04/09/2020 22:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	
create procedure [dbo].[AlterarCliente]
@nome varchar(100)
,@cpf varchar(14) 
,@rg varchar(15)
,@telefone varchar(14)
,@idCliente int
as
begin
	update tbClienteMensal set nomeClienteMensal = @nome, cpfClienteMensal = @cpf, rgClienteMensal = @rg, telefoneClienteMensal = @telefone where codClienteMensal = @idCliente
end
return print('Cliente Alterado')


GO
/****** Object:  StoredProcedure [dbo].[AlterarFuncionario]    Script Date: 04/09/2020 22:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create procedure [dbo].[AlterarFuncionario]
@nome varchar(100)
,@cpf varchar(14) 
,@rg varchar(15)
,@sexo varchar(15)
,@telefone varchar(14)
,@login varchar(80)
,@senha varchar(15)
,@cargo varchar(30)
,@idFuncionario int
as
begin
declare @idCargo int
	set @idCargo = (select codCargo from tbCargo where descricaoCargo like @cargo)
	

	update tbFuncionario set nomeFuncionario = @nome, cpfFuncionario = @cpf, rgFuncionario = @rg, sexoFuncionario = @sexo, telefoneFuncionario = @telefone, loginUsuario = @login, senhaUsuario = @senha, codCargo = @idCargo where codFuncionario = @idFuncionario

end
return print('Funcionario Alterado')

GO
/****** Object:  StoredProcedure [dbo].[CadastroCarroClienteMensal]    Script Date: 04/09/2020 22:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create procedure [dbo].[CadastroCarroClienteMensal]
@placa varchar(8)
,@modelo varchar(30)
,@cor varchar(15)
as
begin
	declare @idModelo int
	declare @idCor int

	set @idModelo = (select codModelo from tbModelo where descricaoModelo like @modelo)
	set @idCor = (select codCor from tbCor where cor like @cor)

	insert into tbCarrosClienteMensal (placaCarrosClienteMensal, codModelo, codCor) values(@placa, @idModelo, @idCor)
end

GO
/****** Object:  StoredProcedure [dbo].[CadastroCompletoCarro]    Script Date: 04/09/2020 22:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





create procedure [dbo].[CadastroCompletoCarro]
@placa varchar(8) 
as
begin
	if exists(select placaCarrosClienteMensal from tbCarrosClienteMensal)
	begin
		declare @cliente int
		set @cliente = (select max(codClienteMensal) from tbClienteMensal)
		

		update tbCarrosClienteMensal set codClienteMensal = @cliente where placaCarrosClienteMensal = @placa
	end
end

GO
/****** Object:  StoredProcedure [dbo].[CadastroFuncionario]    Script Date: 04/09/2020 22:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





create procedure [dbo].[CadastroFuncionario]
@nome varchar(100)
,@cpf varchar(14) 
,@rg varchar(15)
,@sexo varchar(15)
,@telefone varchar(14)
,@login varchar(80)
,@senha varchar(15)
,@cargo varchar(30)
as
begin
declare @idCargo int

	set @idCargo = (select codCargo from tbCargo where descricaoCargo like @cargo)

	insert into tbFuncionario(nomeFuncionario, cpfFuncionario, rgFuncionario, sexoFuncionario, telefoneFuncionario, loginUsuario, senhaUsuario, codCargo) values (@nome, @cpf, @rg, @sexo, @telefone, @login, @senha, @idCargo)
	 
end
return print('Funcionario Cadastrado')

GO
/****** Object:  StoredProcedure [dbo].[EntradaCarro]    Script Date: 04/09/2020 22:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[EntradaCarro]
@placa varchar(8)
,@datahora smalldatetime
as
begin

if(exists(select placaEntradaCarro from tbEntradaCarro where placaEntradaCarro like @placa))
begin
	print('Carro já ta ai')
end
else
begin
	insert into tbEntradaCarro(placaEntradaCarro, dataHoraEntradaCarro) values (@placa, @datahora)
end
end

GO
/****** Object:  StoredProcedure [dbo].[LimpaCarro]    Script Date: 04/09/2020 22:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[LimpaCarro]
@placa varchar(8)
as
begin
	delete from tbEntradaCarro where placaEntradaCarro like @placa
	delete from tbSaidaCarro where placaSaidaCarro like @placa
end

GO
/****** Object:  StoredProcedure [dbo].[RemoveCliente]    Script Date: 04/09/2020 22:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





create procedure [dbo].[RemoveCliente]
@id int
as
begin
	delete from tbCarrosClienteMensal where codClienteMensal = @id
	delete from tbClienteMensal where codClienteMensal = @id
	
end
return print('Cliente removido')

GO
/****** Object:  StoredProcedure [dbo].[SaidaCarro]    Script Date: 04/09/2020 22:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[SaidaCarro]
@placa varchar(8)
,@dataHora smalldatetime
as
begin
declare @horasa int
declare @minsa int
declare @minen int
declare @horaen int

declare @calchoras int
declare @calcmin int

declare @anos int
declare @meses int
declare @dias int
declare @valorsaida numeric(10,2)
declare @valormensal numeric(10,2)
declare @valorhora numeric(10,2)
declare @valorentrada numeric(10,2)
	
	set @valorhora = (select valorHora from tbValores where codValores = 1)
	set @valormensal = (select valorMensal from tbValores where codValores = 1)
	set @valorentrada = (select valorEntrada from tbValores where codValores = 1)
	set @valorsaida = 0.00
	
if((select count(placaEntradaCarro) from tbEntradaCarro) < 40)
begin
	if(exists(select placaEntradaCarro from tbEntradaCarro where placaEntradaCarro = @placa))
		begin

		insert into tbSaidaCarro(placaSaidaCarro, dataHoraSaidaCarro, valorSaidaCarro) values(@placa, @dataHora, @valorsaida)
				set @horasa = (select cast(substring(CONVERT(varchar(3), dataHoraSaidaCarro, 114), 1, 2) as int) from tbSaidaCarro where placaSaidaCarro = @placa)
				set @minsa = (select cast(substring(CONVERT(varchar(3), dataHoraSaidaCarro, 114), 4, 2) as int) from tbSaidaCarro where placaSaidaCarro = @placa)

				set @horaen = (select cast(substring(CONVERT(varchar(3), dataHoraEntradaCarro, 114), 1, 2) as int) from tbEntradaCarro where placaEntradaCarro = @placa)
				set @minen = (select cast(substring(CONVERT(varchar(3), dataHoraEntradaCarro, 114), 4, 2) as int) from tbEntradaCarro where placaEntradaCarro = @placa)

				set @dias = ((select cast(day(dataHoraSaidaCarro)as int) from tbSaidaCarro where placaSaidaCarro = @placa) - (select cast(day(dataHoraEntradaCarro)as int) from tbEntradaCarro where placaEntradaCarro = @placa))
				set @meses = ((select cast(month(dataHoraSaidaCarro)as int) from tbSaidaCarro where placaSaidaCarro = @placa) - (select cast(month(dataHoraEntradaCarro)as int) from tbEntradaCarro where placaEntradaCarro = @placa))
				set @anos = ((select cast(year(dataHoraSaidaCarro)as int) from tbSaidaCarro where placaSaidaCarro = @placa) - (select cast(year(dataHoraEntradaCarro)as int) from tbEntradaCarro where placaEntradaCarro = @placa))
				
				if(@horasa > @horaen)
					begin

						set @calchoras = (@horasa - @horaen)


						if(@minsa > 0)
							begin
							set @calchoras = (@calchoras + 1) * @valorhora

								set @valorsaida = (@valorentrada + @calchoras + (((@valorhora * 24) * @dias) + (@valormensal * @meses) + ((@valormensal * 12) * @anos)))
								print('entrouhora')
								--update tbSaidaCarro set placaSaidaCarro = @placa, dataHoraSaidaCarro = @dataHora, valorSaidaCarro = @valorsaida where placaSaidaCarro = @placa
								update tbSaidaCarro set valorSaidaCarro = @valorsaida where placaSaidaCarro like @placa
							end
						else
							begin	
								set @calchoras = @calchoras * @valorhora
								set @valorsaida = (@valorentrada + @calchoras + ((@valorhora * 24) * @dias) + (@valormensal * @meses) + ((@valormensal * 12) * @anos))
								--set @valorsaida = 10.0
								print('entrouhora2')
								--update tbSaidaCarro set placaSaidaCarro = @placa, dataHoraSaidaCarro = @dataHora, valorSaidaCarro = @valorsaida where placaSaidaCarro = @placa
								update tbSaidaCarro set valorSaidaCarro = @valorsaida where placaSaidaCarro like @placa
							end
					end
				else
				begin
					set @calchoras = (@horaen - @horasa)
					
					if(@minsa > 0)
						begin
						set @calchoras = (@calchoras + 1) * @valorhora
							
							set @valorsaida = (@valorentrada + @calchoras + ((@valorhora * 24) * @dias) + (@valormensal * @meses) + ((@valormensal * 12) * @anos))
							print('entrou min')
							--update tbSaidaCarro set placaSaidaCarro = @placa, dataHoraSaidaCarro = @dataHora, valorSaidaCarro = @valorsaida where placaSaidaCarro = @placa
							update tbSaidaCarro set valorSaidaCarro = @valorsaida where placaSaidaCarro like @placa
						end
					else
						begin	
							set @calchoras = @calchoras * @valorhora
							set @valorsaida = (@valorentrada + @calchoras + ((@valorhora * 24) * @dias) + (@valormensal * @meses) + ((@valormensal * 12) * @anos))							
							print('entrou min2')
							update tbSaidaCarro set valorSaidaCarro = @valorsaida where placaSaidaCarro like @placa
						end

				end
			end									
else
	begin
		print('Carro não encontrado')
	end
end
else
begin
	print('Não há vagas')
end
end

GO
/****** Object:  Table [dbo].[tbCargo]    Script Date: 04/09/2020 22:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbCargo](
	[codCargo] [int] IDENTITY(1,1) NOT NULL,
	[descricaoCargo] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[codCargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbCarrosClienteMensal]    Script Date: 04/09/2020 22:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbCarrosClienteMensal](
	[codCarrosClienteMensal] [int] IDENTITY(1,1) NOT NULL,
	[placaCarrosClienteMensal] [varchar](8) NULL,
	[codModelo] [int] NULL,
	[codCor] [int] NULL,
	[codClienteMensal] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[codCarrosClienteMensal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbClienteMensal]    Script Date: 04/09/2020 22:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbClienteMensal](
	[codClienteMensal] [int] IDENTITY(1,1) NOT NULL,
	[nomeClienteMensal] [varchar](100) NULL,
	[cpfClienteMensal] [varchar](14) NULL,
	[rgClienteMensal] [varchar](15) NULL,
	[telefoneClienteMensal] [varchar](14) NULL,
PRIMARY KEY CLUSTERED 
(
	[codClienteMensal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbCor]    Script Date: 04/09/2020 22:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbCor](
	[codCor] [int] IDENTITY(1,1) NOT NULL,
	[cor] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[codCor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbEntradaCarro]    Script Date: 04/09/2020 22:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbEntradaCarro](
	[codEntradaCarro] [int] IDENTITY(1,1) NOT NULL,
	[placaEntradaCarro] [varchar](8) NULL,
	[dataHoraEntradaCarro] [smalldatetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[codEntradaCarro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbFuncionario]    Script Date: 04/09/2020 22:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbFuncionario](
	[codFuncionario] [int] IDENTITY(1,1) NOT NULL,
	[nomeFuncionario] [varchar](100) NULL,
	[cpfFuncionario] [varchar](14) NULL,
	[rgFuncionario] [varchar](15) NULL,
	[sexoFuncionario] [varchar](10) NULL,
	[telefoneFuncionario] [varchar](14) NULL,
	[loginUsuario] [varchar](80) NULL,
	[senhaUsuario] [varchar](15) NULL,
	[codCargo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[codFuncionario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbModelo]    Script Date: 04/09/2020 22:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbModelo](
	[codModelo] [int] IDENTITY(1,1) NOT NULL,
	[descricaoModelo] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[codModelo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbSaidaCarro]    Script Date: 04/09/2020 22:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbSaidaCarro](
	[codSaidaCarro] [int] IDENTITY(1,1) NOT NULL,
	[placaSaidaCarro] [varchar](8) NULL,
	[dataHoraSaidaCarro] [smalldatetime] NULL,
	[valorSaidaCarro] [numeric](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[codSaidaCarro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbValores]    Script Date: 04/09/2020 22:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbValores](
	[codValores] [int] IDENTITY(1,1) NOT NULL,
	[valorEntrada] [numeric](10, 2) NULL,
	[valorHora] [numeric](10, 2) NULL,
	[valorMensal] [numeric](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[codValores] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[tbCarrosClienteMensal]  WITH CHECK ADD FOREIGN KEY([codClienteMensal])
REFERENCES [dbo].[tbClienteMensal] ([codClienteMensal])
GO
ALTER TABLE [dbo].[tbCarrosClienteMensal]  WITH CHECK ADD FOREIGN KEY([codCor])
REFERENCES [dbo].[tbCor] ([codCor])
GO
ALTER TABLE [dbo].[tbCarrosClienteMensal]  WITH CHECK ADD FOREIGN KEY([codModelo])
REFERENCES [dbo].[tbModelo] ([codModelo])
GO
ALTER TABLE [dbo].[tbFuncionario]  WITH CHECK ADD FOREIGN KEY([codCargo])
REFERENCES [dbo].[tbCargo] ([codCargo])
GO
USE [master]
GO
ALTER DATABASE [bdEstacionamento1] SET  READ_WRITE 
GO
