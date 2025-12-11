public class Circle : Shape
{
    private double _radius; //attribute;

    public Circle(string color, double radius) : base(color) //constructor
    {
        _radius = radius;
    }

    public override double GetArea() //this get area is different than that for square
    {
        return 3.14 * _radius * _radius;
    }
}