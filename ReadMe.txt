1. The Visual Studio Database Project is created to deploy the table,Stored Procedure and UserDeined Functions
To Run the application correct way,please Create databse EmployeeInformation on the server/desktope and change the value of 
DataSource in TargetConnectionString tag of "EmployeeInformation.publish.xml" file.
After that you can Publish the EmployeeInformation Project.

2.To run the FindDuplicateEmployee projet,Please change the Server name where you created EmployeeInformation database in appsetting.json file

3.FindDuplicateEmployeeUnitTest project is created for Unit test cases

4.StoredProcAndFunctionUnitTest orject is created for Stored Procedure and Function unit test cases.

5.The ImportNewEmployeeandCalculateSalary ETL package is developed for import data from the Excel file which contains new employee data and Calculate salary of that new employee on the basis of Age and Length.
      a.To Run the ETL Package,first need to create EmplyeeInformation database with table,Stored Procedure and Function by using 			EmployeeInformation project. follow step 1
      b.change the connection Manager with server name where the EmployeeInformation database is created. Also change the file path in 	Excel Connection Manager

6.The FindDuplicateEmployee console application is check that whether the duplicate employee by FirstName and LastName are present or not.

