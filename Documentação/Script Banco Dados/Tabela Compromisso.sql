USE [TesteThoth]
GO

DROP TABLE [dbo].[Compromisso]
Go

/****** Object:  Table [dbo].[Compromisso]    Script Date: 24/04/2025 16:52:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Compromisso](
	[IdUsuario] [int] NOT NULL,
	[IdCompromisso] [int] NOT NULL IDENTITY(1, 1),
	[DataCompromisso] [date] NULL,
	[HorarioInicial] [char](5) NULL,
	[HorarioFinal] [char](5) NULL,
	[DiaInteiro] [char](1) NULL,
	[Descricao] [nvarchar](200) NULL,
	[Local] [nvarchar](200) NULL,
 CONSTRAINT [PK_Compromisso] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC,
	[IdCompromisso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


