using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backlogSys.Data;
using backlogSys.Models;

namespace backlogSys.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembrosAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public MembrosAPIController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._webHostEnvironment = hostEnvironment;
        }

        // GET: api/MembrosAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MembrosViewModel>>> GetMembros(){
              return await _context.Membros
                .Include(a => a.Equipa).OrderByDescending(a => a.Id)
                .Select(a => new MembrosViewModel{
                    Id = a.Id,
                    Nome = a.Nome,
                    Email = a.Email,
                    Efetividade = a.Efetividade,
                    Foto = a.Foto,
                    NomeEquipa = a.Equipa.Nome
                }).ToListAsync();
            }

        // GET: api/MembrosAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MembrosEquipa>> GetMembrosEquipa(int id){
          if (_context.Membros == null){
              return NotFound();
          }
            var membrosEquipa = await _context.Membros.FindAsync(id);

            if (membrosEquipa == null){
                return NotFound();
            }

            return membrosEquipa;
        }

        // PUT: api/MembrosAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMembrosEquipa(int id, MembrosEquipa membrosEquipa) { //, IFormFile uploadFoto) {
            if (id != membrosEquipa.Id){
                return BadRequest();
            }
            //Tentativa falhada de editar a fotografia pela API
            /*
            string nomeImag = "";
            Guid g;
            g = Guid.NewGuid();
            nomeImag = g.ToString();
            string typeImag = Path.GetExtension(uploadFoto.FileName).ToLower(); //Guarda formato da imagem
            nomeImag += typeImag;
            membrosEquipa.Foto = nomeImag;

            //Valida dados e se válidos, adiciona à Base de Dados e guarda numa pasta com nome "Fotos"
            if (ModelState.IsValid) {
                try {
                    _context.Update(membrosEquipa);
                    await _context.SaveChangesAsync();
                } catch (Exception ex) {
                    ModelState.AddModelError("", "Não foi possivel guardar os dados introduzidos na base de dados");
                }

                //Verifica se foi enviada uma fotografia e guarda-a no destino Fotos
                if (uploadFoto != null) {
                    string destImag = _webHostEnvironment.WebRootPath;
                    if (!Directory.Exists(Path.Combine(destImag, "Fotos"))) { //Cria diretorio Fotos, caso este ainda não exista
                        Directory.CreateDirectory(Path.Combine(destImag, "Fotos"));
                    }
                    destImag = Path.Combine(destImag, "Fotos", membrosEquipa.Foto);
                    using var stream = new FileStream(destImag, FileMode.Create); //Guarda a fotografia na pasta Fotos
                    await uploadFoto.CopyToAsync(stream);
                }
            }*/

            _context.Entry(membrosEquipa).State = EntityState.Modified;

            try{
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException){
                if (!MembrosEquipaExists(id)){
                    return NotFound();
                }
                else{
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/MembrosAPI
        // [FromForm] -> FormData
        [HttpPost]
        public async Task<ActionResult<MembrosEquipa>> PostMembrosEquipa([FromForm] MembrosEquipa membrosEquipa, IFormFile uploadFoto){

            //Caso não seja fornecida uma foto, é atribuido uma foto padrão com o nome null.jpg
            if (uploadFoto == null) {
                membrosEquipa.Foto = "null.jpg";
            } else {
                string nomeImag = "";
                Guid g;
                g = Guid.NewGuid();
                nomeImag = g.ToString();
                string typeImag = Path.GetExtension(uploadFoto.FileName).ToLower(); //Guarda formato da imagem
                nomeImag += typeImag;
                membrosEquipa.Foto = nomeImag;
            }
            

            //Valida dados e se válidos, adiciona à Base de Dados e guarda numa pasta com nome "Fotos"
            if (ModelState.IsValid) {
                try {
                    _context.Add(membrosEquipa);
                    await _context.SaveChangesAsync();
                } catch (Exception ex) {
                    ModelState.AddModelError("", "Não foi possivel guardar os dados introduzidos na base de dados");
                }

                //Verifica se foi enviada uma fotografia e guarda-a no destino Fotos
                if (uploadFoto != null) {
                    string destImag = _webHostEnvironment.WebRootPath;
                    if (!Directory.Exists(Path.Combine(destImag, "Fotos"))) { //Cria diretorio Fotos, caso este ainda não exista
                        Directory.CreateDirectory(Path.Combine(destImag, "Fotos"));
                    }
                    destImag = Path.Combine(destImag, "Fotos", membrosEquipa.Foto);
                    using var stream = new FileStream(destImag, FileMode.Create); //Guarda a fotografia na pasta Fotos
                    await uploadFoto.CopyToAsync(stream);
                }
            }

            return CreatedAtAction("GetMembrosEquipa", new { id = membrosEquipa.Id }, membrosEquipa);

        }


        // DELETE: api/MembrosAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMembrosEquipa(int id)
        {
            if (_context.Membros == null)
            {
                return NotFound();
            }
            var membrosEquipa = await _context.Membros.FindAsync(id);
            if (membrosEquipa == null)
            {
                return NotFound();
            }

            _context.Membros.Remove(membrosEquipa);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MembrosEquipaExists(int id)
        {
            return (_context.Membros?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
