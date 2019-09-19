using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActivityCenter.Models 
{
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
  public class DateInTheFutureAttribute : ValidationAttribute
  {
    protected override ValidationResult IsValid(object value, ValidationContext context)
    {
      var futureDate = value as DateTime?;
      var memberNames = new List<string>() { context.MemberName };

      if (futureDate != null)
      {
        if (futureDate.Value.Date < DateTime.UtcNow.Date)
        {
          return new ValidationResult("This must be a date in the future", memberNames);
        }
      }
      return ValidationResult.Success;
    }
  }
  public class ActivityModel : BaseModel
  {
    [Key]
    public int Activity_Id {get; set;}

    [Required]
    [StringLength(25, ErrorMessage="{0} length must be between {2} and {1}.", MinimumLength = 2)]
    public string Title {get; set;}

    [Required]
    [DateInTheFuture]
    [Display(Name = "Event Start")]
    public DateTime StartDateTime {get; set;}

    public DateTime EndDateTime {get; set;}

    [Required]
    [Display(Name = "Duration")]
    public double Duration1 {get; set;} 

    [Required]
    public string DurationMeasure {get; set;} 


    [Display(Name = "Event Coordinator")] 
    public int Coordinator_Id {get; set;}
    [ForeignKey("Coordinator_Id")]
    public virtual UserModel Coordinator {get; set;}

    [Required]
    [StringLength(1000, ErrorMessage="{0} length must be between {2} and {1}.", MinimumLength = 10)]
    public string Description {get; set;}

    [Display(Name = "Number of Participants")]
    public List<RSVPModel> RSVPed {get; set;}
    public ActivityModel()
    {
      RSVPed = new List<RSVPModel>();
    }
   

    

    
  }

  

}