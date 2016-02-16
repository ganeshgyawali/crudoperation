using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Management.Models;
using Management.Repository;

namespace Management.Service
{
    public interface IEmployeeService:IGenericService<Employee>
    {
    }
    public  class EmployeeService:IEmployeeService
    {
        private EmployeeRepository _employeeRepository = new EmployeeRepository();
        public int Insert(Employee employee)
        {
            return _employeeRepository.Insert(employee);
        }

        public int Update(Employee employee)
        {
            return _employeeRepository.Update(employee);
        }

        public int Delete(int id)
        {
            return _employeeRepository.Delete(id);
        }

        public Employee GetById(int id)
        {
            return _employeeRepository.GetById(id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employeeRepository.GetAll();
        }

        public List<Employee> Search(Expression<Func<Employee>> e)
        {
            throw new NotImplementedException();
        }
    }
}