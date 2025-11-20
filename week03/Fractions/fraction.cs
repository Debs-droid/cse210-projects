using System.Reflection.Metadata.Ecma335;

public class Fraction //here we declare the class
{
    private int _top;  //here are the attributes
    private int _bottom;

    public Fraction() //constructor, empty
    {
        _top = 1; //how to make an empty attribute for integer?
        _bottom = 1;
    }
    public Fraction(int wholeNumber) //constructor with one whole number parameter)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom) //constructor with two parameters, both integer
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString() //not a member variable--temporary, public--this is the public part, for whole numbers
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue() //double is more accurate than int--this is for the decimals, that's why we use double
    {
        //why not stored as a member variable? that step is not needed.
        return (double)_top / (double)_bottom;
    }    
}




    /*private int GetFullFraction()
    {
        return _top / _bottom;
    }*/




/*public int GetTopNumber() //getter for top, returns top attribute
{
    return _top;
}
public void SetTopNumber(int topNumber) //setter for top, does not return anything--void--but it sets the attribute to the local variable, which is the int parameter
{
    _top = topNumber;
}
public int GetBottomNumber()
{
    return _bottom;
}
public void SetBottomNumber(int bottomNumber)
{
    _bottom = bottomNumber;
}*/

