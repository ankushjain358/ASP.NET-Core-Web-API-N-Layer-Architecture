using System;
using System.ComponentModel.DataAnnotations;

namespace SampleApplication.DTO
{
    public class EmployeeDTO
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Designation { get; set; }

        [Required]
        public int Salary { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 10)]
        public string MobileNumber { get; set; }
    }
}
