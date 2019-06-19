using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Animal
    {
        private string name;
        private double height;
        private int weight;
        private string favFood;
        private double speed;
        private string sound;

        protected Flys flyingType;

        public void setName(string name) { this.name=name;}
        public string getName(){return this.name;}
        public void setHeight(double height) { this.height = height; }
        public double getHeight() { return this.height; }

        public void setWeight(int weight) {
            if (weight > 0) { this.weight = weight; }
            else { throw new ArgumentException("Weight should be positive"); }
        }
        public int getWeight() { return this.weight; }
        public void setFavFood(string favFood) { this.favFood = favFood; }
        public string getFavFood() { return this.favFood; }

        public void setSpeed(double speed) { this.speed = speed; }
        public double getSpeed() { return this.speed; }
        public void setSound(string sound) { this.sound = sound; }
        public string getSound() { return this.sound; }
        public string tryToFly()
        {
            return flyingType.fly();
        }
        public void setFlyingAbility(Flys newFlyType)
        {
            this.flyingType = newFlyType;
        }

    }

