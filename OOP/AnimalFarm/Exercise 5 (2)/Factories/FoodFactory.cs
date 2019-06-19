using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5__2_.Factories
{
    using Foods;
    public class FoodFactory
    {
        public static Food GetFood(string name)
        {
            switch(name.ToLower())
            {
                case "apple":
                    return new Apple();
                case "cram":
                    return new Cram();
                case "honeycake":
                    return new HoneyCake();
                case "lembas":
                    return new Lembas();
                case "melon":
                    return new Melon();
                case "mushroom":
                    return new Mushroom();
                default:
                    return new EverythingElse();
            }
        }
    }
}
