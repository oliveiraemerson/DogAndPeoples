USE [DogAndPeoples]
GO

/****** Object:  Table [dbo].[Caes_Dono]    Script Date: 27/05/2021 14:20:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Caes_Dono](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_dono] [int] NOT NULL,
	[Id_cao] [int] NOT NULL,
 CONSTRAINT [PK_Caes_Dono] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Caes_Dono]  WITH CHECK ADD  CONSTRAINT [FK_Caes_Dono_Caes] FOREIGN KEY([Id_cao])
REFERENCES [dbo].[Caes] ([Id])
GO

ALTER TABLE [dbo].[Caes_Dono] CHECK CONSTRAINT [FK_Caes_Dono_Caes]
GO

ALTER TABLE [dbo].[Caes_Dono]  WITH CHECK ADD  CONSTRAINT [FK_Caes_Dono_Donos] FOREIGN KEY([Id_dono])
REFERENCES [dbo].[Donos] ([Id])
GO

ALTER TABLE [dbo].[Caes_Dono] CHECK CONSTRAINT [FK_Caes_Dono_Donos]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id Caes Dono' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Caes_Dono', @level2type=N'COLUMN',@level2name=N'Id'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id Dono' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Caes_Dono', @level2type=N'COLUMN',@level2name=N'Id_dono'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id Cão' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Caes_Dono', @level2type=N'COLUMN',@level2name=N'Id_cao'
GO


