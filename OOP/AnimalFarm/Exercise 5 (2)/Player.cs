using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5__2_
{
    using Factories;
    using Factories.Foods;
    using Factories.Moods;
    public class Player
    {
        private int HappinessPoints { get; set; }

        public Mood GetMentalCondition()
        {
            return MoodFactory.GetMood(this.HappinessPoints);
        }
        internal void Eat(IEnumerable<Food> foods)
        {
            foreach(var food in foods)
            {
                this.HappinessPoints += food.PointsOfHappiness;
            }
        }
        public override string ToString()
        {
            var mood = this.GetMentalCondition();
            return string.Format("{0} {1}{2}",this.HappinessPoints,Environment.NewLine,mood.GetType().Name);
        }
    }
}
