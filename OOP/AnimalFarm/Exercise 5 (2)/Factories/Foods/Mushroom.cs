using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5__2_.Factories.Foods
{
    public class Mushroom:Food
    {
        private const int PointsOfHappines = -10;

        public Mushroom() : base(PointsOfHappines) { }
    }
}
