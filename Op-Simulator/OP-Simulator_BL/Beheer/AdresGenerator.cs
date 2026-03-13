using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OP_Simulator_BL.Model;

namespace OP_Simulator_BL.Beheer
{
    public class AdresGenerator
    {
        private Random rn = new();
        private List<string> straten = new();
        private List<(string postcode, string gemeente)> gemeenten = new();
        private int minHsnr, maxHsnr;

        public AdresGenerator(List<string> straten, List<(string postcode, string gemeente)> gemeenten, int minHsnr, int maxHsnr)
        {
            this.straten = straten;
            this.gemeenten = gemeenten;
            this.minHsnr = minHsnr;
            this.maxHsnr = maxHsnr;
        }

        public List<Adres> GeefAdressen(int aantal)
        {
            var adressen = new List<Adres>();
            int n = 0;
            while (n < aantal)
            {
                int indexG = rn.Next(gemeenten.Count());
                int indexS = rn.Next(straten.Count());
                adressen.Add(new Adres(straten[indexS], gemeenten[indexG].gemeente, gemeenten[indexG].postcode, GenereerHuisnr()));
                n++;
            }
            return adressen;
        }

        private string GenereerHuisnr()
        {
            int nr = rn.Next(minHsnr, maxHsnr);
            return $"{nr}{rn.Next('a', 'd')}";
        }
    }
}
