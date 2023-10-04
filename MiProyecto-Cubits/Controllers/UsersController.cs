using Microsoft.AspNetCore.Mvc;
using MiProyecto_Cubits.Models;

namespace MiProyecto_Cubits.Controllers
{
    [Route("Users")]
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            var user = new UserModel
            {
                Name = "Cecilia",
                LastName = "Pizzi"
            };

            return View("Index",user); 
        }   
    }
}
