class Product
{
    private string _productName;
    private int _productId;
    private double _productPrice;
    private int _productQuantity;

    public Product(string productName, int productId, double productPrice, int productQuantity) //constructor
    {
        _productName = productName;
        _productId = productId;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }

    public string GetProduct() //product getter
    {
        return _productName;
    }

    public int GetID() //id getter
    {
        return _productId;
    }

    public double GetPrice() //name getter
    {
        return _productPrice;
    }

    public int GetQuantity() //quantity getter
    {
        return _productQuantity;
    }

    
    public double CalcProdCost() //method to return total product cost--price per unit x quantity
    {
        double totalProPrice = _productPrice * _productQuantity;
        return totalProPrice;
    }
}

