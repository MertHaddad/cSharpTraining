namespace ContosoPizza.Models;

public class Pizza
{
    private int myVar;
    public int MyProperty
    {
        get { return myVar; }
        set { myVar = value; }
    }
    
    public int Id {get;set;}
    public string? Name {get;set;}
    public bool IsGlutenFree {get;set;}
}