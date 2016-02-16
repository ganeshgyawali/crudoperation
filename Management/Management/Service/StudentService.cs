using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Management.Models;
using Management.Repository;

namespace Management.Service
{
    public interface IStudentService : IGenericService<Student>
    {
        
    }
    public class StudentService : IStudentService
    {
        private StudentRepository _studentRepository=new StudentRepository();
        public int Insert(Student student)
        {
            return _studentRepository.Insert(student);
        }

        public int Update(Student student)
        {
            return _studentRepository.Update(student);
        }

        public int Delete(int id)
        {
            return _studentRepository.Delete(id);


        }

        public Student GetById(int id)
        {
            return _studentRepository.GetById(id);
        }

        public IEnumerable<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }

        public List<Student> Search(Expression<Func<Student>> e)
        {
            throw new NotImplementedException();
        }
    }
}