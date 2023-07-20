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
        public decimal PaymentAmount { get; set; }


        public int GetAge()
        {
            return DateTime.Now.Year - BirthDay.Year;
        }
        public string GetShotName()
        {
            string result = FullName.PadRight(45);
            return result;
        }
    
        public string GetAmount()
        {
            decimal amout = Payment - PaymentAmount;
            if (amout < 0) return $"{Math.Abs(amout)} haqdor".PadRight(5);
            else return $"{amout} qarzdor".PadRight(5);
        }

        public void GetTableAmount(Student student, string EduType)
        {
        
                if (student.EduType.Equals("DotNET"))
                {
                    decimal kantrakt = student.Payment;
                    Console.WriteLine(value: $"{student.GetShotName()}\t\t{kantrakt}\t\t{student.PaymentAmount}\t\t{student.GetAmount()}");
                }
            
        }
    }
}
