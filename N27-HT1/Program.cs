using N27_HT1.Model;
using N27_HT1.Service;

UserService userService = new UserService();
userService.Add("bob@gmail.com", "bob234");
userService.Add("hulk@gmail.com", "hulk234");
var users = userService.GetUsers();
foreach (var user in users)
    Console.WriteLine($"{user.Id} {user.EmailAddress} {user.Password} {user.IsAdmin}");
