using Microsoft.AspNetCore.Mvc;
using WebSite.Models;

namespace WebSite.Controllers.Contacts
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Check(Contact contacts)
        {
            if (ModelState.IsValid)
            {
                return Redirect("/");
            }
            return Index();
        }
    }
}
