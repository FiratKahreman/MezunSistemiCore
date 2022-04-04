using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IStudentService
    {
        void StudentAdd(Student student);
        void StudentRemove(Student student);
        void StudentUpdate(Student student);
        List<Student> GetAllStudents();
        Student GetStudent(int id);

    }
}
