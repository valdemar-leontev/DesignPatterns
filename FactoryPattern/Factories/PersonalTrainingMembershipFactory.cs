using FactoryPattern.Domain;

namespace FactoryPattern.Factories;

public class PersonalTrainingMembershipFactory : MembershipFactory
{
    private readonly decimal _price;
    private readonly string _description;

    public PersonalTrainingMembershipFactory(decimal price, string description)
    {
        _price = price;
        _description = description;
    }
    
    public override IMembership GetMembership()
    {
        var membership = new PersonalTrainingMembership(_price, _description);

        return membership;
    }
}