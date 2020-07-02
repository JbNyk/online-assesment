USE [OnlineAssessment]
GO


CREATE TABLE [dbo].[tbl_Topics](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Questiontopic] [varchar](100) NOT NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_Topics] PRIMARY KEY CLUSTERED 
(
	[ID]
)
)
GO


