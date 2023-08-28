using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using N27_HT1.Model;
namespace N27_HT1.Service
{
    public class UserService
    {
        List<User> users = new List<User>();
        string EmailAddressRegex = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        string PasswordRegex = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";

        public UserService()
        {
            users.Add(new User("ella@gmail.com", "1234",false));
            users.Add(new User("jhondoe@gmail.com", "jhon",false));
            users.Add(new User("jemes@gmailcom", "jemy123",false));
        }
        public void Add(string emaiAddress, string password)
        {
            Regex regexemail = new Regex(EmailAddressRegex);
            Regex regexpassword = new Regex(PasswordRegex);

            if(regexemail.IsMatch(emaiAddress)  
               || regexpassword.IsMatch(PasswordRegex)
               || users.Any(user => user.EmailAddress != emaiAddress))
            {       
                EnsureAdminExists();
                users.Add(new User(emaiAddress, password, false)) ;    
            }
            else
            {
                throw new Exception("Email or password invalid");
            }
        }

        public List<User> GetUsers()
        {
            return users;  
        }

        private void EnsureAdminExists()
        {
            
            bool hasAdmin = users.Any(user => !user.IsAdmin);
            if (hasAdmin)
            {
                users.Add(new User("admin@gmail.com","adminpassword",true));
            }
        }
    }
}
