Console.Write("Search:");
var search = Console.ReadLine();

var _users = new List<User>()
{
    new User("Asadbek","Rashidov", "asdbekrashidov@gmail.com"),
    new User("Begzod","Haqqiyev", "bekzod@gmail.com"),
    new User("G'ayrat","Alimiv", "gayrat@gmail.com"),
    new User("bob","boby", "bob123@gmail.com"),
    new User("Jhon","Doe", "jhon345@gmail.com"),
    new User("Ali","Valiyev", "ali@gmail.com"),
    new User("jorabek","Shavqiyev", "jora563@gmail.com"),
    new User("abdulloh","Chapiyev", "abdulloh@gmail.com"),
    new User("Miraziz","Vohoyev", "miraziz@gmail.com"),
};
var user = _users.Where(_users => _users.FirstName.Contains(search,StringComparison.OrdinalIgnoreCase));
foreach (var _user in user)
    Console.WriteLine($"{_user.FirstName} {_user.LastName} {_user.Email}");