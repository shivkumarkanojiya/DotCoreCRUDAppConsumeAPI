

using System.ComponentModel.DataAnnotations;

namespace CRUDAppUsingAspNetCoreWebAPI.Models
{


    public class Student
    {
        [Display(Name ="ID")]
        public int id { get; set; }
        [Display(Name = "Student Name")]
        [Required]
        public string? studentName { get; set; }
        [Display(Name = "Gender")]
        [Required]
        public string? studentGender { get; set; }
        [Display(Name = "Age")]
        [Required]
        public int age { get; set; }
        [Display(Name = "Standard")]
        [Required]
        public int standard { get; set; }
        [Display(Name = "Father Name")]
        [Required]
        public string? fatherName { get; set; }
    }

}
