using System.ComponentModel.DataAnnotations;
using ActivityCenter.Models;

namespace ActivityCenter
{
  public class RSVPModel : BaseModel
  {
    [Key]
    public int RSVP_Id {get; set;}

    public int User_Id {get; set;}
    public UserModel User {get; set;}

    public int Activity_Id {get; set;}
    public ActivityModel Activity{get; set;}
  }
}