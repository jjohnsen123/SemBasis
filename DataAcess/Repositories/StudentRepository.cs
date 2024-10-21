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
                return StudentMapper.Map(context.Students.Find(id));
            }
        }
    }
}
