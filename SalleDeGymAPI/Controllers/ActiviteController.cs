using Microsoft.AspNetCore.Mvc;
using SalleDeGymAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalleDeGymAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActiviteController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ActiviteController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Récupérer toutes les activités
        [HttpGet]
        public IEnumerable<Activite> GetActivites()
        {
            return _context.Activites.ToList();
        }

        // Créer une activité
        [HttpPost]
        public IActionResult CreateActivite([FromBody] Activite activite)
        {
            _context.Activites.Add(activite);
            _context.SaveChanges();
            return Ok(activite);
        }
    }
}

