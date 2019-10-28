using HairSalon.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

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
            List<Client> allClients = _db.Clients.ToList();
            // should list out every client in the system, then should be able to click and find out their details. 
            // carries an id to pass to details.
            return View(allClients);
        }
        public ActionResult Details(int id)
        {
            
            Client foundClient = _db.Clients.FirstOrDefault(c => c.ClientID == id);
            Console.WriteLine(foundClient.ClientName);
            // iteration  through colllection to find out if that id matches the id passed in and then returns that specific clients details.
            // action links on view page to redirect them to other parts of the website.
            return View(foundClient);
        }
        [HttpGet]
        public ActionResult Create()
        {
            
            
            ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
            // has to pass in something to make the relationship between client and stylist.
            // i think i will have to pass in a viewbag or view data to also pass in the stylist "ids" or "names"
            // will show a form to create the new client
            return View();
        }
        public ActionResult Create(Client newClient)
        {
            Console.WriteLine(newClient.ClientName);
            if(ModelState.IsValid)
            {
                _db.Clients.Add(newClient);
                _db.SaveChanges();
                return RedirectToAction("Index", "Stylist");
            }
            else
            {
                return RedirectToAction("Create", "Client");
            }
            
            // most likely will redirect them back to index
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
            Client foundClient = _db.Clients.FirstOrDefault(c => c.ClientID == id);
            return View(foundClient);
        }
        public ActionResult Edit(Client foundClient)
        {
            _db.Entry(foundClient).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index", "Stylist");
        }
    }
}