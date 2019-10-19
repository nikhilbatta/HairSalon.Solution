using HairSalon.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Controllers
{
    public class HomeController : Controller 
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}