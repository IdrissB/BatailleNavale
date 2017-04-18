using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    public class Case
    {
        Bateau bat;
        public Bateau Bat               // Topic is a named parameter
        {
            get
            {
                return bat;
            }
            set
            {

                bat = value;
            }
        }


        public Bateau isOccupated(){
            return null;
        }

        public static bool shooted()
        {
            return false;
        }
    }
}
