using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Management.Migrations;
using Management.Models;
using  Management.Context;
namespace Management.Repository
{
    public interface ICourseRepository : IGenericRepository<Course>
    {
         
    }
    public class CourseRepository: ICourseRepository
    {
        private GaneshDbConnection db = new GaneshDbConnection();
           
        public int Insert(Course course)
        {
           db.Courses.Add(course);
            return 1;
        }

        public int Update(Course course)
        {
            db.Entry(course).State= EntityState.Modified;
            return 1;
        }

        public int Delete(int id)
        {
            Course course = GetById(id);
            db.Courses.Remove(course);
            return 1;

        }

        public Course GetById(int id)
        {
            return db.Courses.Find(id);
        }

        public IEnumerable<Course> GetAll()
        {
            return db.Courses.ToList();
        }

        public List<Course> Search(Expression<Func<Course>> e)
        {
            throw new NotImplementedException();
        }
    }
}