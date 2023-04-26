using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project_Reisbureau.Bestemming;

namespace Project_Reisbureau
{
    internal class Strandhuis
    {
        public class Beachdestination : Destination
        {
            public Beachdestination(string name) : base(name)
            {
            }
        }
    }
}
