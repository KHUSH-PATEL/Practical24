using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Model
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(50)")]
        [StringLength(50, MinimumLength = 3)]
        public string? Name { get; set; }

        [Required]
        [Column(TypeName = "DECIMAL(10,2)")]
        public decimal Salary { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(100)")]
        [StringLength(50, MinimumLength = 10)]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required]
        [Column(TypeName = "DATE")]
        [DataType(DataType.DateTime)]
        public DateTime JoinDate { get; set; }

        [Required]
        public Department DepartmentId { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
