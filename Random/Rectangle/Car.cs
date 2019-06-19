using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Car
    {
        private string id;
        private double width;
        private double height;
        private double leftEdgeX;
        private double leftEdgeY;

        public string ID
        {
            get { return this.ID; }
        }

        public Car(string id,double width,double height,double edgeX,double edgeY)
        {
            this.id = id;
            this.width = Math.Abs(width);
            this.height = Math.Abs(height);
            this.leftEdgeX = edgeX;
            this.leftEdgeY = edgeY;
        }
        public bool DoIntersect(Car rec2)
        {

        }


    }
}
