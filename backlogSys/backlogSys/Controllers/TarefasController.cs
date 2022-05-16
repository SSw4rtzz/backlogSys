using backlogSys.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace backlogSys.Controllers
{
    public class TarefasController : Controller
    {
        private readonly ILogger<TarefasController> _logger;

        public TarefasController(ILogger<TarefasController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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