using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sa380915MIS4200.Models
{
    public class Grade
    {
        public System.Guid GID { get; set; }
        public int gradeID { get; set; }
        [Display(Name = "Course Grade")]
        public string courseGrade { get; set; }
        [Display(Name = "Course")]
        public int courseID { get; set; }
        public virtual Course Course { get; set; }
        // the next two properties link the orderDetail to the Product
        public int studentID { get; set; }
        public virtual Student Student { get; set; }


    }
}