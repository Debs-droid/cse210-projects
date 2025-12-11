using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Square : Shape
{
    private double _side; //attribute

    public Square(string color, double side) : base (color) //constructor
    {
        _side = side;
    } 

    public override double GetArea() //this get area may be different than that for other shapes
    {
        return _side * _side;
    }


}