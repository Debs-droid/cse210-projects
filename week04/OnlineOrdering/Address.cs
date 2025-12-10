using System.Security.Cryptography;

class Address
{
    private string _street; //member variables--fields (member variables can be static or instance)
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country) //constructor--requires info
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetStreet() //getter
    {
        return _street;
    }

    public void SetStreet(string street) //setter
    {
        _street = street;
    }

    public string GetCity() //getter
    {
        return _city;
    }

    public void SetCity(string city)//setter
    {
        _city = city;
    }
    public string GetState() //getter
    {
        return _state;
    }

    public void SetState(string state) //setter
    {
        _state = state;
    }
    public string GetCountry() //getter
    {
        return _country;
    }

    public void SetCountry(string country) //setter
    {
        _country = country;
    }

    public string AddressFormat() //method to format address 
    {
        return $"{_street}\n{_city}, {_state} {_country}";
    }

    public bool InUSA() //method to say if address is in USA
    {

        if (_country == "USA") //one = sign is an assignment; two == is a test; this is a test; this is only a test. (harhar) member variables are temporary--they don't exist outside the method
        {
            return true;
        }
        else
        {
            return false;
        }
    }



}

