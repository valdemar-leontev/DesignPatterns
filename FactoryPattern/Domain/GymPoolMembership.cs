namespace FactoryPattern.Domain;

public class GymPoolMembership : IMembership
{
    private readonly string _name;
    private readonly decimal _price;

    public GymPoolMembership(decimal price, string description)
    {
        _name = "Gym + Pool membership";
        _price = price;
        Description = description;
    }
    
    public string Name => _name;
    public string Description { get; set; }
    public decimal GetPrice() => _price;
}