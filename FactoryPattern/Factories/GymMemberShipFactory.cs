using FactoryPattern.Domain;

namespace FactoryPattern.Factories;

public class GymMemberShipFactory : MembershipFactory
{
    private readonly decimal _price;
    private readonly string _description;

    public GymMemberShipFactory(decimal price, string description)
    {
        _price = price;
        _description = description;
    }
    
    public override IMembership GetMembership()
    {
        var membership = new GymMembership(_price, _description);

        return membership;
    }
}