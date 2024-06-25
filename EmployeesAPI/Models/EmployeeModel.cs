using EmployeesAPI.Enums;
using System.ComponentModel.DataAnnotations;

namespace EmployeesAPI.Models
{
    public class EmployeeModel
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DepartmentEnum Department { get; set; }
        public TurnEnum Turn { get; set; }
        public bool Active { get; set; } = true;
        public DateTime CreationDate { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime LastUpdated { get; set; } = DateTime.Now.ToLocalTime();
    }
}
