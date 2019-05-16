using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;

namespace FindDuplicateEmployee
{
    public class EmployeeService
    {
        private EmployeeInformationContext _context;

        public EmployeeService(EmployeeInformationContext context)
        {
            _context = context;
        }

       
        /// <summary>
        /// Get All Employee from the Employee table
        /// </summary>
        
        public List<Employee> GetAllEmployees()
        {
            var query = from b in _context.Employee
                        orderby b.Id
                        select b;

            return query.ToList();
        }

        /// <summary>
        /// Get Unique Empoyee first Name and Last Name from Duplicate Employee set
        /// </summary>

        public static List<EmployeePerson> GetDuplicateEmplyeeByFirstandLastName(List<Employee>EmployeeList)
        {
            List<Employee> EmployeeDuplicateList = EmployeeList.getAllRepeated(z => new { z.FirstName, z.LastName }).Distinct().ToList();

            List<EmployeePerson> EmployeePersonList = EmployeeDuplicateList.Select(x => new EmployeePerson { FirstName = x.FirstName, LastName = x.LastName }).ToList();

            return EmployeePersonList;
        }
    }
}
