using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace UniversityCourseResultManagementSystem.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Please Enter Department Code")]
        [StringLength(7,MinimumLength = 2,ErrorMessage = "Code Must be 2-7 Character")]
        [Column(TypeName = "Varchar")]
        [Display(Name = "Department Code")]
        public string DepartmentCode { get; set; }
        [Required(ErrorMessage = "Please Enter a Department Name")]
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        [Display(Name = "Department Name")]
        public string DepartmentName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string CreatedDate { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string ModifiedDate { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string ModifiedBy { get; set; }
    }
}