﻿namespace SalleDeGymAPI.Models
{
    public class Paiement
    {
        public int Id { get; set; }
        public decimal Montant { get; set; }
        public DateTime Date { get; set; }

        public int UtilisateurId { get; set; }
        public Utilisateur Utilisateur { get; set; }

        public int AbonnementId { get; set; }
        public Abonnement Abonnement { get; set; }
    }
}
