namespace SalleDeGymAPI.Models
{
    public class Utilisateur
    {
        public int Utilisateur_id { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
        public string Mot_de_passe { get; set; }
        public string Telephone { get; set; }
        public string Role { get; set; }
        public int Abonnement_id { get; set; }
        public Abonnement Abonnement { get; set; }
    }
}