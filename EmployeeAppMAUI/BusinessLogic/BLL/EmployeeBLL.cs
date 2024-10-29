﻿using DTO.Model;

using EmployeeDataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Employees
{
    public class EmployeeBLL
    {
        public static Employee getEmployee(int id)
        {
            //if (id < 0) throw new IndexOutOfRangeException();
            return EmployeeRepository.getEmployee(id);
        }
        public void AddEmployee(Employee employee)
        {
            //valider employee
            EmployeeRepository.AddEmployee(employee);
        }
        public static void EditEmployee(Employee employee)
        {
            EmployeeRepository.EditEmployee(employee);
        }
        public static List<CompanyOverview> AllCompanies()
        {
            return EmployeeRepository.AllCompanies();
        }

        public static CompanyDetail GetCompanyDetails(int id)
        {
            return EmployeeRepository.CompanyDetail(id);
        }
        public void AddEmployeeToCompany(int EmployeeId, int CompanyId)
        {
            EmployeeRepository.AddEmployeeToCompany(EmployeeId, CompanyId);
        }
    }
}