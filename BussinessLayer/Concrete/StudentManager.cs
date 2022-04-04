using BussinessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class StudentManager : IStudentService
    {
        
        public List<Student> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public void StudentAdd(Student student)
        {
           
            throw new NotImplementedException();
        }

        public void StudentRemove(Student student)
        {
            throw new NotImplementedException();
        }

        public void StudentUpdate(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
