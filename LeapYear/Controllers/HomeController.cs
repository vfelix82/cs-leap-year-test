using Microsoft.AspNetCore.Mvc;
using LeapYear.Models;
using System.Collections.Generic;

namespace LeapYear.Controllers
{
    public class HomeController : Controller
    {
      public ActionResult Index(){
          return View();
      }
    }
}
