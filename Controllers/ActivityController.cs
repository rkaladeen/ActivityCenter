using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ActivityCenter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ActivityCenter.Controllers
{
  public class ActivityController : Controller
  {
    private MyContext dbContext;
    public ActivityController(MyContext context)
    {
      dbContext = context;
    } 
    public IActionResult NewActivity()
    {
      if(HttpContext.Session.GetString("UserName") != null)
      {
        ViewBag.user_id = HttpContext.Session.GetInt32("User_Id");
        ViewBag.user_name = HttpContext.Session.GetString("UserName");
        return View();
      }
      else
      {
        return RedirectToAction("LogIn", "User");
      }
    }

    public IActionResult CreateActivity(ActivityModel Activity)
    {
      if(ModelState.IsValid)
      {
        DateTime End = Activity.StartDateTime;
        if(Activity.DurationMeasure == "Minutes")
        {
          End = End.AddMinutes(Activity.Duration1);
        }
        if(Activity.DurationMeasure == "Hours")
        {
          End = End.AddHours(Activity.Duration1);
        }
        if(Activity.DurationMeasure == "Days")
        {
          End = End.AddDays(Activity.Duration1);
        }
        Activity.EndDateTime = End; 
        dbContext.Activities.Add(Activity);
        dbContext.SaveChanges();

        RSVPModel NewRSVP = new RSVPModel()
        {
          Activity_Id = Activity.Activity_Id,
          User_Id = (int)HttpContext.Session.GetInt32("User_Id")
        };
        dbContext.RSVPs.Add(NewRSVP);
        dbContext.SaveChanges();

        return viewActivity(Activity.Activity_Id);
      }
      else
      {
        ViewBag.user_id = HttpContext.Session.GetInt32("User_Id");
        ViewBag.user_name = HttpContext.Session.GetString("UserName");
        return View("NewActivity");
      }
    }

    public IActionResult viewActivity(int id)
    {
      if(HttpContext.Session.GetString("UserName") != null)
      {
        ViewBag.user_id = HttpContext.Session.GetInt32("User_Id");
        ViewBag.user_name = HttpContext.Session.GetString("UserName");

        ActivityModel oneActivity = dbContext.Activities
            .Include(c => c.Coordinator)
            .Include(p => p.RSVPed)
            .ThenInclude(u2 => u2.User)
            .FirstOrDefault(a => a.Activity_Id == id);
        ViewBag.Activity = oneActivity;
        return View("Activity");
      }
      else
      {
        return RedirectToAction("LogIn", "User");
      }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
