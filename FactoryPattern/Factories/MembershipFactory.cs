using FactoryPattern.Domain;

namespace FactoryPattern.Factories;

public abstract class MembershipFactory
{
    public abstract IMembership GetMembership();
}