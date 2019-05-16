﻿/*
Deployment script for EmployeeInformation

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "EmployeeInformation"
:setvar DefaultFilePrefix "EmployeeInformation"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Altering [dbo].[uspUpdateSalaryInformation]...';


GO
-- =============================================
-- Author:		<Author:Bhushan Divekar>
-- Create date: <Create Date : 15/05/2019>
-- Description:	<Description: Update Salary Information in Emplyee table>
-- =============================================
ALTER PROCEDURE uspUpdateSalaryInformation 
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
GO
PRINT N'Update complete.';


GO
