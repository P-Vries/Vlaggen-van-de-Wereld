using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VlaggenVanDeWereld
{
    class Land
    {
        //
        //Operator
        //
        public Land(string naam, string VlagURL)
        {
            Naam = naam;
            Vlag = VlagURL;
        }

        //
        //Public Vars
        //
        public string Naam { get; set; }
        public string Vlag { get; set; }

        //
        //OVERRIDES
        //
        public  string ToLand()
        {
            return Naam + "," + Vlag;
        }
    }
}
