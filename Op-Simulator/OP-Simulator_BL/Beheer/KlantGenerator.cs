using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OP_Simulator_BL.Model;

namespace OP_Simulator_BL.Beheer
{
    public class KlantGenerator
    {
        private Random rn = new();
        private List<string> voornamen = new();
        private List<string> familienamen = new();
        private List<Adres> adressen = new();
        private List<string> emailextensies = new List<string>() {"hotmail.com", "gmail.com", "outlook.com"};
        private int minLeeftijd, maxLeeftijd, minId, maxId;

        public KlantGenerator(List<string> voornamen, List<string> familienamen, List<Adres> adressen, int minLeeftijd, int maxLeeftijd, int minId, int maxId)
        {
            this.voornamen = voornamen;
            this.familienamen = familienamen;
            this.adressen = adressen;
            this.minLeeftijd = minLeeftijd;
            this.maxLeeftijd = maxLeeftijd;
            this.minId = minId;
            this.maxId = maxId;
        }

        public List<Klant> MaakKlanten(int aantal)
        {
            var data = new HashSet<Klant>();
            var aantalGemaakt = 0;

            while (aantalGemaakt < aantal)
            {
                var id = rn.Next(minId, maxId);
                var vn = voornamen[rn.Next(voornamen.Count())];
                var fn = familienamen[rn.Next(familienamen.Count())];
                var email = MaakEmail(vn, fn);
                var gd = MaakGeboortedatum(minLeeftijd, maxLeeftijd);
                var adres = adressen[rn.Next(adressen.Count())];

                var k = new Klant(id, vn, fn, email, gd, adres);
                if (!data.Contains(k))
                {
                    data.Add(k);
                    aantalGemaakt++;
                }
            }

            return data.ToList();
        }

        private string MaakEmail(string vn, string fn)
        {
            return $"{vn}.{fn}@{emailextensies[rn.Next(emailextensies.Count())]}";
        }
        
        private DateTime MaakGeboortedatum(int minLeeftijd, int maxLeeftijd)
        {
            var now = DateTime.Now;
            var min = now.AddYears(-minLeeftijd);
            var max = now.AddYears(-maxLeeftijd);
            var span = min - max;
            var range = span.TotalSeconds;
            return max.AddSeconds(rn.NextDouble()*range);
        }
    }
}
