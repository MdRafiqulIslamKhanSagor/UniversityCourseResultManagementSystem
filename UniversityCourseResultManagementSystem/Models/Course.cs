﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversityCourseResultManagementSystem.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required(ErrorMessage = "Please give the Course Code")]
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CourseCode { get; set; }
        [Required(ErrorMessage = "Please give the Course name")]
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CoursName { get; set; }
        [Required(ErrorMessage = "Please give the Course Credit")]

        public double CourseCredit { get; set; }
        [Required(ErrorMessage = "Please give the Course Description")]
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CourseDescription { get; set; }
        [Required(ErrorMessage = "Please Select Department Name")]

        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Please Select Department Name")]

        public int SemesterId { get; set; }
        public int? TeacherId { get; set; }
        public virtual Department Department { get; set; }

        public virtual Semister Semester { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}