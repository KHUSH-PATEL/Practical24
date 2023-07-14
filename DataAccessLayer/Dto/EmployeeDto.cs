using DataAccessLayer.Model;

namespace DataAccessLayer.Dto
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public string? Email { get; set; }
        public DateTime JoinDate { get; set; }
        public Department DepartmentId { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
