USE [United]
GO
/****** Object:  Table [dbo].[tblTSTimesheetHours]    Script Date: 12/17/2015 17:02:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTSTimesheetHours](
	[TimesheetHoursID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeInfoId] [int] NOT NULL,
	[PayPeriod] varchar(100) NULL,
	[ProcessedPayPeriod] varchar(100) NULL,
	[Date] [datetime] NOT NULL,
	[TimeStart] [int] NULL,
	[TimeEnd] [int] NULL,
	[Hours] [decimal](5, 2) NOT NULL,
	[HoursTypeID] int NOT NULL,
	[HoursRegular] [decimal](5, 2) NULL,
	[HoursHoliday] [decimal](5, 2) NULL,
	[HoursPTO] [decimal](5, 2) NULL,
	[HoursJuryDuty] [decimal](5, 2) NULL,
	[HoursBereavement] [decimal](5, 2) NULL,
	[HoursUnpaid] [decimal](5, 2) NULL,
	[HoursVolunteerPTO] [decimal](5, 2) NULL,
	[OnCall] bit NULL,
	[Mileage] float NULL,
	[Parking] decimal NULL,
	[StatusTypeId] int NULL,
	[EntryDate] [datetime] NOT NULL,
	[EntryUser] [varchar](250) NOT NULL,
	[SubmitDate] [datetime] NULL,
	[SubmitUser] [varchar](250) NULL,
	[ApproveDate] [datetime] NULL,
	[ApproveUser] [varchar](250) NULL,
	[ProcessDate] [datetime] NULL,
	[ProcessPayPeriod] [int] NULL,
	[LockOutEmployee] [bit] NOT NULL,
	[LockOutManager] [bit] NOT NULL,
	[LockOutAll] [bit] NOT NULL
 CONSTRAINT [PK_tblTSTimesheetHours] PRIMARY KEY CLUSTERED 
(
	[TimesheetHoursID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF

ALTER TABLE [dbo].[tblTSTimesheetHours]  WITH CHECK ADD  CONSTRAINT [FK_tblTSTimesheetHours_tblTSEmployeeInfo] FOREIGN KEY([EmployeeInfoId])
REFERENCES [dbo].[tblTSEmployeeInfo] ([EmployeeInfoId])
GO

ALTER TABLE [dbo].[tblTSTimesheetHours] CHECK CONSTRAINT [FK_tblTSTimesheetHours_tblTSEmployeeInfo]
GO

ALTER TABLE [dbo].[tblTSTimesheetHours]  WITH CHECK ADD  CONSTRAINT [FK_tblTSTimesheetHours_tblTSHoursType] FOREIGN KEY([HoursTypeID])
REFERENCES [dbo].[tblTSHoursType] ([HoursTypeID])
GO

ALTER TABLE [dbo].[tblTSTimesheetHours] CHECK CONSTRAINT [FK_tblTSTimesheetHours_tblTSHoursType]
GO

ALTER TABLE [dbo].[tblTSTimesheetHours]  WITH CHECK ADD  CONSTRAINT [FK_tblTSTimesheetHours_tblTSStatusType] FOREIGN KEY([StatusTypeId])
REFERENCES [dbo].[tblTSStatusType] ([StatusTypeID])
GO

ALTER TABLE [dbo].[tblTSTimesheetHours] CHECK CONSTRAINT [FK_tblTSTimesheetHours_tblTSStatusType]
GO