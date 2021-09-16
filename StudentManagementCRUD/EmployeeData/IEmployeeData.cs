using StudentManagementCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementCRUD.EmployeeData
{
    public interface IEmployeeData
    {
        List<Employee> GetEmployeeList();

        Employee GetEmployee(Guid id);

        void AddEmployee(Employee employee);

        void DeleteEmployee(Employee employee);

        Employee EditEmployee(Employee employee);
    }
}
