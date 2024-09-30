using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricBL
{
    public abstract class Geometricobject
    {
        string color;
        DateTime datecreated= DateTime.Now;
        bool filled;

        public string Color { get; set; }
        public DateTime Datecreated { get { return datecreated; } }
        public bool Filled { get { return filled; } set { filled = value; } }

        public Geometricobject(string colorvalue,bool filledvalue)
        {
            Color = colorvalue;
            Filled = filledvalue;
        }
        public abstract double Area();
        public abstract double  Perimeter();

        public abstract string ToString();

    }
}
