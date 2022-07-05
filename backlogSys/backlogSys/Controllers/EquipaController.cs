using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

using backlogSys.Models;
using backlogSys.Data;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace backlogSys.Controllers{

    [Authorize(Roles = "Administrativo")]
    public class EquipaController : Controller{

        /// <summary>
        /// Cria uma referência à base de dados do projeto
        /// </summary>
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// Dados Servidor ASP .NET
        /// </summary>
        private readonly IWebHostEnvironment _webHostEnvironment;


        public EquipaController(ApplicationDbContext context,IWebHostEnvironment webHostEnvironment){
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        //GET: Equipa
        public async Task<IActionResult> Index() {
            return View(await _context.Equipa.ToListAsync());
        }

        //GET: Equipa/Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipa = await _context.Equipa.FirstOrDefaultAsync(m => m.Id == id);
                if(equipa == null)
            {
                return NotFound();
            }
            return View(equipa);
        }


        //GET: Equipa/Create
        /// <summary>
        /// Cria a view para adicionar uma Equipa
        /// </summary>

        public IActionResult Create(){
            return View();
        }

        //POST: Equipa/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Email,TeamLeader,Chefe")] Equipa equipa){

        if (ModelState.IsValid){
                _context.Add(equipa);
                await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            }
            return View(equipa);
        }

        //GET: Equipa/Edit
        public async Task<IActionResult> Edit(int? id) {
            if (id == null) {
                return RedirectToAction("Index");
            }

            var equipa = await _context.Equipa.FindAsync(id);
            if(equipa == null) {
                return RedirectToAction("Index");
            }

            
            HttpContext.Session.SetInt32("id", equipa.Id);

            return View(equipa);
        }

        //POST: Equipa/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Email,TeamLeader,Chefe")] Equipa equipa) {
            if(id != equipa.Id) {
                return NotFound();
            }


            
            int? idEquipa = HttpContext.Session.GetInt32("id");

            if(idEquipa == null) {
                ModelState.AddModelError("", "Ultrapassou o tempo limite para a edição dos dados");
                return View(equipa);
            }

            //Verifica se os dados alterados são efetivamente da equipa a editar
            if(idEquipa != equipa.Id) {
                return RedirectToAction("Index");
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update(equipa);
                    await _context.SaveChangesAsync();

                } catch (DbUpdateConcurrencyException) {
                    if (!EquipaExists(equipa.Id)) {
                        return NotFound();
                    } else {
                        throw;
                    }
                } catch (Exception) {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }

            return View(equipa);
        }

        //GET: Equipa/Delete
        public async Task<IActionResult> Delete(int? id) {
            if(id == null) {
                return NotFound();
            }
            var equipa = await _context.Equipa.FirstOrDefaultAsync(m => m.Id == id);
            if (equipa == null) {
                return NotFound();
            }
            return View(equipa);
        }

        //POST: Equipa/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) {
            var equipa = await _context.Equipa.FindAsync(id);
            _context.Equipa.Remove(equipa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool EquipaExists(int id) {
            return _context.Equipa.Any(e => e.Id == id);
        }
    }
}