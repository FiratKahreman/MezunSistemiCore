using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class StudentRepository : IStudentDal
    {
        Context c = new Context();
        public void AddStudent(Student student)
        {
            c.Add(student);
            c.SaveChanges();
        }

        public Student GetStudent(int id)
        {
            return c.Students.Find(id);
        }

        public List<Student> ListAllStudents()
        {
            return c.Students.ToList();
        }

        public void RemoveStudent(Student student)
        {
            c.Remove(student);
            c.SaveChanges();
        }

        public void UpdateStudent(Student student)
        {
            c.Update(student);
            c.SaveChanges();
        }
    }
}
