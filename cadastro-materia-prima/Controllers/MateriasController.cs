using cadastro_materia_prima.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace cadastro_materia_prima.Controllers
{
    public class MateriasController : Controller
    {
        private readonly AppDbContext _context;
        public MateriasController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Materias.ToListAsync();
            
            return View(dados);
        }

        public IActionResult Create()
        {
        return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Materia materia)
        {
            if(ModelState.IsValid)
            {
                _context.Materias.Add(materia);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            
            }
            return View(materia);
        }

        public async Task<IActionResult> Edit(int? id)            
        {
            if(id == null)
                return NotFound();

            var dados = await _context.Materias.FindAsync(id);

            if(dados == null)
                return NotFound();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Materia materia)
        {
            if(id != materia.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Materias.Update(materia);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");

            }


            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {  
            if(id == null)
                return NotFound();         
            
            var dados = await _context.Materias.FindAsync(id);
            
            if (dados == null)
                return NotFound();


            return View(dados);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Materias.FindAsync(id);

            if (dados == null)
                return NotFound();


            return View(dados);
        }


        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Materias.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.Materias.Remove(dados);
            await _context.SaveChangesAsync();


            return RedirectToAction("Index");
        }



    }
}
