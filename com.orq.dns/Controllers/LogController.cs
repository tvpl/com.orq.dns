using Microsoft.AspNetCore.Mvc;

namespace com.orq.dns.Controllers
{
    public class LogController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return
            View();
        }
    }
}