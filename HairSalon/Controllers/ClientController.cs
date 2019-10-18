using HairSalon.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Controllers
{
    public class ClientController: Controller
    {
         private readonly HairSalonContext _db;
        public ClientController(HairSalonContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {

            // should list out every client in the system, then should be able to click and find out their details. 
            // carries an id to pass to details.
            return View();
        }
        public ActionResult Details(int id)
        {
            // iteration  through colllection to find out if that id matches the id passed in and then returns that specific clients details.
            // action links on view page to redirect them to other parts of the website.
            return View();
        }
        public ActionResult Create(int id)
        {
            // i think i will have to pass in a viewbag or view data to also pass in the stylist "ids" or "names"
            // will show a form to create the new client
            return View();
        }
        // public ActionResult Create()
        // {
        //     // most likely will redirect them back to index
        // }
    }
}