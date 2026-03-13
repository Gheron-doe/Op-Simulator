using OP_Simulator_BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_Simulator_BL.Beheer
{
    public class AdresGenerator
    {
        private Random rn = new();
        private List<string> straten = new();
        private List<(int postcode, string gemeente)> gemeenten = new();
        private int minHsnr, maxHsnr;

        public AdresGenerator(List<string> straten, List<(int postcode, string gemeente)> gemeenten, int minHsnr, int maxHsnr)
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

            while(n < aantal)
            {
                int indexS = rn.Next(straten.Count());
                int indexG = rn.Next(gemeenten.Count());
                adressen.Add(new Adres(straten[indexS], gemeenten[indexG].postcode, gemeenten[indexG].gemeente, GenereerHuisnr()));
                n++;
            }

            return adressen;
        }

        public string GenereerHuisnr()
        {
            int nr = rn.Next(minHsnr, maxHsnr);

            return $"{nr}{rn.Next('a', 'd')}";
        }
    }
}
