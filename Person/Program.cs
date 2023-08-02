
public class User 
{ 
    public string ShortName { get; set; }
    public string FullName { get; set; }
    private readonly DateTime _dateTime;
    public DateTime DateOfBith { get => _dateTime; }
    public string Details { get; set;}
    public string Address { get; set; }
    public double Money { get; set; }

    public User
        (
        int id,
        string shortname, 
        string fullname,
        DateTime dateOfBirth, 
        string details, 
        string address, 
        double money
        )
        {
            _dateTime = dateOfBirth;
        }
}

