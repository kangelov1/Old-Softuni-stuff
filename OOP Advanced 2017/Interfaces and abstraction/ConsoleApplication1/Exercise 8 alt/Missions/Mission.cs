﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8_alt.Missions
{
    using Interfaces;
    public class Mission : IMission
    {
        private readonly string[] possibleStates = new string[] { "inProgress", "Finished" };

        private string codeName;
        private string state;

        public Mission(string codeName, string state)
        {
            this.codeName = codeName;
            this.State = state;
        }

        public string CodeName { get; private set; }

        public string State
        {
            get
            {
                return this.state;
            }

            set
            {
                if (!this.possibleStates.Contains(value))
                {
                    throw new ArgumentException("Invalid mission state");
                }

                this.state = value;
            }
        }

        public void CompleteMission()
        {
            this.state = "Finished";
        }

        public override string ToString()
        {
            string output = string.Format("Code Name: {0} State: {1}",this.CodeName,this.State);
            return output;
        }
    }
}
