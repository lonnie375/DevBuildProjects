using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInSeperateFile
{
    internal class Rectangle
    {
        //Keep track of how many instances you have 
        public static int count = 0;
        public double length { get; set; }
        public double height { get; set; }
        public string name { get; set; }

        public Rectangle(double length, double height, string name)
        {
            Rectangle.count++; 
            this.length = length;
            this.height = height;
            this.name = name;
           
        }

        public override string ToString()
        {
            return $"{name}: Length {length} Height {height} Area: {length * height}  Perimter: {2 * length + 2 * height}";
        }

    }


}
