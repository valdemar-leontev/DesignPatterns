using FactoryPattern.Factories;

namespace FactoryPattern;

public class Programm
{
    private static void Main()
    {
        Console.WriteLine(">>> Welcome to FitnessClub CRM <<<\n");
        
        Console.WriteLine("> Enter the membership type you would like to create:");
        
        Console.WriteLine("> G - Gym");
        Console.WriteLine("> P - Gym + Pool");
        Console.WriteLine("> T - Personal Training");

        var membershipType = Console.ReadLine();

        var factory = GetFactory(membershipType!);
        if (factory is null)
        {
            return;
        }
        var membership = factory.GetMembership();
        
        Console.WriteLine("\n > Membership you have just created \n");
        Console.WriteLine(
            $"Name: {membership.Name}\n"+
            $"Description: {membership.Description}\n"+
            $"Price: {membership.GetPrice()}\n"
        );

        Console.ReadLine();
    }

    private static MembershipFactory? GetFactory(string membershipType)
    {
        switch (membershipType.ToLower())
        {
            case "g":
            {
                return new GymMemberShipFactory(100, "Gym");
            }
            case "p":
            {
                return new GymPoolMembershipFactory(250, "Gym + Pool");
            }
            case "t":
            {
                return new PersonalTrainingMembershipFactory(500, "Training");
            }
            default:
            {
                return null;
            } 
        }
    }
}