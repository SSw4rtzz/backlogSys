using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

using backlogSys.Models;
using backlogSys.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace backlogSys.Controllers{


    /*
     * [Authorize] Todos os users autenticadas têm acesso 
     * 
     * [Authorize(Roles="Administrativo")] Apenas users autenticados com perfil "Administrativo" têm acesso
     * [Authorize(Roles="Administrativo,Funcionario")] Um ou outro
     * 
     * [Authorize(Roles="Administrativo")]  Tem de ter ambas as roles
     * [Authorize(Roles="Funcionario")]
     *  
     */

    [AllowAnonymous]
    public class MembrosController : Controller {


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
        public async Task<IActionResult> Details(int? id) {
            if (id == null) {
                return NotFound();
            }

            var membroEquipa = await _context.Membros.FirstOrDefaultAsync(m => m.Id == id);
            if (membroEquipa == null) {
                return NotFound();
            }
            return View(membroEquipa);
        }


        //GET: Membros/Create
        /// <summary>
        /// Cria a view para adicionar um Membro a uma equipa
        /// </summary>

        public IActionResult Create() {
            ViewData["EquipaFK"] = new SelectList(_context.Equipa.OrderBy(e => e.Nome), "Id", "Nome");
            return View();
        }

        //POST: Membros/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Email,Efetividade,Foto,EquipaFK")] MembrosEquipa membros, IFormFile foto) {


            //Caso não seja fornecida uma foto, é atribuido uma foto padrão com o nome null.jpg
            if (foto == null) {
                membros.Foto = "null.jpg";
            } else {
                //Verifica se o ficheiro inserido é uma imagem válida, se não for, mostra mensagem de erro
                if (!(foto.ContentType == "image/jpeg" || foto.ContentType == "image/png")) {
                    ModelState.AddModelError("", "Por favor insira um ficheiro do tipo jpg ou png");
                    return View(membros);
                } else {
                    string nomeImag = "";
                    Guid g;
                    g = Guid.NewGuid();
                    nomeImag = g.ToString();
                    string typeImag = Path.GetExtension(foto.FileName).ToLower(); //Guarda formato da imagem
                    nomeImag += typeImag;
                    membros.Foto = nomeImag;
                }
            }

        //Valida dados e se válidos, adiciona à Base de Dados e guarda numa pasta com nome "Fotos"
        if (ModelState.IsValid) {
            try {
                _context.Add(membros);
                await _context.SaveChangesAsync();
            } catch (Exception ex) {
                ModelState.AddModelError("", "Não foi possivel guardar os dados introduzidos na base de dados");
                return View(membros);
            }

            //Verifica se foi enviada uma fotografia e guarda-a no destino Fotos
            if (foto != null) {
                string destImag = _webHostEnvironment.WebRootPath;
                if (!Directory.Exists(Path.Combine(destImag, "Fotos"))) { //Cria diretorio Fotos, caso este ainda não exista
                    Directory.CreateDirectory(Path.Combine(destImag, "Fotos"));
                }
                destImag = Path.Combine(destImag, "Fotos", membros.Foto);
                using var stream = new FileStream(destImag, FileMode.Create); //Guarda a fotografia na pasta Fotos
                await foto.CopyToAsync(stream);
            }
                return RedirectToAction(nameof(Index));
        }

            ViewData["EquipaFK"] = new SelectList(_context.Equipa, "Id", "Id", membros.EquipaFK);
            return View(membros);
    }

        //GET: Membros/Edit
        public async Task<IActionResult> Edit(int? id) {
            if (id == null) {
                return RedirectToAction("Index");
            }
            ViewData["EquipaFK"] = new SelectList(_context.Equipa.OrderBy(e => e.Nome), "Id", "Nome");

            var membroEquipa = await _context.Membros.FindAsync(id);
            if(membroEquipa == null) {
                return RedirectToAction("Index");
            }

            
            HttpContext.Session.SetInt32("idMem", membroEquipa.Id);

            return View(membroEquipa);
        }

        //POST: Membros/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Email,Efetividade,Foto,EquipaFK")] MembrosEquipa membroEquipa, IFormFile foto) {
            if(id != membroEquipa.Id) {
                return NotFound();
            }

            int? idMembro = HttpContext.Session.GetInt32("idMem");

            //Limite de tempo para edição de dados
            if(idMembro == null) {
                ModelState.AddModelError("", "Ultrapassou o tempo limite para a edição dos dados");
                return View(membroEquipa);
            }

            //Verifica se os dados alterados são efetivamente do membro a editar
            if(idMembro != membroEquipa.Id) {
                return RedirectToAction("Index");
            }

            //Caso não seja fornecida uma foto, é atribuido uma foto padrão com o nome null.jpg
            if (foto == null) {
                
            } else {
                //Verifica se o ficheiro inserido é uma imagem válida, se não for, mostra mensagem de erro
                if (!(foto.ContentType == "image/jpeg" || foto.ContentType == "image/png")) {
                    ModelState.AddModelError("", "Por favor insira um ficheiro do tipo jpg ou png");
                    return View(membroEquipa);
                } else {
                    string nomeImag = "";
                    Guid g;
                    g = Guid.NewGuid();
                    nomeImag = g.ToString();
                    string typeImag = Path.GetExtension(foto.FileName).ToLower(); //Guarda formato da imagem
                    nomeImag += typeImag;
                    membroEquipa.Foto = nomeImag;
                }
            }

            //Valida dados e se válidos, adiciona à Base de Dados e guarda numa pasta com nome "Fotos"
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
                    ModelState.AddModelError("", "Não foi possivel guardar os dados introduzidos na base de dados");
                    throw;
                }

                //Verifica se foi enviada uma fotografia e guarda-a no destino Fotos
                if (foto != null) {
                    string destImag = _webHostEnvironment.WebRootPath;
                    if (!Directory.Exists(Path.Combine(destImag, "Fotos"))) { //Cria diretorio Fotos, caso este ainda não exista
                        Directory.CreateDirectory(Path.Combine(destImag, "Fotos"));
                    }
                    destImag = Path.Combine(destImag, "Fotos", membroEquipa.Foto);
                    using var stream = new FileStream(destImag, FileMode.Create); //Guarda a fotografia na pasta Fotos
                    await foto.CopyToAsync(stream);
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["EquipaFK"] = new SelectList(_context.Equipa, "Id", "Id", membroEquipa.EquipaFK);

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
        //Criado em contexto de base de dados um trigger que elimina também o user,
        //ou seja, uma vez que um funcionário é eliminado a sua conta também deixa de existir
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