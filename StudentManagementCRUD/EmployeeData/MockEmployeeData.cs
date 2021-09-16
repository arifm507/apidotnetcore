using StudentManagementCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementCRUD.EmployeeData
{
    public class MockEmployeeData : IEmployeeData
    {
        private List<Employee> employees = new List<Employee>()
        {
            new Employee(){ 
                Id = Guid.NewGuid(),
                Name = "Mohd Arif"
            },
            new Employee(){
                Id = Guid.NewGuid(),
                Name = "Second user"
            },
            new Employee(){
                Id = Guid.NewGuid(),
                Name = "Third user"
            },
        };
        public void AddEmployee(Employee employee)
        {
            employee.Id = Guid.NewGuid();
            employees.Add(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            employees.Remove(employee);
        }

        public Employee EditEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(Guid id)
        {
            return employees.SingleOrDefault(x => x.Id == id);
        }

        public List<Employee> GetEmployeeList()
        {
            return employees;
        }
    }
}
