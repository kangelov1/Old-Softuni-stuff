using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Seat:ICar
    {
        private string model;
        private string color;
        public string Model
        {
            get { return this.model; }
            private set { this.model = value; }
        }

        public string Color
        {
            get { return this.color; }
            private set { this.color = value; }
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak";
        }
        public Seat(string model,string color)
        {
            this.Model = model;
            this.Color = color;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Format("{0} {1} {2}", this.Color, this.GetType().Name, this.Model)).AppendLine(this.Start()).AppendLine(this.Stop());
            return sb.ToString();
        }
    }
}
