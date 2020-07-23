USE [HRPlanner]
GO

/****** Object:  Table [dbo].[TrainingCourses]    Script Date: 13/07/2020 17:04:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TrainingCourses](
	[TrainingCourse_PK] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Description] [varchar](50) NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_TrainingCourse] PRIMARY KEY CLUSTERED 
(
	[TrainingCourse_PK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


