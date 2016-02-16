using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Management.Context;
using Management.Models;

namespace Management.Repository
{
    public interface IEmployeeRepository:IGenericRepository<Employee>
    {
    }
    public class EmployeeRepository : IEmployeeRepository
    {
        private GaneshDbConnection db = new GaneshDbConnection();
        public int Insert(Employee employee)
        {
            db.Employees.Add(employee);
            return 1;
        }

        public int Update(Employee employee)
        {
           db.Entry(employee).State = EntityState.Modified;
            return 1;
        }

        public int Delete(int id)
        {
            Employee employee = GetById(id);
            db.Employees.Remove(employee);
            return 1;
        }

        public Employee GetById(int id)
        {
            return db.Employees.Find(id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return db.Employees.ToList();
        }

        public List<Employee> Search(Expression<Func<Employee>> e)
        {
            throw new NotImplementedException();
        }
    }
}