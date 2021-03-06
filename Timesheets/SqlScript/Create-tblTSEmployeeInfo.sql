USE [United]
GO
/****** Object:  Table [dbo].[tblTSEmployeeInfo]    Script Date: 12/16/2015 11:13:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTSEmployeeInfo](
	[EmployeeInfoId] [int] IDENTITY(1,1) NOT NULL,
	[MasterUserID] [int] NOT NULL,
	[CompanyCodeId] [int] NOT NULL,
	intEmployeeId [int] NOT NULL,

	[HRBP] [bit] NULL,
	[IsNewPosition] [bit] NULL DEFAULT ((0)),
	[ReplacingMasterUserId] [int] NULL,
	DateOfWelcomeEmail datetime NULL,
	DateOfNewHireFormSent datetime NULL,
	DateOfEnteredInPayForce datetime NULL,
	DateOfTimeSaverReminder datetime NULL,
	DateOfBackgroundCheck datetime NULL,
	DateOfEVerify datetime NULL,
	DatePopcornSent Datetime NULL,
	WorkStateID [int] NULL DEFAULT ((0)),
	ReasonForTermination varchar(MAX) NULL,
	SpecialPayIssues varchar(MAX) NULL,
	IsLetterReceived [bit] DEFAULT ((0)),
	IsNopaReceived [bit] DEFAULT ((0)),
	DateOfEmailSentToTechOps datetime NULL,
	DateOfExitInterview datetime NULL,
	DateOfInformationToPayroll datetime NULL,
	DateOfPTOPayout datetime NULL,
	IsNonDisputeUnemployment [bit] NULL,

	[chkBenefitEligible] [smallint] NULL,
	[chkPhotoShowExternal] [smallint] NULL,
	[chkPhotoShowInternal] [smallint] NULL,

	[intHRSupervisor] [nvarchar](250) NULL,
	[memBiography] [ntext] NULL,
	[memHRDelegate] [ntext] NULL,
	[realFTE] [float] NULL,
	[realMaxTimeOffPerWeek] [float] NULL,
	[txtDomain] [nvarchar](250) NULL,
	[txtNewOrRehire] [nvarchar](250) NULL,
	[txtOfficer] [nvarchar](250) NULL,

	[txtPhotoHighResolution] [nvarchar](250) NULL,
	[txtPhotoWeb] [nvarchar](250) NULL,

	IsNonExempt [bit] DEFAULT ((1)),

	[txtUserID] [nvarchar](250) NOT NULL,
	[txtUserIDFics] [nvarchar](250) NULL,
	[txtAutograph] [nvarchar](250) NULL,
	[FileNumber] [int] NULL,
	[realHoursPerWeek] [float] NULL,
	[memTemp] [ntext] NULL,
	[memTemp2] [ntext] NULL,
	[chkProcessAsNewEmployee] [smallint] NULL,
	[chkPositionChange] [smallint] NULL,
	[chkTimesheetAdmin] [smallint] NULL,
	[dtmTempStartDate] [datetime] NULL,
	[txtEmploymentType] [nvarchar](250) NULL,

	[txtNewEmployeeIdentifier] [nvarchar](36) NULL,
	[ManagerComments] [nvarchar](max) NULL,
	[ITComments] [nvarchar](max) NULL,
	[PhysicalLocation] [nvarchar](250) NULL,
	[PreviousExperience] [int] NULL,
	[TemplateId] [uniqueidentifier] NULL,
	[ComputerSetupId] [uniqueidentifier] NULL,
	[AutoAudit_CreatedDate] [datetime] NOT NULL,
	[AutoAudit_CreatedBy] [nvarchar](128) NOT NULL,
	[AutoAudit_ModifiedDate] [datetime] NOT NULL,
	[AutoAudit_ModifiedBy] [nvarchar](128) NOT NULL,
	[AutoAudit_RowVersion] [int] NULL,
	[AccountSetupId] [uniqueidentifier] NULL,
	[PhonePassCode] [nvarchar](50) NULL,
	[BenefitEligible] [bit] NULL,
	[TimesheetAdmin] [bit] NULL,
	[EmployeeTerminationid] [uniqueidentifier] NULL,
	[UploadToExternalWebSite] [bit] NULL,
	[Freddie_Mac_Signatory] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeInfoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 95) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]




ALTER TABLE [dbo].[tblTSEmployeeInfo]  WITH CHECK ADD  CONSTRAINT [FK_tblTSEmployeeInfo_tblIndividual] FOREIGN KEY([intEmployeeID])
REFERENCES [dbo].[tblIndividual] ([IndividualID])
GO

ALTER TABLE [dbo].[tblTSEmployeeInfo] CHECK CONSTRAINT [FK_tblTSEmployeeInfo_tblIndividual]
GO

ALTER TABLE [dbo].[tblTSEmployeeInfo]  WITH CHECK ADD  CONSTRAINT [FK_tblTSEmployeeInfo_tblMasterUser] FOREIGN KEY([MasterUserID])
REFERENCES [dbo].[tblMasterUser] ([MasterUserID])
GO

ALTER TABLE [dbo].[tblTSEmployeeInfo] CHECK CONSTRAINT [FK_tblTSEmployeeInfo_tblMasterUser]
GO