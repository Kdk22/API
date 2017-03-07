using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDataAccess;
namespace EmployeeMgmt.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using (CompanyEntities entities = new CompanyEntities())
            {
                return entities.Employees.ToList();
            }
        }
        public Employee  Get(int id)
        {
            using (CompanyEntities entities = new CompanyEntities())
            {
                return entities.Employees.FirstOrDefault(e => e.Employee_Id == id);
            }
        }
    }
}
