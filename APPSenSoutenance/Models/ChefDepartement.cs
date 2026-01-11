using AppSenSoutenance.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace APPSenSoutenance.Models
{
    public class ChefDepartement : Utilisateur
    {

        public int? IdDepartement { get; set; }

        [ForeignKey("IdDepartement")]
        public virtual Departement Departement { get; set; }

        public virtual ICollection<Professeur> Profsseurs { get; set; }
    }
}
