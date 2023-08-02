
using System.Reflection.Metadata.Ecma335;

var userA = new User
{

    _name = "Ali",
    _middlaName = "Vali",
    _lastName = "Valiyevich"
};

var userB = new User
{
    _name = "Ali",
    _middlaName = "Vali",
    _lastName = "Valiyevich"
};

Console.WriteLine($"userA.GetHashCode() == userB.GetHashCode()-{userA.GetHashCode() == userB.GetHashCode()}");
public class User
{
    public string _name;
    public string _middlaName;
    public string _lastName;
    public string FIO => $"{_name} {_middlaName} {_lastName}";

    public override bool Equals(object? obj)
    {
        if (obj is User user)
            return this.GetHashCode() == user.GetHashCode();
        return false;
    }
    public override int GetHashCode()
    {
        return  _name.GetHashCode()
                + _lastName.GetHashCode()
                + _middlaName.GetHashCode();
    }

}
