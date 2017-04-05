using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class Grille
    {
        ccase[,] matCases;

        public Grille(int x, int y)
        {
            matCases = new ccase[x,y];
        }

        public static Bateau caseIsOccupated(int x, int y){
            return matCases[x, y].isOccupated();
        }
    }
}
 