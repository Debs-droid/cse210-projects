class Customer
{
    private string _customerName; //attribute
    private Address _address; //this attribute is a method
    /*public Customer(string customerName) //constructor
    {
        _customerName = customerName;
    }*/

    public string GetName() //name getter
    {
        return _customerName;
    }

    public void SetName(string customerName) //name setter--choose if i want the constructor or the setter
    {
        _customerName = customerName;
    }


    public Address GetAddress() //return type is Address
    {
        return _address;
    }
    
    public void SetAddress(Address customerAddress) //setter for address
    {
        _address = customerAddress;
    }

    public bool LiveInUSA() //method referencing address in USA or no (need this again because of encapsulation)
    {
        return _address.InUSA();
    }

}












