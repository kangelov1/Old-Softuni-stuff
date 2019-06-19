using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5__2_.Factories.Moods
{
    public abstract class Mood
    {
        private int pointsOfHappiness;

        public Mood(int pointsOfHappiness)
        {
            this.pointsOfHappiness = pointsOfHappiness;
        }
    }
}
