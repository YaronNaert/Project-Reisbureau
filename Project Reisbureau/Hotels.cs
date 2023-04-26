using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project_Reisbureau.Bestemming;

namespace Project_Reisbureau
{
    internal class Hotels
    {
        public class Hotel:Bestemming
        {

            public Hotel(string name, double price,bool halfP, bool fullP, bool autoH, bool uitv)
            {
                hotelNaam = name;
                prijs = price;
                HalfPension = halfP;
                VolPension = fullP;
                AutoHuren = autoH;
                uitverkocht = uitv;
            }
        }
    }
}
