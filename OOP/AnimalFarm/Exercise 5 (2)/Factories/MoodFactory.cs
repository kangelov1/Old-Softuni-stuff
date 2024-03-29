﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5__2_.Factories
{
    using Moods;
    public class MoodFactory
    {
        private const int AngryTopBorder = -6;
        private const int SadTopBorder = 0;
        private const int HappyTopBorder = 15;

        public static Mood GetMood(int happinessPoints)
        {
            if(happinessPoints <= AngryTopBorder)
            {
                return new Angry(happinessPoints);
            }
            else if(happinessPoints <= SadTopBorder)
            {
                return new Sad(happinessPoints);
            }
            else if(happinessPoints <= HappyTopBorder)
            {
                return new Happy(happinessPoints);
            }
            else 
            {
                return new JavaScript(happinessPoints);
            }
        }
    }
}
