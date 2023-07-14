using AutoMapper;
using DataAccessLayer.Data;
using DataAccessLayer.Dto;
using DataAccessLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public EmployeeService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void AddEmployee(EmployeeDto empDto)
        {
            var emp = _mapper.Map<Employee>(empDto);
            _context.Employees.Add(emp);
            _context.SaveChanges();
        }

        public Employee DeleteEmployee(int id)
        {
            var data = _context.Employees.Find(id);
            if (data != null)
            {
                data.IsDeleted = true;
                _context.SaveChanges();
                return data;
            }
            else
            {
                return data;
            }
        }

        public Employee? EditEmployee(int id, EmployeeDto emp)
        {
            var result = _context.Employees.Find(id);
            if (result == null)
            {
                return result;
            }
            else
            {
                result.Name = emp.Name;
                result.Email = emp.Email;
                result.Salary = emp.Salary;
                result.DepartmentId = emp.DepartmentId;
                _context.Entry(result).State = EntityState.Modified;
                _context.SaveChanges();
                return result;
            }
        }

        public List<EmployeeDto> GetEmployee()
        {
            var data = _context.Employees.Where(x => !x.IsDeleted).ToList();
            var employeeDto = _mapper.Map<List<EmployeeDto>>(data);
            return employeeDto;
        }

        public EmployeeDto GetEmployee(int id)
        {
            var data = _context.Employees.Where(x => !x.IsDeleted).FirstOrDefault(x => x.Id == id);
            var employeeDto = _mapper.Map<EmployeeDto>(data);
            return employeeDto;
        }
    }
}
