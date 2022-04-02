using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IStudentDal
    {
        List<Student> ListAllStudents();
        void AddStudent(Student student);
        void RemoveStudent(Student student);
        void UpdateStudent(Student student);
        Student GetStudent(int id);
    }
}
