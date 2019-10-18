namespace HairSalon.Controllers
{
    public class StylistController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            // controller index for this stylistcontrollerview will show me a list of all stylists.
            // and the stylist properties, like what is the stylist price.
            // make the stylist clickable. 
            // each stylist should carry an id so that when clicked it can have an action link to a details page for details on that specific stylist, which in this case will be all the clients for a specific stylist.

            return View();
        }
        public ActionResult Details(int id)
        {
            // will take in an id from whatever stylist was clicked and then filter the collection based on the id to display that stylists clients.
            // each client that gets displayed will be clickable to see that specific clients details.
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            // will be able to create a new stylist. 
            return View();
        }
        [HttpPost]
        public ActionResult Create(// will take in the object recieved from the other create)
        {
            // will mostlikely redirect to some other action or url.
        }
    }
}