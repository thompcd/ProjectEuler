using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries;

namespace Projects
{
    class ProjectEuler
    {
        public void Solve()
        {
            int x;
            List<int> amicableList = new List<int>();
            for (x = 2; x < 10000; x++)
            {
                var factorListX = AdvancedMath.Factor(x);
                var sumX = factorListX.Sum() - factorListX[factorListX.Count - 1];

                var factorListY = AdvancedMath.Factor(sumX);
                var sumY = factorListY.Sum() - factorListY[factorListY.Count - 1];

                if (sumY == x && sumY != sumX)
                {
                    amicableList.Add(x);
                }
            }
                Console.WriteLine("Sum of all amicable numbers under 10000 is: " + amicableList.Sum());
                

            Console.ReadKey();

        }
    }
}
