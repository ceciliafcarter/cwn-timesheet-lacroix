
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Create date: 1/25/2016
-- Description:	Get the Current, Next and Previous Pay Period
-- =============================================

CREATE PROCEDURE dbo.spTSGetCurrentNextPreviousPayPeriod
	@Debug int = 0
AS
BEGIN

declare @currentDate datetime
declare @nextStartDate datetime
declare @previousEndDate datetime
set @currentDate = CAST(GETUTCDATE() AS date);

DECLARE @TempTable Table(
	PayPeriodId int,
	dtmPeriodStart datetime,
	dtmPeriodEnd datetime,
	TimePeriod varchar(25)
)

-- Current PayPeriod
INSERT INTO @TempTable(PayPeriodId, dtmPeriodStart, dtmPeriodEnd, TimePeriod)
Select 
a.PayPeriodID, a.dtmPeriodStart, a.dtmPeriodEnd, 'Current'
from dbo.tblTSPayPeriod a
where dtmPeriodStart <= @currentDate and dtmPeriodEnd >= @currentDate


select @nextStartDate = DateAdd(dd, 1,dtmPeriodEnd) from @TempTable
select @previousEndDate = DateAdd(dd, -1, dtmPeriodStart) from @TempTable


-- Next PayPeriod
INSERT INTO @TempTable(PayPeriodId, dtmPeriodStart, dtmPeriodEnd, TimePeriod)
Select a.PayPeriodID, a.dtmPeriodStart, a.dtmPeriodEnd, 'Next'
from dbo.tblTSPayPeriod a
where a.dtmPeriodStart = @nextStartDate

-- Previous PayPeriod
INSERT INTO @TempTable(PayPeriodId, dtmPeriodStart, dtmPeriodEnd, TimePeriod)
Select a.PayPeriodID, a.dtmPeriodStart, a.dtmPeriodEnd, 'Previous'
from dbo.tblTSPayPeriod a
where a.dtmPeriodEnd = @previousEndDate

IF(@Debug > 0)
	SELECT @nextStartDate, @previousEndDate, * FROM @TempTable

SELECT a.[PayPeriodID]
      ,a.[dtmPeriodStart]
      ,a.[dtmPeriodEnd]
      ,[dtmPeriodDue]
      ,[dtmPeriodPayDay]
      ,[dtmProcessed]
      ,[txtLastPeriodOfYear]
      ,[txtStatus]
      ,[IsBiWeeklyPayroll]
	  ,b.TimePeriod
  FROM [United].[dbo].[tblTSPayPeriod] a
  INNER JOIN @TempTable b ON a.PayPeriodID = b.PayPeriodId

  END