using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Management.Context;
using Management.Migrations;
using Management.Models;
namespace Management.Repository
{
    public interface IStudentRepository: IGenericRepository<Student>
    {
    }
    public class StudentRepository : IStudentRepository
    {
        private GaneshDbConnection db = new GaneshDbConnection();
        public int Insert(Student student)
        {
            db.Students.Add(student);
            return 1;
        }

        public int Update(Student s)
        {
            db.Entry(s).State = EntityState.Modified;
            return 1;
        }

        public int Delete(int id)
        {
            Student student = GetById(id);
            db.Students.Remove(student);
            return 1;
        }

        public Student GetById(int id)
        {
            return db.Students.Find(id);
        }

        public IEnumerable<Student> GetAll()
        {
           return db.Students.ToList();
            
           
        }

        public List<Student> Search(Expression<Func<Student>> e)
        {
            throw new NotImplementedException();
        }
    }
}