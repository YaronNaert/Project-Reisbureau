using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project_Reisbureau.Bestemming;

namespace Project_Reisbureau
{
    internal abstract class Stadsverblijf:Bestemming
    {
        public List<String> City = new List<string> { "Berlijn", "Parijs", "Brussel", "Budapest" };
    }
}
