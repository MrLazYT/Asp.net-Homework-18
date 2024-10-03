using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace homework_18.Controllers
{
    [Authorize]
    public class SecretController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
