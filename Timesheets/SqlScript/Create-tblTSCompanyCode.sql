USE [United]
GO

/****** Object:  Table [dbo].[tblTSCompanyCode]    Script Date: 1/14/2016 4:43:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblTSCompanyCode](
	[CompanyCodeID] [int] IDENTITY(1,1) NOT NULL,
	[txtCompanyCode] [nvarchar](250) NULL,
	[txtCompanyName] [nvarchar](250) NULL,
	[txtCompanyStatus] [nvarchar](250) NULL,
	[txtCompanyWebsite] [nvarchar](250) NULL,
	[txtCompanyAbbreviation] [nvarchar](25) NULL,
	[chkTimesheetSystem] [smallint] NULL CONSTRAINT [eConstraintCompany_InformationchkTimesheetSystem]  DEFAULT ((0)),
	[txtNewCompanyIdentifier] [varchar](36) NULL,
PRIMARY KEY CLUSTERED 
(
	[CompanyCodeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


