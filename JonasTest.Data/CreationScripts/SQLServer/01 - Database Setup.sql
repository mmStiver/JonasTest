CREATE DATABASE ScoreCard
GO

Use ScoreCard
Go

exec sp_configure 'contained database authentication', 1
go
reconfigure
go

alter database ScoreCard
set containment = partial
go

CREATE USER cscUser WITH PASSWORD = 'cscUser'
GO

CREATE SCHEMA cscData AUTHORIZATION cscUser
GO

--logging site
CREATE TABLE [dbo].[ApplicationLog] (
	  [Id] [int] IDENTITY(1,1) NOT NULL,
	  [MachineName] [nvarchar](50) NOT NULL,
	  [Logged] [datetime] NOT NULL,
	  [Level] [nvarchar](50) NOT NULL,
	  [Message] [nvarchar](max) NOT NULL,
	  [Logger] [nvarchar](250) NULL,
	  [Callsite] [nvarchar](max) NULL,
	  [Exception] [nvarchar](max) NULL,
    CONSTRAINT [PK_dbo.Log] PRIMARY KEY CLUSTERED ([Id] ASC)
      WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
  ) ON [PRIMARY]
