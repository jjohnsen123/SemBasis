using DTO.Model;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BLL
{
    public class StudentBLL
    {
        public Student getStudent(int id)
        {
            return StudentRepository.getStudent(id);
        }
    }
}
