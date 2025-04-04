using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace habilitations2024.model
{
    public class Developpeur
    {
        public Developpeur(int iddeveloppeur, string nom, string prenom, string tel, string mail, Profil profil) { 
            this.Iddeveloppeur = iddeveloppeur;
            this.Nom = nom;
            this.Prenom = prenom;   
            this.tel = tel;
            this.Mail = mail;
            this.Profil = profil;
        }

        public int Iddeveloppeur { get;  }
        public string Nom { get; set; }    
        public string Prenom { get; set; }
        public string tel { get; set; }
        public Profil Profil { get; set; }
        public string Mail { get; set; }
    }
}
