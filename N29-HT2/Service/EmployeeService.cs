using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace N29_HT2.Service
{
    public class EmployeeService
    {
        public SmtpClient smtpClientInstance { get; set;}
        public Task<bool> HireAsync( string firstname,string lastname,string emailAddress)
        {
            return Task.FromResult(true);
        }
    }
}
