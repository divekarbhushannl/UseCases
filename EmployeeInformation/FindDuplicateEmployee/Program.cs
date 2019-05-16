using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindDuplicateEmployee
{
    class Program
    {

        public static void Main(string[] args)
        {
            try{ 
                using (var db = new EmployeeInformationContext())
                {
                    EmployeeService eserv = new EmployeeService(db);

                    //Retreive all records from the Employee table

                    List<Employee> EmplyeeList = eserv.GetAllEmployees(); 

                    //Find out duplicate Employees on the basis of firstName and LastName

                    List<EmployeePerson> DuplicateEmployeePersonlist = EmployeeService.GetDuplicateEmplyeeByFirstandLastName(EmplyeeList);

                    if (DuplicateEmployeePersonlist.Count > 0)
                    {
                        for (int i = 0; i < DuplicateEmployeePersonlist.Count; i++)
                            Console.WriteLine(DuplicateEmployeePersonlist[i].FirstName + " " + DuplicateEmployeePersonlist[i].LastName);
                    }
                    else
                    {
                        Console.WriteLine("No Duplicate Employees Found");
                    }
                }
            }catch(Exception ex)
            {
                string ErrorMessage = ex.Message;
            }


        }
    }
}
