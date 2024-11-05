using Microsoft.EntityFrameworkCore;
using SalleDeGymAPI.Models;

namespace SalleDeGymAPI.Data
{
    public class SalleDeGymContext : DbContext
    {
        public SalleDeGymContext(DbContextOptions<SalleDeGymContext> options) : base(options) { }

        public DbSet<Abonnement> Abonnements { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Activite> Activites { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Paiement> Paiements { get; set; }
    }
}