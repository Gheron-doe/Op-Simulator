using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_Simulator_BL.Model
{
    public class Klant
    {
        public Klant(int id, string voornaam, string achternaam, string email, DateTime geboortedatum, Adres adres)
        {
            ID = id;
            Voornaam = voornaam;
            Achternaam = achternaam;
            Email = email;
            Geboortedatum = geboortedatum;
            Adres = adres;
        }

        public int ID { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Email { get; set; }
        public DateTime Geboortedatum { get; set; }
        public Adres Adres { get; set; }
    }
}
