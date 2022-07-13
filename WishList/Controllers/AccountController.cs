using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
namespace WishList.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
