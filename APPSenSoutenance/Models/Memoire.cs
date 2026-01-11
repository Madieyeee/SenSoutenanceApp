using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APPSenSoutenance.Models
{
    internal class Memoire
    {
        [Key]
        public int IdMemoire { get; set; }
        [MaxLength(500), Required]

        public string SujetMemoire { get; set; }

        public int? IdAnneeAcademique { get; set; }

        [ForeignKey("IdAnneeAcademique")]

        public virtual AnneeAcademique AnneeAcademique { get; set; }

        //Le Byte c'est pour qu'on puisse stocker des fichiers de tout type (pdf, docx, pptx, etc) et le lire.
        public byte[] DocumentMemoire { get; set; }
        public int IdSession { get; set; }

        [ForeignKey("IdSession")]

        public virtual Session Session { get; set; }
    }
}
