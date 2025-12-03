using System.Globalization;
using System.Numerics;

class Order
{
    private Customer _customer; //this is a variable; the variable is a class; this _customer is scoped to the class

    private List<Product> _product = new List<Product>(); //this is a variable 

    public Order(Customer customer, List<Product> product)     //constructor--don't need a return type?
    {
        _customer = customer; //customer is internal to this constructor
        _product = product;
    }


    public Customer GetCustomer() //name getter
    {
        return _customer;
    }

    public void SetCustomer(Customer customer) //customer setter
    {
        _customer = customer;
    }

    public List<Product> GetProdList() //list getter
    {
        return _product;
    }
    //no list<product> setter because _product variable on line 8 declares a blank list for the products to go into

    public string CalcTotalCost()
    {
        double total = 0;

        foreach (Product product in _product)
        {
            total += product.CalcProdCost();
        }

        if (_customer.LiveInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return ($"The order total cost is: {total}\n");
    }

    public string ShipLabel() //method to return shipping label--no parameter
    {
        string _shipLabel = $"{_customer.GetName()}\n{_customer.GetAddress().AddressFormat()}\n";   //See below--GetName belongs to an object; some methods are static so they belong to the class; others indicate an ojbect. Need reference the local instance of the object.
        return _shipLabel;
    }

    public string PackLabel() //method to return packing label
    {
        string _packList = "";

        foreach (Product product in _product)
        {
            _packList += $"Product Name: {product.GetProduct()}, Product ID: {product.GetID()}\n";
        }

        return _packList;
    }

    //method to return a string for the packing label (has name and product id of each product in the order)
    //method to return a string for the shipping label
    //inside the bracket, it runs left to right, from the closest, chaining out to the furthest point, connecting. 
}