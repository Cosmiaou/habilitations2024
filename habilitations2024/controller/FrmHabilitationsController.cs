using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mediatek86.dal;
using mediatek86.model;
using Mysqlx.Crud;

namespace mediatek86.controller
{
    public class FrmHabilitationsController
    {
        private readonly PersonnelAccess persoAccess;
        private readonly ServiceAccess servAccess;

        /// <summary>
        /// Constructeur
        /// </summary>
        public FrmHabilitationsController()
        {
            servAccess = new ServiceAccess();
            persoAccess = new PersonnelAccess();
        }

        /// <summary>
        /// Reçoit la liste du personnel
        /// </summary>
        /// <returns>List Developpeur</returns>
        public List<Personnel> GetLesPerso()
        {
            return persoAccess.GetLesPersonnels();
        }

        /// <summary>
        /// Reçoit la liste des services
        /// </summary>
        /// <returns>List Developpeur</returns>
        public List<Service> GetLesServices()
        {
            return servAccess.GetItems();
        }

        /// <summary>
        /// Appelle la fonction de suppression d'un développeur
        /// </summary>
        /// <param name="perso">Object de type Developpeur</param>
        public void DelItem (Personnel perso) {
            persoAccess.DelItem(perso);
        }

        /// <summary>
        /// Appelle la fonction d'ajout d'un développeur
        /// </summary>
        /// <param name="perso">Objet développeur</param>
        public void AddItem (Personnel perso) {
            persoAccess.AddItem(perso);
        }

        /// <summary>
        /// Appelle la fonction de MàJ d'un développeur
        /// </summary>
        /// <param name="perso">Objet développeur</param>
        public void UpdateItem (Personnel perso) {
            persoAccess.UpdateItem(perso);
        }
    }
}
