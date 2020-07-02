USE [OnlineAssessment]
GO


CREATE TABLE [dbo].[tbl_Questions](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[QuestionTopic] [varchar](100) NOT NULL,
	[Difficulty] [varchar](50) NOT NULL,
	[Type] [varchar](50) NOT NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_Questions] PRIMARY KEY CLUSTERED 
(
	[ID]
)
)
GO


