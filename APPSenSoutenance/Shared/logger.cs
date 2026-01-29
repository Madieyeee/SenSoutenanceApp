using APPSenSoutenance.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPSenSoutenance.Shared
{
    public static class logger
    {
        /// <summary>
        /// Rédiger les erreurs au niveau de la base de données
        /// </summary>
        /// <param name="titre">la titre provequant l'erreur</param>
        /// <param name="erreur">le message d'erreur</param>
        public static void WriteDataError(string TitreErreur, string erreur)
        {
            try
            {
                BdSenSoutenanceContext db = new BdSenSoutenanceContext();
                Td_Erreur log = new Td_Erreur();
                log.DateErreur = DateTime.Now;
                log.DescriptionErreur = erreur.Length > 2000 ? erreur.Substring(0, 2000) : erreur;
                log.TitreErreur = TitreErreur;
                db.Td_Erreur.Add(log);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                WriteLogSystem(ex.ToString(), "WriteDataError");
            }
        }

        /// <summary>
        /// Pour logger au niveau des fichiers
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static bool CreateFile(string message)
        {
            bool rep = false;
            string fileName = string.Format("{0}{1}{2}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            try
            {
                string path = "~/Error/" + fileName + ".txt"; //System.Web.HttpContext.Current.Server.MapPath();
                if (!File.Exists(path))
                {
                    File.Create(path);
                    //File.Delete(path);
                }

                bool fileUse = true;
                while (fileUse)
                {
                    try
                    {
                        System.IO.TextWriter writeFile = new StreamWriter(path, true);
                        writeFile.WriteLine("" + DateTime.Now);
                        writeFile.WriteLine(message);
                        writeFile.WriteLine("-------------------------------------------");
                        writeFile.Flush();
                        writeFile.Close();
                        writeFile = null;
                        fileUse = false;
                    }
                    catch (Exception e)
                    {
                        WriteLogSystem(e.ToString(), "CreateFile");
                    }
                }
                rep = true;
            }
            catch (IOException e)
            {
                WriteLogSystem(e.ToString(), "WriteFileError");
            }
            return rep;
        }

        /// <summary>
        /// Enregistrer les Logs dans le systeme d'exploitation
        /// </summary>
        /// <param name="erreur"></param>
        /// <param name="libelle"></param>
        public static void WriteLogSystem(string erreur, string libelle)
        {
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "DPV Permis";
                eventLog.WriteEntry(string.Format("date: {0}, libelle: {1}, description {2}", DateTime.Now, libelle, erreur), EventLogEntryType.Information, 101, 1);
            }
        }
    }
}
