-- =============================================
-- Author:		<Author:Bhushan Divekar>
-- Create date: <Create Date :15/05/2019>
-- Description:	<Description :Calacuate Salary>
-- =============================================
CREATE FUNCTION udfCalaculateSalary 
(
	-- Add the parameters for the function here
	 @FirstName varchar(50),
	 @LastName varchar(50),
	 @Age int,
	 @Length Numeric(4,2)
)
RETURNS Numeric(18,0)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Salary Numeric(18,0)
	DECLARE @Constant int

	SELECT @Salary = 0
	-- Add the T-SQL statements to compute the return value here
	IF @Age >0 AND @Length>=0
	BEGIN
	SET @Constant = (CASE 
						WHEN @Age BETWEEN 15 AND 25 AND @Length BETWEEN 0 AND 1.99 THEN 500
						WHEN @Age BETWEEN 15 AND 25 AND @Length BETWEEN 2 AND 4.99 THEN 1000
						WHEN @Age BETWEEN 15 AND 25 AND @Length BETWEEN 5 AND 8 THEN 1500
						WHEN @Age BETWEEN 26 AND 45 AND @Length BETWEEN 0 AND 1.99 THEN 2000
						WHEN @Age BETWEEN 26 AND 45 AND @Length BETWEEN 2 AND 4.99 THEN 2500
						WHEN @Age BETWEEN 26 AND 45 AND @Length BETWEEN 5 AND 8 THEN 3000
						WHEN @Age BETWEEN 46 AND 65 AND @Length BETWEEN 0 AND 1.99 THEN 3500
						WHEN @Age BETWEEN 46 AND 65 AND @Length BETWEEN 2 AND 4.99 THEN 4000
						WHEN @Age BETWEEN 46 AND 65 AND @Length BETWEEN 5 AND 8 THEN 4500
						WHEN @Age >65 AND  @Length BETWEEN 0 AND 1.99 THEN 5000
						WHEN @Age >65 AND  @Length BETWEEN 2 AND 4.99 THEN 5500
						WHEN @Age >65 AND  @Length BETWEEN 5 AND 8 THEN 6000
						ELSE 4000
					 END
					)
		SELECT @Salary = @Age * @Length * @Constant
	END
	
	-- Return the result of the function
	RETURN @Salary

END
