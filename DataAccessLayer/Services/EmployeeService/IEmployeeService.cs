using DataAccessLayer.Dto;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services.EmployeeService
{
    public interface IEmployeeService
    {
        List<EmployeeDto> GetEmployee();
        EmployeeDto GetEmployee(int id);
        void AddEmployee(EmployeeDto empDto);
        Employee? EditEmployee(int id, EmployeeDto empDto);
        Employee DeleteEmployee(int id);
    }
}
