using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectv1
{
    class ReliefGood
    {
        string reliefgoodN;
        int goodReleaseRate;
        string reliefUnit;
        int inventory = 0;

        public ReliefGood(String n, int r, String u)
        {
            /// An instance of ReliefGood must have a name, a unit of measurement, and a release rate.
            /// n - the name of the ReliefGood, e.g. Spam
            /// r - the predetermined release rate of the ReliefGood
            /// u - the unit of measurement of the ReliefGood
            /// 
            reliefgoodN = n;
            goodReleaseRate = r;
            reliefUnit = u;
        }

        public void AddGoods(int num)
        {
            /// Increasess the total available units (supply) of the ReliefGood
            /// num - the number of units to be added

            inventory = inventory + num;
        }

        public string GetName()
        {
            /// Returns the name of the ReliefGood
            return reliefgoodN;
        }

        public int GetReleaseRate()
        {
            /// Returns the predetermined number of units released at one time
            return goodReleaseRate;
        }

        public string GetUnit()
        {
            /// Returns the unit of measurement of the ReliefGood
            return reliefUnit;
        }

        public int GetUnitsLeft()
        {
            /// Returns the total available units of ReliefGood
            return inventory;
        }

        public void ReleaseGoods(int num)
        {
            /// Decreases the total avilable units by the corresponding release rate
            inventory = inventory - (goodReleaseRate * num);

        }
    }
}
