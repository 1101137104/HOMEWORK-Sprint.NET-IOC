
using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;

namespace KuasCore.Dao.Impl
{
    public class NewEmployeeDao : IEmployeeDao
    {


        public IList<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Employee employee1 = new Employee();
            employee1.Id = "MIS1";
            employee1.Name = "吳家瑋";
            employee1.Age = 21;
            employees.Add(employee1);

            Employee employee2 = new Employee();
            employee2.Id = "MIS2";
            employee2.Name = "溫妮";
            employee2.Age = 22;
            employees.Add(employee2);

            return employees;
        }

        public Employee GetEmployeeById(string id)
        {
            Employee employee = null;

            if ("MIS1".Equals(id))
            {
                employee = new Employee();
                employee.Id = "MIS1";
                employee.Name = "吳家瑋";
                employee.Age = 21;
            }

            if ("MIS2".Equals(id))
            {
                employee = new Employee();
                employee.Id = "MIS2";
                employee.Name = "溫妮";
                employee.Age = 22;
            }
            /*
            Employee employee = new Employee();
            employee.Id = "MIS1";
            employee.Name = "吳家瑋";
            employee.Age = 21;*/

            return employee;
        }

    }
}
