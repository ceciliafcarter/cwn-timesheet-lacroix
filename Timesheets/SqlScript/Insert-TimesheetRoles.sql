USE [United]

INSERT INTO dbo.tblRole (Title,Description, ApplicationId, Version, ModifiedByMasterUserId, ModifiedDatetime,CreatedByMasterUserId,CreatedDatetime)
Values ('Timesheet Admin', 'Timesheet Admin',700,1,4997,getutcdate(),4997,getutcdate())

INSERT INTO dbo.tblRole (Title,Description, ApplicationId, Version, ModifiedByMasterUserId, ModifiedDatetime,CreatedByMasterUserId,CreatedDatetime)
Values ('Timesheet User', 'Timesheet User',700,1,4997,getutcdate(),4997,getutcdate())

INSERT INTO dbo.tblRole (Title,Description, ApplicationId, Version, ModifiedByMasterUserId, ModifiedDatetime,CreatedByMasterUserId,CreatedDatetime)
Values ('Timesheet Manager', 'Timesheet Manager',700,1,4997,getutcdate(),4997,getutcdate())

--SELECT * FROM dbo.tblRole


--Add Timesheet to the application list
INSERT INTO dbo.tblApplication (ApplicationID, ApplicationTypeID, Title, Description, Version, ModifiedByMasterUserID, ModifiedDatetime,
		CreatedByMasterUserID, CreatedDatetime)
Values (700, 2, 'CWN Timesheet', 'CWN Timesheet', 1, 4997, GETUTCDATE(), 4997, GETUTCDATE())
