﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public abstract class Animal
    {
        private string name;
        private string favoriteFood;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string FavoriteFood
        {
            get { return this.favoriteFood; }
            set { this.favoriteFood = value; }
        }

        public abstract string ExplainMyself();
    }

