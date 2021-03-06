USE [United]
GO

/****** Object:  Table [dbo].[tblTSPayPeriod]    Script Date: 1/4/2016 4:55:20 PM ******/
DROP TABLE [dbo].[tblTSPayPeriod]
GO

/****** Object:  Table [dbo].[tblTSPayPeriod]    Script Date: 1/4/2016 4:55:20 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblTSPayPeriod](
	[PayPeriodID] [int] IDENTITY(1,1) NOT NULL,
	[clpCSV] [nvarchar](250) NULL,
	[dtmPeriodDue] [datetime] NULL,
	[dtmPeriodEnd] [datetime] NULL,
	[dtmPeriodPayDay] [datetime] NULL,
	[dtmPeriodStart] [datetime] NULL,
	[dtmProcessed] [datetime] NULL,
	[txtLastPeriodOfYear] [nvarchar](250) NULL,
	[txtStatus] [nvarchar](250) NULL,
	[dtmReminderAllEmployees] [datetime] NULL,
	[dtmReminderAllNonExempt] [datetime] NULL,
	[dtmReminderUnApproved] [datetime] NULL,
	[dtmReminderUnSubmittedNonExempt] [datetime] NULL,
	[txtVerifyDelete] [nvarchar](250) NULL,
	[chkDateConflict] [smallint] NULL,
	[clpCSVNonExempt] [nvarchar](250) NULL,
	[dtm1stReminder] [datetime] NULL,
	[dtm2ndReminder] [datetime] NULL,
	[dtmApprovalDueDate] [datetime] NULL,
	[dtmCutOffDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[PayPeriodID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 95) ON [PRIMARY]
) ON [PRIMARY]

GO


