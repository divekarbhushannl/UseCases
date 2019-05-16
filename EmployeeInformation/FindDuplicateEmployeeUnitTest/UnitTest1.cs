using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindDuplicateEmployee;

namespace FindDuplicateEmployeeUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetDuplicateEmplyeeByFirstandLastName()
        {
            List<Employee> EmplyeeList = new List<Employee>();
            EmplyeeList.Add(new Employee { Id = 1, FirstName = "Taco", LastName = "Leeman", Age = 50, Salary = 80000 });
            EmplyeeList.Add(new Employee { Id = 2, FirstName = "Mark", LastName = "Rumph", Age = 46, Salary = 95000 });
            EmplyeeList.Add(new Employee { Id = 3, FirstName = "Eddy", LastName = "Visser", Age = 44, Salary = 85000 });
            EmplyeeList.Add(new Employee { Id = 4, FirstName = "Taco", LastName = "Leeman", Age = 51, Salary = 81000 });
            EmplyeeList.Add(new Employee { Id = 5, FirstName = "Eddy", LastName = "Visser", Age = 55, Salary = 87000 });

            List<EmployeePerson> DuplicateEmployeePersonlist = EmployeeService.GetDuplicateEmplyeeByFirstandLastName(EmplyeeList);

            Assert.AreEqual(2, DuplicateEmployeePersonlist.Count);

        }

        [TestMethod]
        public void TestGetEmplyeeByFirstandLastNameWithNoDuplication()
        {
            List<Employee> EmplyeeList = new List<Employee>();
            EmplyeeList.Add(new Employee { Id = 1, FirstName = "Taco", LastName = "Leeman", Age = 50, Salary = 80000 });
            EmplyeeList.Add(new Employee { Id = 2, FirstName = "Mark", LastName = "Rumph", Age = 46, Salary = 95000 });
            EmplyeeList.Add(new Employee { Id = 3, FirstName = "Eddy", LastName = "Visser", Age = 44, Salary = 85000 });
           
            List<EmployeePerson> DuplicateEmployeePersonlist = EmployeeService.GetDuplicateEmplyeeByFirstandLastName(EmplyeeList);

            Assert.AreEqual(0, DuplicateEmployeePersonlist.Count);

        }

        [TestMethod]
        public void TestGetAllEmployeeWithZeroRows()
        {
            EmployeeInformationContext context = new EmployeeInformationContext();
            EmployeeService employeeservice = new EmployeeService(context);

            Assert.AreEqual(0, employeeservice.GetAllEmployees().Count);

        }

        [TestMethod]
        public void TestGetAllEmployeeWithNonZeroRows()
        {
            EmployeeInformationContext context = new EmployeeInformationContext();
            EmployeeService employeeservice = new EmployeeService(context);

            Assert.AreNotEqual(0, employeeservice.GetAllEmployees().Count);
        }

    }
}
