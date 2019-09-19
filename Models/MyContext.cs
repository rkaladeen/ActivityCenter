using Microsoft.EntityFrameworkCore;
 
namespace ActivityCenter.Models
{
  public class MyContext : DbContext
  {
    public MyContext(DbContextOptions options) : base(options) { }
    public DbSet<UserModel> Users {get;set;}

    public DbSet<ActivityModel> Activities {get;set;}

    public DbSet<RSVPModel> RSVPs {get;set;}

  }

}