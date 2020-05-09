using MVC3.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC3.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        
        [Required]
        [MaxLength(128)]
        [EmailAddress]
        public string Email { get; set; }
        
        public Gender Gender { get; set; }
        
        [Range(2500, 50000)]
        [DataType(DataType.Currency)]
        public int Salary { get; set; }
        
        [MaxLength(256)]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [Display(Name= "Department")]
        [ForeignKey("Departments")]
        public int FK_DepartmentsID { get; set; }
        public virtual Departments Departments { get; set; }
    }
}