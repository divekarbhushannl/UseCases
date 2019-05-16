CREATE PROCEDURE [dbo].[uspInsertNewEmployee]
	@FirstName nvarchar(50),@LastName nvarchar(50),@Age int,@Salary numeric(18,2) = NULL
AS
BEGIN
INSERT INTO [dbo].[Employee] VALUES (@FirstName,@LastName,@Age,@Salary);  
SELECT SCOPE_IDENTITY()
END
