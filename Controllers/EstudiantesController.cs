using Metricas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Metricas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstudiantesController : Controller
    {
        private readonly MetricasDBContext _context;

        public EstudiantesController(MetricasDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> PostEstudiante(Estudiante estudiante)
        {
            _context.Estudiantes.Add(estudiante);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> GetEstudiantes()
        {
            return Ok(await _context.Estudiantes.ToListAsync());
        }
    }
}
