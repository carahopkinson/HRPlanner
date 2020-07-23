USE [HRPlanner]
GO

/****** Object:  Table [dbo].[UserTrainingCourses]    Script Date: 13/07/2020 17:04:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UserTrainingCourses](
	[UserTrainingCourse_PK] [int] IDENTITY(1,1) NOT NULL,
	[TrainingCourse_FK] [int] NOT NULL,
	[User_FK] [int] NOT NULL,
	[DateCompleted] [date] NULL,
	[DatesExpires] [date] NULL,
 CONSTRAINT [PK_UserTrainingCourse] PRIMARY KEY CLUSTERED 
(
	[UserTrainingCourse_PK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


