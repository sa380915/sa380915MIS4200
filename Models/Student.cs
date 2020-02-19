using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sa380915MIS4200.Models
{
    public class Student
    {

        public System.Guid SID { get; set; }
        public int studentID { get; set; }
        [Display (Name = "First Name")]
        public string studentFirstName { get; set; }
        [Display(Name = "Last Name")]
        public string studentLastName { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "Phone")]
        public string phone { get; set; }
        [Display(Name = "Date you joined the school")]
        public DateTime studentSince { get; set; }

        
        public ICollection<Grade> Grades { get; set; }
        public string fullName
        {
            get
            {
                return studentLastName + ", " + studentFirstName;
            }
        }
        


    }
}