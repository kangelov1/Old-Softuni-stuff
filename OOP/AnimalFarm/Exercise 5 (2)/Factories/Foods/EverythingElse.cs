using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5__2_.Factories.Foods
{
    public class EverythingElse:Food
    {
        private const int PointsOfHappiness = -1;

        public EverythingElse() : base(PointsOfHappiness) { }
    }
}
