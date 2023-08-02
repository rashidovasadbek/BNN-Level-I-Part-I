

var userB = new User 
{ 
    FirstName = "Jon",
    LastName = "Bob",
    Age = 32
                                                                        
};

var userC = new User 
{
    FirstName = "Jon",
    LastName = "Bob",
    Age = 32
};

Console.WriteLine($"userB.Equals(userC) - {userB.Equals(userC)}");
Console.WriteLine($"userC.GetHashCode() - {userC.GetHashCode()}");
Console.WriteLine($"userB.GetHashCode() - {userB.GetHashCode()}");
Console.WriteLine($"userB.GetHashCode() == userC.GetHashCode() - {userB.GetHashCode() == userC.GetHashCode()}");

public class User 
{
    public string FirstName;
    public string LastName;
    public int Age;

/*    public override bool Equals(object? obj)
    {
        if (obj is User user)
            return this.GetHashCode() == user.GetHashCode();
        return false;
    }*/

    public override int GetHashCode()
    {
        return FirstName.GetHashCode()
               + LastName.GetHashCode()
               + Age.GetHashCode();
    }
}

