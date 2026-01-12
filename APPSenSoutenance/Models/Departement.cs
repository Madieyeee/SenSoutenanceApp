using System.ComponentModel.DataAnnotations;

namespace AppSenSoutenance.Models
{
    public class Departement
    {
        [Key]
        public int IdDepartement { get; set; }

        [Required, MaxLength(81)]
        public string LibelleDepartement { get; set; }
    }
}
