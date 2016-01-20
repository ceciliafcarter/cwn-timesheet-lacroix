USE [United]
GO

/****** Object:  Table [dbo].[tblTSStatusType]    Script Date: 1/5/2016 9:11:14 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblTSStatusType](
	[StatusTypeID] [int] IDENTITY(1,1) NOT NULL,
	[StatusType] [nvarchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[StatusTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


/*Populate table*/

IF object_id('tblTSStatusType') is not null
BEGIN
	INSERT dbo.tblTSStatusType (StatusType)
	VALUES ('Processed');
	INSERT dbo.tblTSStatusType (StatusType)
	VALUES ('Approved');
	INSERT dbo.tblTSStatusType (StatusType)
	VALUES ('Submitted');
	INSERT dbo.tblTSStatusType (StatusType)
	VALUES ('Non-Submitted');
END