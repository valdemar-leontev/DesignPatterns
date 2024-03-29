namespace FactoryPattern.Domain;

public class PersonalTrainingMembership : IMembership
{
    private readonly string _name;
    private readonly decimal _price;

    public PersonalTrainingMembership(decimal price, string description)
    {
        _name = "Personal training membership";
        _price = price;
        Description = description;
    }
    
    public string Name => _name;
    public string Description { get; set; }
    public decimal GetPrice() => _price;
}