-- =============================================
-- Author:		<Author:Bhushan Divekar>
-- Create date: <Create Date : 15/05/2019>
-- Description:	<Description: Update Salary Information in Emplyee table>
-- =============================================
CREATE PROCEDURE uspUpdateSalaryInformation 
	-- Add the parameters for the stored procedure here
	 @FirstName nvarchar(50),@LastName nvarchar(50),@Age int,@Salary numeric(18,2)	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Update statements for procedure here
	
	Update Employee
		SET Salary = @Salary 
	Where 
		FirstName=@FirstName and
		LastName=@LastName and
		Age=@Age and
		Salary is NULL

END
