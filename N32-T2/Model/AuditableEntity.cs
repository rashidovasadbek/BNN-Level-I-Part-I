using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N32_T2.Model
{
    public class AuditableEntity
    {
        public DateTime CreatedDate {  get; set; }
        public DateTime ModifiedDate { get; set; }

        public AuditableEntity(DateTime createdDate, DateTime modifiedDate)
        {
            CreatedDate = createdDate;
            ModifiedDate = modifiedDate;
        }
    }
}
