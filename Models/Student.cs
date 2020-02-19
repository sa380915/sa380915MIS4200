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
        [Required(ErrorMessage ="Student first name is required")]
        [StringLength(20)]
        public string studentFirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        [StringLength(20)]
        public string studentLastName { get; set; }
        [Display(Name = "Email")]
        [Required]
        [EmailAddress(ErrorMessage ="Enter your most frequently used email address")]
        public string email { get; set; }
        [Display(Name = "Mobile Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$",
            ErrorMessage ="Phone numbers must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phone { get; set; }
        [Display(Name = "Date you joined the school")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode =true)]
        public Nullable<System.DateTime> studentSince { get; set; }

        
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