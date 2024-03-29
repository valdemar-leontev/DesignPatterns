using FactoryPattern.Domain;

namespace FactoryPattern.Factories;

public class GymPoolMembershipFactory : MembershipFactory
{
    private readonly decimal _price;
    private readonly string _description;

    public GymPoolMembershipFactory(decimal price, string description)
    {
        _price = price;
        _description = description;
    }
    
    public override IMembership GetMembership()
    {
        var membership = new GymPoolMembership(_price, _description);

        return membership;
    }
}