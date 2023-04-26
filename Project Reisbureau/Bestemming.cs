using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Reisbureau
{
    internal abstract class Bestemming
    {
        protected double prijs {get;set; }
        protected string hotelNaam { get;set; }
        protected bool uitverkocht{ get; set; }
        protected bool HalfPension { get; set; }
        protected bool VolPension { get; set; }
        protected bool AutoHuren { get; set; }

        abstract protected void verblijf(string name, double price, bool halfP, bool fullP, bool autoH, bool uitv);
    }
}
