using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Turns
    {
        public static int getRightTurns(int turnCount, LinkedList<String> dirLst)
        {
            int rightTurns = 0;

            if (dirLst.Count() > 1)
            {
                String firstDirection = dirLst.First();
                String secondDirection = dirLst.ElementAt(1);

                if (String.Equals((String)firstDirection, (String)"N"))
                {
                    if (String.Equals((String)secondDirection, (String)"E")) { turnCount++; }
                }
                if (String.Equals((String)firstDirection, (String)"E"))
                {
                    if (String.Equals((String)secondDirection, (String)"S")) { turnCount++; }
                }
                if (String.Equals((String)firstDirection, (String)"S"))
                {
                    if (String.Equals((String)secondDirection, (String)"W")) { turnCount++; }
                }
                if (String.Equals((String)firstDirection, (String)"W"))
                {
                    if (String.Equals((String)secondDirection, (String)"N")) { turnCount++; }
                }

                if (dirLst.Count() > 1)
                {
                    dirLst.RemoveFirst();
                    return getRightTurns(turnCount, dirLst);
                }

            }
            if (dirLst.Count() == 1)
            {
                return turnCount;
            }

            return rightTurns;
        }
    }
}
