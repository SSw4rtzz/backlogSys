using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

using backlogSys.Models;
using backlogSys.Data;

namespace backlogSys.Controllers
{
    public class MembrosController : Controller
    {

        /// <summary>
        /// Cria uma referência à base de dados do projeto
        /// </summary>
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// Dados Servidor ASP .NET
        /// </summary>
        private readonly IWebHostEnvironment _webHostEnvironment;


        public MembrosController(ApplicationDbContext context,IWebHostEnvironment webHostEnvironment){
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        //GET: Membro
        public async Task<IActionResult> Index() {
            return View(await _context.Membros.ToListAsync());
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}