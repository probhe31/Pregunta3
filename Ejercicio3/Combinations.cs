using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    //cn m ? mfac / nfac (m-n)fac

    class Combinations
    {
        
        public long CountCombinations(int n , int level)
        {
            if (n < 0)
            {
                return 0;
            }

            if(n==0 && level == 0)
            {
                return 0;
            }

            if(n==0 && level > 0)
            {
                return 1;
            }

            return CountCombinations(n - 1, level + 1) + 
                   CountCombinations(n - 2, level + 1) + 
                   CountCombinations(n - 3, level + 1);


        }


        public void DynamicCombination()
        {
            List<List<int>> list = new List<List<int>>() {
                new List<int>(){ 1,2,3},
                new List<int>(){ 1,2},
                new List<int>(){ 1}
            };

        }
    }

}
