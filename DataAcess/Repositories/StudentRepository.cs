using DataAccess.Context;
using DataAccess.Mapper;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class StudentRepository
    {
        public static Student getStudent(int id)
        {
            using(StudentContext context = new StudentContext())
            {
                var student = context.Students.Find(id);
                return StudentMapper.Map(student);
            }
        }

        public static  List<Student> getStudents()
        {
            using (StudentContext context = new StudentContext())
            {
                var students = context.Students.ToList();
                return StudentMapper.Map(students);
            }
        }
    }
}
