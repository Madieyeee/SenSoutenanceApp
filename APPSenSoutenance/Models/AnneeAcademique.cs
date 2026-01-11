using System.ComponentModel.DataAnnotations;

namespace APPSenSoutenance.Models
{
    public class AnneeAcademique
    {
        [Key]
        public int IdAnneeAcademique { get; set; }

        [Required, MaxLength(10)]
        public string LibelleAnneeAcademique { get; set; }

        [Required]
        public int AnneeAcademiqueVal { get; set; }
    }
}
