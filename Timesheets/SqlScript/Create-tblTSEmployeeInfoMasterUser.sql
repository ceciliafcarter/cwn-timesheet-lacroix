USE [United]
GO

/****** Object:  Table [dbo].[tblMasterUserRole]    Script Date: 12/16/2015 17:36:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblTSEmployeeInfoMasterUser](
	[MasterUserID] [int] NOT NULL,
	[EmployeeInfoID] [int] NOT NULL,
 CONSTRAINT [PK_tblTSEmployeeInfoMasterUser] PRIMARY KEY CLUSTERED 
(
	[MasterUserID] ASC,
	[EmployeeInfoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tblTSEmployeeInfoMasterUser]  WITH CHECK ADD  CONSTRAINT [FK_tblTSEmployeeInfoMasterUser_EmployeeInfoID] FOREIGN KEY([EmployeeInfoID])
REFERENCES [dbo].[tblMasterUser] ([MasterUserID])
GO

ALTER TABLE [dbo].[tblTSEmployeeInfoMasterUser] CHECK CONSTRAINT [FK_tblTSEmployeeInfoMasterUser_EmployeeInfoID]
GO


