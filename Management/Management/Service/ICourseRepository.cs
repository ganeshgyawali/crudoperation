using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Management.Models;

namespace Management.Service
{
    public interface ICourseRepository:IGenericService<Course>
    {
         
    }
    public class CourseRepository:ICourseRepository
    {
        private CourseRepository _courseRepository = new CourseRepository();
        public int Insert(Course course)
        {
            return _courseRepository.Insert(course);
        }

        public int Update(Course course)
        {
           return _courseRepository.Update(course);
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Course GetById(int id)
        {

            return _courseRepository.GetById(id);
        }

        public IEnumerable<Course> GetAll()
        {
            return _courseRepository.GetAll();
        }

        public List<Course> Search(Expression<Func<Course>> course)
        {
            throw new NotImplementedException();
        }
    }
}