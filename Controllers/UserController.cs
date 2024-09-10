using Microsoft.AspNetCore.Mvc;

namespace CMCS.Controllers
{
    public class UserController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
