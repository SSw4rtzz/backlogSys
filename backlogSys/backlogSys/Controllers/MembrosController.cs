using Microsoft.EntityFrameworkCore;

using backlogSys.Models;
using backlogSys.Data;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace backlogSys.Controllers
{
    public class MembrosController : Controller{


        /// <summary>
        /// Cria uma referência à base de dados do projeto
        /// </summary>
        private readonly ApplicationDbContext _context;


        /// <summary>
        /// Dados Servidor ASP .NET
        /// </summary>
        private readonly IWebHostEnvironment _webHostEnvironment;


        public MembrosController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment) {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        //GET: Membro
        public async Task<IActionResult> Index() {
            return View(await _context.Membros.ToListAsync());
        }

        //GET: Membros/Details
        public async Task<IActionResult> Details(int? id){
            if (id == null){
                return NotFound();
            }

            var membroEquipa = await _context.Membros.FirstOrDefaultAsync(m => m.Id == id);
            if(membroEquipa == null){
                return NotFound();
            }
            return View(membroEquipa);
        }


        //GET: Membros/Create
        /// <summary>
        /// Cria a view para adicionar um Membro a uma equipa
        /// </summary>

        public IActionResult Create() {
            return View();
        }

        //POST: Membros/Create  FALTA FOTOGRAFIA
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Email,Efetividade,Foto,EquipaFK")] MembrosEquipa membros) {


            if (ModelState.IsValid) {
                _context.Add(membros);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(membros);
        }

        //GET: Membros/Edit
        public async Task<IActionResult> Edit(int? id) {
            if (id == null) {
                return RedirectToAction("Index");
            }

            var membroEquipa = await _context.Membros.FindAsync(id);
            if(membroEquipa == null) {
                return RedirectToAction("Index");
            }

            
            HttpContext.Session.SetInt32("idMem", membroEquipa.Id);

            return View(membroEquipa);
        }

        //POST: Membros/Edit  FALTA FOTOGRAFIA
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Email,Efetividade,Foto,EquipaFK")] MembrosEquipa membroEquipa) {
            if(id != membroEquipa.Id) {
                return NotFound();
            }
            
            int? idMembro = HttpContext.Session.GetInt32("idMem");

            if(idMembro == null) {
                ModelState.AddModelError("", "Ultrapassou o tempo limite para a edição dos dados");
                return View(membroEquipa);
            }

            //Verifica se os dados alterados são efetivamente do membro a editar
            if(idMembro != membroEquipa.Id) {
                return RedirectToAction("Index");
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update(membroEquipa);
                    await _context.SaveChangesAsync();

                } catch (DbUpdateConcurrencyException) {
                    if (!MembrosEquipaExists(membroEquipa.Id)) {
                        return NotFound();
                    } else {
                        throw;
                    }
                } catch (Exception) {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }

            return View(membroEquipa);
        }

        //GET: Membros/Delete
        public async Task<IActionResult> Delete(int? id) {
            if(id == null) {
                return NotFound();
            }
            var membroEquipa = await _context.Membros.FirstOrDefaultAsync(m => m.Id == id);
            if (membroEquipa == null) {
                return NotFound();
            }
            return View(membroEquipa);
        }

        //POST: Membros/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) {
            var membroEquipa = await _context.Membros.FindAsync(id);
            _context.Membros.Remove(membroEquipa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool MembrosEquipaExists(int id) {
            return _context.Membros.Any(e => e.Id == id);
        }
    }
}