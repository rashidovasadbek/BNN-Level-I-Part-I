using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public decimal Payment { get; set; }
        public string EduType { get; set; }
        public bool IsPayment { get; set; }

        public int GetAge()
        {
            return DateTime.Now.Year - BirthDay.Year;
        }
        public string GetShotName()
        {
            string result = FullName.PadRight(45);
            return result;
        }
    }
}
