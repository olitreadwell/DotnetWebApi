namespace DotnetWebApi.Models; // Defines the namespace for the class

// creates a new class called Pizza for a pizza model
public class Pizza
{
    // public properties for the pizza model
    // allows these attributes to be accessed from other classes
    // the get and set methods allow the attributes to be read and written
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsGlutenFree { get; set; }
}