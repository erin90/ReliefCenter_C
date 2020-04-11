using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectv1
{
    class ReliefCenter
    {
            int packsReleased = 0;
            string reliefCenterName;
            string reliefgoodN;
            int goodReleaseRate;
            string reliefUnit;
            List<ReliefGood> goods;

        public ReliefCenter(string n)
        {
            reliefCenterName = n;
            goods = new List<ReliefGood>();
        }

        public string AddNewGood(string n, int r, string u)
        {
            reliefgoodN = n;
            goodReleaseRate = r;
            reliefUnit = u;
            string message = "";

            if (FindGood(n) == null)
            {
                message = "\n" + reliefCenterName + " now accepts " + n;
                goods.Add(new ReliefGood(n, r, u)); 
            }
            else
            {
                message = "\n Sorry, " + reliefCenterName + " already accepts " + n;
            }
            return message;
        }

        public ReliefGood FindGood (string g)
        {
            ReliefGood refer = null;

            foreach (ReliefGood reliefgoodN in goods)
            {
                if(reliefgoodN.GetName().ToUpper() == g.ToUpper())
                {
                    refer = reliefgoodN;
                }
            }
            return refer;
        }

        public string GetName()
        {
            return reliefCenterName; 
        }

        public int GetPackCount()
        {
            return packsReleased;
        }

        public string PrintInventory()
        {
            string inventory = "";

            inventory += "\n==== INVENTORY ====\n" + "Packs Released: " + packsReleased.ToString() + "\n==================\n";


            foreach (ReliefGood reliefgoodN in goods)
            {
                inventory += reliefgoodN.GetName() + ": " + reliefgoodN.GetUnitsLeft() + " " + reliefgoodN.GetUnit() + "\n";
            }
            inventory += "==================\n";

            return inventory;
        }
        public string ReceiveGoods(string good, int num)
        {
            FindGood(good);
            string output = "";

            if (FindGood(good) is null)
            {
                output += "\n Sorry " + reliefCenterName + " does not accept " + good + " at the moment.";
            }
            else
            {
                FindGood(good).AddGoods(num);
                output += "\n" + reliefCenterName + " thanks you for your donation of " + num + " " + FindGood(good).GetUnit() + " of " + FindGood(good).GetName() + ".";
            }
            
            return output;
        }

        public string ReleasePacks(int num)
        {
            bool release = true;
            string output = "";


            foreach (ReliefGood reliefgoodN in goods)
            {
                if(reliefgoodN.GetUnitsLeft() < (reliefgoodN.GetReleaseRate() * num))
                {
                    release = false;
                    output += "\nSorry, " + reliefCenterName + " does not have enough to supply " + num + " packs.";
                    break;
                }
            }

            //Release packs if checking for units left was successful
            if (release)
            {
                foreach (ReliefGood reliefgoodN in goods)
                {
                    //Call method to release relief goods
                    reliefgoodN.ReleaseGoods(num);
                }
                output += "\n" + reliefCenterName + " released " + num + " requested pack/s.";
                packsReleased += num;
            }
            return output; 
        }
    }
}