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
            allPremiums.Add(decimal.Parse(premiumString));
        }

        public List<decimal> sortPremiums() {
            List<decimal> sortedPremiums = allPremiums;
            sortedPremiums.Sort();

            return sortedPremiums;
        }


    }
}
