using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_Simulator_BL.Model
{
    public class Adres
    {
        public Adres(string straatnaam, string gemeente, string postcode, string huisnr)
        {
            Straatnaam = straatnaam;
            Gemeente = gemeente;
            Postcode = postcode;
            Huisnr = huisnr;
        }

        public string Straatnaam { get; set; }
        public string Gemeente { get; set; }
        public string Postcode { get; set; }
        public string Huisnr { get; set; }
    }
}
