using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormSubmission_1.Models
{
    public class Class1
    {
    [Required(ErrorMessage = "Please Provide Name")]
    [StringLength(10, ErrorMessage = "Name should not exceed 10 characters")]
    public string Name { get; set; }
    [Required]
    public string ID { get; set; }
    [Required]
    public string Gender { get; set; }
    [Required]
    public string Profession { get; set; }
    [Required]
    public string[] Hobbies { get; set; }
    [Required]
    public DateTime Dob { get; set; }
    }
}