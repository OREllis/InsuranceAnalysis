using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProgramPE
{
    class InsuranceAnalysis
    {
        public List<decimal> allPremiums = new List<decimal>();

        
        public void addPremium(string premiumString) {
            //converts string to decimal, adds converted string to List
            allPremiums.Add(decimal.Parse(premiumString));
        }

        //makes new list, sorts it, then returns it
        public List<decimal> sortPremiums() {
            List<decimal> sortedPremiums = allPremiums;
            sortedPremiums.Sort();

            return sortedPremiums;
        }

        //finds biddest number in list
        public decimal maxList() {
            decimal max = allPremiums[0];
            foreach (int i in allPremiums)
                max = (max < i) ? i : max;

            return max;
        }

        //finds smallest num in list
        public decimal minList() {
            decimal min = allPremiums[0];
            foreach (int i in allPremiums)
                min = (min > i) ? i : min;

            return min;
        }

        //gets list average
        public decimal avgList() {
            return (decimal)allPremiums.Count() / totalList();
        }

        //gets total of all list items added together
        public int totalList() {
            int total = 0;
            foreach (int i in allPremiums)
                total += i;

            return total;
        }
    }
}
