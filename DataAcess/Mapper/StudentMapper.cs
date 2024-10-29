using Azure;
using DataAccess.Model;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Mapper
{
    internal class StudentMapper
    {
        public static DTO.Model.Student Map(Model.Student student)
        {
            return new DTO.Model.Student(student.Name, student.StudieStart, student.Age, student.StudieType, student.StudieId);
        }

        public static Model.Student Map(DTO.Model.Student student)
        {
            return new Model.Student(student.Name, student.StudieStart, student.Age, student.StudieType, student.StudieId);
        }

        public static List<DTO.Model.Student> Map(List<Model.Student> students)
        {
            List<DTO.Model.Student> retur = new List<DTO.Model.Student>();
            foreach (Model.Student student in students)
            {
                retur.Add(StudentMapper.Map(student));
            }
            return retur;
        }


        //internal static void Update(DTO.Model.Employee employee, Employee dataemp)
        //{
        //    dataemp.Name = employee.Name;
        //    dataemp.YearsEmployeed = employee.YearsEmployed;
        //}

        //internal static DTO.Model.CompanyDetail MapDetail(Company company)
        //{
        //    DTO.Model.CompanyDetail retur = new DTO.Model.CompanyDetail();
        //    retur.CompanyName = company.CompanyName;
        //    retur.Employees = EmployeeMapper.Map(company.Employees);
        //    return retur;
        //}

        //private static List<DTO.Model.Employee> Map(List<Employee> employees)
        //{
        //    List<DTO.Model.Employee> retur = new List<DTO.Model.Employee>();
        //    foreach (Employee employee in employees)
        //    {
        //        retur.Add(EmployeeMapper.Map(employee));
        //    }
        //    return retur;
        //}

        //public static DTO.Model.CompanyOverview Map(Company company)
        //{
        //    return new DTO.Model.CompanyOverview(company.CompanyId, company.CompanyName);
        //}
    }
}
