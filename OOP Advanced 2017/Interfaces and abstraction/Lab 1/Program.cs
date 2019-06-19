using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IDrawable circle = new Circle(2);
            circle.Draw();
            IDrawable rectangle = new Rectangle(3, 4);
            rectangle.Draw();
        }
    }
}
