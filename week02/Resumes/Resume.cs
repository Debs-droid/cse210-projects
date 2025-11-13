using System.ComponentModel.DataAnnotations;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    //this is the method to display details--no parameters, doesn't return anything
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}