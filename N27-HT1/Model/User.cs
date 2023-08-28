using N27_HT1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N27_HT1.Model
{
    public class User
    {
        public Guid Id { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

       
        
        public User(string emailAddres,string password,bool isAdmin)
        {
            Id = Guid.NewGuid();
            EmailAddress = emailAddres;
            Password = password;
            IsAdmin = isAdmin;
                
        }
    }
}
