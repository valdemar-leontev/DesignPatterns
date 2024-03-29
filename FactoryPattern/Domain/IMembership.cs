namespace FactoryPattern.Domain;

public interface IMembership
{
    public string Name { get; }

    public string Description { get; set; }

    decimal GetPrice();
}