using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Online Ordering Project.\n");

        
        Customer customer1 = new Customer();
        
        Address address1 = new Address("15 Pheasant Lane", "Bloomfield", "CT", "USA");

        customer1.SetName("Isabelle Stowell");
        customer1.SetAddress(address1);

        

        List<Product> _product1 = new List<Product>();
        Order order1 = new Order(customer1, _product1);
        order1.SetCustomer(customer1);

        _product1.Add(new Product("Violin Finger Tapes", 123, 2.59, 3)); //instance.method.hands keys to prod list stored in order. holding list, use add method which belongs to list class--can reference the method or the handle
        order1.GetProdList().Add(new Product("Purple Electric Violin", 222, 99.98, 1));
        order1.GetProdList().Add(new Product("Cello Tunes book 2", 314, 4.98, 1));


        Customer customer2 = new Customer();
        List<Product> _product2 = new List<Product>();
        Order order2 = new Order(customer2, _product2);
        Address address2 = new Address("1000 Mountain Rd", "Bloomfield", "CT", "USA");

        customer2.SetName("Woody Stowell");
        customer2.SetAddress(address2);

        order2.SetCustomer(customer2);

        order2.GetProdList().Add(new Product("Paracord, neon green", 417, 3.50, 2));
        order2.GetProdList().Add(new Product("Paracord, neon orange", 418, 3.50, 2));
        order2.GetProdList().Add(new Product("Teriyaki Beef Jerky", 511, 12.00, 2));


        Console.WriteLine(order1.ShipLabel()); //customer and address
        Console.WriteLine(order1.PackLabel());
        Console.WriteLine(order1.CalcTotalCost());

        Console.WriteLine(order2.ShipLabel());
        Console.WriteLine(order2.PackLabel());
        Console.WriteLine(order2.CalcTotalCost());


    }

}




