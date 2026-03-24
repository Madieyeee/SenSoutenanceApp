using APPSenSoutenance.Models;
using System.ComponentModel.DataAnnotations;

namespace APPSenSoutenance.Models
{
    public class Professeur : Utilisateur
    {
        [Required, MaxLength(80)]
        public string SpecialiteProfesseur { get; set; }

    }
}
