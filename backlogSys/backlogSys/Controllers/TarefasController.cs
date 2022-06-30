using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

using backlogSys.Models;
using backlogSys.Data;

namespace backlogSys.Controllers
{
    public class TarefasController : Controller
    {
        /// <summary>
        /// Cria uma referência à base de dados do projeto
        /// </summary>
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// Dados Servidor ASP .NET
        /// </summary>
        private readonly IWebHostEnvironment _webHostEnvironment;


        public TarefasController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment){
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }


        //GET: Tarefas
        public async Task<IActionResult> Index(){
            return View(await _context.Tarefas.ToListAsync());
        }

        //GET: Tarefas/Details
        public async Task<IActionResult> Details(int? id) {
            if (id == null) {
                return NotFound();
            }

            var tarefa = await _context.Tarefas.FirstOrDefaultAsync(m => m.Id == id);
            if (tarefa == null) {
                return NotFound();
            }
            return View(tarefa);
        }

        //GET: Tarefas/Create
        /// <summary>
        /// Cria a view para adicionar uma tarefa
        /// </summary>

        public IActionResult Create() {
            return View();
        }

        //POST: Tarefas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo,Descricao,PontoSituacao,MembrosFK,DataCriacao,Prazo,DataConclusao")] Tarefas tarefa) {

            if (ModelState.IsValid) {
                _context.Add(tarefa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tarefa);
        }


        //GET: Tarefa/Edit
        public async Task<IActionResult> Edit(int? id) {
            if (id == null) {
                return RedirectToAction("Index");
            }

            var tarefa = await _context.Tarefas.FindAsync(id);
            if (tarefa == null) {
                return RedirectToAction("Index");
            }


            HttpContext.Session.SetInt32("id", tarefa.Id);

            return View(tarefa);
        }

        //POST: Tarefas/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,Descricao,PontoSituacao,MembrosFK,DataCriacao,Prazo,DataConclusao")] Tarefas tarefa) {
            if (id != tarefa.Id) {
                return NotFound();
            }



            int? idTarefa = HttpContext.Session.GetInt32("id");

            if (idTarefa == null) {
                ModelState.AddModelError("", "Ultrapassou o tempo limite para a edição dos dados");
                return View(tarefa);
            }

            //Verifica se os dados alterados são efetivamente da equipa a editar
            if (idTarefa != tarefa.Id) {
                return RedirectToAction("Index");
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update(tarefa);
                    await _context.SaveChangesAsync();

                } catch (DbUpdateConcurrencyException) {
                    if (!TarefaExists(tarefa.Id)) {
                        return NotFound();
                    } else {
                        throw;
                    }
                } catch (Exception) {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }

            return View(tarefa);
        }

        //GET: Tarefas/Delete
        public async Task<IActionResult> Delete(int? id) {
            if (id == null) {
                return NotFound();
            }
            var tarefa = await _context.Tarefas.FirstOrDefaultAsync(m => m.Id == id);
            if (tarefa == null) {
                return NotFound();
            }
            return View(tarefa);
        }

        //POST: Tarefas/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) {
            var tarefa = await _context.Tarefas.FindAsync(id);
            _context.Tarefas.Remove(tarefa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TarefaExists(int id) {
            return _context.Tarefas.Any(e => e.Id == id);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(){
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}