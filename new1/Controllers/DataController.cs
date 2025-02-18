using Microsoft.AspNetCore.Mvc;
using new1.Models;

namespace new1.Controllers
{
    public class DataController : Controller
    {
        private ApplicationContext _context;

       public DataController(ApplicationContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            //var q = from s in _context.employees select s;

            //var n = from ft in _context.employees where ft.ID == 2 select ft;

            //var n = from ft in _context.employees where ft.Name like ;





            return View();
        }
    }
}
