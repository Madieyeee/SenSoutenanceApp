using AppSenSoutenance.Models;
using APPSenSoutenance.Models;
using System.Collections.Generic;
using System.Linq;

namespace AppSenSoutenance.Shared
{
    public class FillerList
    {
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();
        public List<ListItem> FillAnneeAcademique()
        /// <summary>
        /// Remplit la liste des années académiques
        /// </summary>
        /// returns>Liste des années académiques</returns>

        {
            List<ListItem> laListe = new List<ListItem>();
            var liste = db.AnneeAcademiques.ToList();
            laListe.Add(new ListItem
            {
                Value = null,
                Text = "Selectionner"
            });
            foreach (var t in liste)
            {
                var item = new ListItem
                {
                    Value = t.IdAnneeAcademique.ToString(),
                    Text = t.LibelleAnneeAcademique.ToString()
                };
                laListe.Add(item);
            }
            return laListe;
        }

    }
}
