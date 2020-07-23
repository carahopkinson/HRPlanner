USE [HRPlanner]
GO

/****** Object:  Table [dbo].[Holidays]    Script Date: 13/07/2020 17:06:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Holidays](
	[Holiday_PK] [int] IDENTITY(1,1) NOT NULL,
	[User_FK] [int] NOT NULL,
	[DateFrom] [date] NOT NULL,
	[DateTo] [date] NOT NULL,
	[Days] [int] NULL,
 CONSTRAINT [PK_Holidays] PRIMARY KEY CLUSTERED 
(
	[Holiday_PK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


