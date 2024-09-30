using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricBL
{
    public class Rectangle : Geometricobject
    {
        double height;
        double width;

        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle(double heightvalue, double widthvalue, string Colorvalue, bool filledvalue) : base(Colorvalue,filledvalue)
        {
            Height = heightvalue;
            Width = widthvalue;


        }
        public override double Area()
        {
            return Height*Width ;
        }
        public override double Perimeter()
        {
            return 2 * (Height+Width);
        }

        public override string ToString()
        {
            return $"color is: {Color} and Date Created is: {Datecreated}";
        }
    }
}
