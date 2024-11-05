using Microsoft.AspNetCore.Mvc;
using SalleDeGymAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalleDeGymAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateurController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UtilisateurController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Récupérer tous les utilisateurs
        [HttpGet]
        public IEnumerable<Utilisateur> GetUtilisateurs()
        {
            return _context.Utilisateurs.ToList();
        }

        // Créer un utilisateur
        [HttpPost]
        public IActionResult CreateUtilisateur([FromBody] Utilisateur utilisateur)
        {
            _context.Utilisateurs.Add(utilisateur);
            _context.SaveChanges();
            return Ok(utilisateur);
        }
    }
}
