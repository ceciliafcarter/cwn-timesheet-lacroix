USE [United]
GO

/****** Object:  Table [dbo].[tblTSHoursType]    Script Date: 1/5/2016 9:11:14 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblTSHoursType](
	[HoursTypeID] [int] IDENTITY(1,1) NOT NULL,
	[HoursType] [nvarchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[HoursTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


/*Populate table*/

IF object_id('tblTSHoursType') is not null
BEGIN
	INSERT dbo.tblTSHoursType (HoursType)
	VALUES ('Regular');
	INSERT dbo.tblTSHoursType (HoursType)
	VALUES ('PTO');
	INSERT dbo.tblTSHoursType (HoursType)
	VALUES ('Volunteer PTO');
	INSERT dbo.tblTSHoursType (HoursType)
	VALUES ('Jury Duty');
	INSERT dbo.tblTSHoursType (HoursType)
	VALUES ('Bereavement');
	INSERT dbo.tblTSHoursType (HoursType)
	VALUES ('Unpaid');
	INSERT dbo.tblTSHoursType (HoursType)
	VALUES ('On Call');
	INSERT dbo.tblTSHoursType (HoursType)
	VALUES ('Mileage');
END