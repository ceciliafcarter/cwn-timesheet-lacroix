USE [United]
GO
/****** Object:  StoredProcedure [dbo].[spTSLoadIndividualMasterUserEmployeeInfoMapping]    Script Date: 1/6/2016 5:52:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE Procedure [dbo].[spTSLoadIndividualMasterUserEmployeeInfoMapping]

as

set nocount on

merge tblTSEmployeeInfo tt
using (
	select distinct i.MasterUserId, i.IndividualId, mu.UserName, mu.DomainName
	from dbo.tblIndividual i
	join dbo.tblMasterUser mu on i.MasterUserId = mu.MasterUserId
	join dbo.tblMasterUserRole mur on i.MasterUserId = mur.MasterUserId
	where roleId > 211
) st on (tt.MasterUserId = st.MasterUserId)
when not matched then
insert (MasterUserId, intEmployeeId, txtUserId, txtDomain, CompanyCodeId, PreviousExperience, AutoAudit_CreatedDate,
AutoAudit_CreatedBy,AutoAudit_ModifiedDate,AutoAudit_ModifiedBy)
values (st.MasterUserId, st.IndividualId, st.UserName,st.DomainName, 1, -1,getdate(),4997,getdate(), 4997);



