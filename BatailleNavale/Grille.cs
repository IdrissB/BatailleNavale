using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class Grille
    {
        Case[,] matCases;

        public Case[,] MatCases               // Topic is a named parameter
        {
            get
            {
                return matCases;
            }
            set
            {

                matCases = value;
            }
        }

        public Grille(int x, int y)
        {
            matCases = new Case[x,y];
        }

        public static Bateau caseIsOccupated(int x, int y){
            return null;
        }
    }
}
 