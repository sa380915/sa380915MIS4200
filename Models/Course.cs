using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sa380915MIS4200.Models
{
    public class Course
    {
        public int courseID { get; set; }
        public string description { get; set; }
        public DateTime courseDate { get; set; }
        //public int studentID { get; set; }

        public ICollection<Grade> Grades{ get; set; }
        //public object Student { get; internal set; }

        //public virtual Student Student { get; set; }

    }
}