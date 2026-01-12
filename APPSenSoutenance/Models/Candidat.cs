using APPSenSoutenance.Models;
using System.ComponentModel.DataAnnotations;

namespace AppSenSoutenance.Models
{
    public class Candidat : Utilisateur
    {
        [Required, MaxLength(22)]
        public string MatriculeCandidat { get; set; }
    }
}
