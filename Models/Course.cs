using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sa380915MIS4200.Models
{
    public class Course
    {
        public System.Guid CID { get; set; }
        public int courseID { get; set; }
        [Display(Name = "Course Description")]
        [Required(ErrorMessage ="Please provide course description")]
        [StringLength(20)]
        public string description { get; set; }
        [Display(Name = "Date of First Class")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime courseDate { get; set; }
        //public int studentID { get; set; }

        public ICollection<Grade> Grades{ get; set; }
        //public object Student { get; internal set; }

        //public virtual Student Student { get; set; }

    }
}