using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

using backlogSys.Models;
using backlogSys.Data;

namespace backlogSys.Controllers{
    [Authorize(Roles = "Administrativo,Funcionario")]
    public class TarefasController : Controller{
        /// <summary>
        /// Cria uma referência à base de dados do projeto
        /// </summary>
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// Dados Servidor ASP .NET
        /// </summary>
        private readonly IWebHostEnvironment _webHostEnvironment;

        /// <summary>
        /// Dados do User autenticado
        /// </summary>
        private readonly UserManager<ApplicationUser> _userManager;


        public TarefasController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment, UserManager<ApplicationUser> userManager){
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            _userManager = userManager;
        }


        //GET: Tarefas
        public async Task<IActionResult> Index(){
            //Mostra apenas as tarefas da autoria do Utilizador
            if (User.IsInRole("Funcionario")) {
                string idAuthenticatedUser = _userManager.GetUserId(User); //Id do user autenticado
                var tarefas = _context.Tarefas
                    .Include(a => a.Membros)
                    .Where(a => a.Membros.UserId == idAuthenticatedUser);


            return View(await tarefas.ToListAsync());
            }
            var allTarefas = _context.Tarefas.Include(a => a.Membros);
            return View(await allTarefas.ToListAsync());
        }

        //GET: Tarefas/Details
        public async Task<IActionResult> Details(int? id) {
            if (id == null || _context.Tarefas == null) {
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
            ViewData["MembrosFK"] = new SelectList(_context.Membros.OrderBy(m => m.Nome), "Id", "Nome");
            return View();
        }

        //POST: Tarefas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo,Descricao,PontoSituacao,MembrosFK,DataCriacao,Prazo,DataConclusao,Prioridade")] Tarefas tarefa) {

            string idAuthenticatedUser = _userManager.GetUserId(User); //Id do user autenticado
            var idMembro = _context.Membros
                .Where(m => m.UserId == idAuthenticatedUser)
                .FirstOrDefault().Id;

            tarefa.MembrosFK = idMembro;

            if (ModelState.IsValid) {
                _context.Add(tarefa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["MembrosFK"] = new SelectList(_context.Tarefas, "Id", "Id", tarefa.MembrosFK);
            return View(tarefa);
        }


        //GET: Tarefa/Edit
        public async Task<IActionResult> Edit(int? id) {
            if (id == null || _context.Tarefas == null) {
                return RedirectToAction("Index");
            }
            ViewData["MembrosFK"] = new SelectList(_context.Membros.OrderBy(m => m.Nome), "Id", "Nome");

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
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,Descricao,PontoSituacao,MembrosFK,DataCriacao,Prazo,DataConclusao,Prioridade")] Tarefas tarefa) {
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
                    ModelState.AddModelError("", "Não foi possivel guardar os dados introduzidos na base de dados");
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }

            ViewData["MembrosFK"] = new SelectList(_context.Tarefas, "Id", "Id", tarefa.MembrosFK);
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