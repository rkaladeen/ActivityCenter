using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActivityCenter.Models 
{
  public class UserModel : BaseModel
  {
    [Key]
    public int User_Id {get; set;}

    [Required]
    [StringLength(10, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 3)]
    [Display(Name = "First Name")]
    public string FirstName {get; set;}

    [Required]
    [StringLength(10, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 3)]
    [Display(Name = "Last Name")]
    public string LastName {get; set;}

    [Required]
    [EmailAddress]
    public string Email {get; set;}

    [Required]
    [MinLength(8, ErrorMessage="Password must be Between 6 and 18 characters in length")]
    [RegularExpression(@"^.*(?=.{6,18})(?=.*\d)(?=.*[A-Za-z])(?=.*[!%&#]{1,}).*$", ErrorMessage = "Password doesn't meet the requirements")]
    [DataType(DataType.Password)]
    public string Password {get; set;}

    [NotMapped]
    [Compare("Password", ErrorMessage="Password does not match.")]
    [DataType(DataType.Password)]
    [Display(Name = "Confirm Password")]
    public string Confirm {get;set;}
  }
}