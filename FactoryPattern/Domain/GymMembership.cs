namespace FactoryPattern.Domain;

public class GymMembership : IMembership
{
    private readonly string _name;
    private readonly decimal _price;

    public GymMembership(decimal price, string description)
    {
        _name = "Gym membership";
        _price = price;
        Description = description;
    }
    
    public string Name => _name;
    public string Description { get; set; }
    public decimal GetPrice() => _price;
}