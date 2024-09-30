using System;
namespace GeometricBL
{
    public class Circle : Geometricobject
    {
        double radius;
        public double Radius {  get { return radius; } set { radius = value; } }
        

        public Circle(double radiusvalue, string Colorvalue, bool filledvalue): base(Colorvalue,filledvalue)
        {
            Radius = radiusvalue;
            Color = Colorvalue;
            Filled=filledvalue;

        }
        public override double Area()
        {
            return 3.14*radius*radius;
        }
        public override double Perimeter()
        {
            return 2*3.14*radius;
        }
        public double diameter()
        {
            return 2 * radius;
        }
       
        public override string ToString()
        {
            return ($"color is: {Color} and Date Created is: {Datecreated}") ;
        }
        public void printcircle()
        {
            Console.WriteLine($"Area of a circle is: {Area()}, Perimeter of ciecle is: {Perimeter()},Diameter is: {diameter()}");
        }
    }
}
