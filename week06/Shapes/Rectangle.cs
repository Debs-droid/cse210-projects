public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width) : base(color)//constructor
    {
        _length = length;
        _width = width;
    }
    public override double GetArea() //this get area is different than that for other shapes
    {
        return _length * _width;
    }
}