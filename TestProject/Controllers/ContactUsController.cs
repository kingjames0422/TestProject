using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestProject.Models;

namespace TestProject.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly ILogger<ContactUsController> _logger;

        public ContactUsController(ILogger<ContactUsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
