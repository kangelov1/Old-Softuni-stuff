using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5__2_.Factories.Foods
{
    public class HoneyCake:Food
    {
        private const int PointsOfHappiness = 5;

        public HoneyCake():base(PointsOfHappiness){ }
    }
}
