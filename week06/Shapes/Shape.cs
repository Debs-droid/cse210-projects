using System.Drawing;

public abstract class Shape //base class 
{
    private string _color; //variable

    public Shape(string color) //constructor
    {
        _color = color;
    }

    public string GetColor() //getter
    {
        return _color;
    }

    public void SetColor(string color) //setter
    {
        _color = color;
    }

    public abstract double GetArea();
}