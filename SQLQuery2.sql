USE [DeMon_Tutoring_Db]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_TblStaffing_InsertNotNulls]
		@firstName = N'Eugine',
		@lastName = N'Zuccerberg',
		@staffEmail = N'eugenefrisbee@gmail.com',
		@staffNumber = N'07974133370',
		@staffDOB = N'1000-08-09'

SELECT	@return_value as 'Return Value'

GO
