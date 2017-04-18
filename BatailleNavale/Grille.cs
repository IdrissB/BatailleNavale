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

        public Grille(int x, int y)
        {
            matCases = new Case[x,y];
        }

        public  Bateau caseIsOccupated(int x, int y){
            return matCases[x, y].isOccupated();
        }
    }
}
 