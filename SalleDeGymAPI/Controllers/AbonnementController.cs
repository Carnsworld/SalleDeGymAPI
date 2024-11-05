using Microsoft.AspNetCore.Mvc;
using SalleDeGymAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalleDeGymAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AbonnementController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AbonnementController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Récupérer tous les abonnements
        [HttpGet]
        public IEnumerable<Abonnement> GetAbonnements()
        {
            return _context.Abonnements.ToList();
        }

        // Créer un abonnement
        [HttpPost]


        public IActionResult CreateAbonnement([FromBody] Abonnement abonnement)
        {
            _context.Abonnements.Add(abonnement);
            _context.SaveChanges();
            return Ok(abonnement);
        }
    }
}

