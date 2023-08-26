using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N32_T2.Model
{
    public class ChatMassage : AuditableEntity
    {
        public int Id { get; set; }
        public string Subject { get; set; } 
        public string Message { get; set; }
        public int ChatId { get; set; }

        public ChatMassage(int id, string subject, string message, int chatid, DateTime cretedate, DateTime modifiedDate)
            :base(cretedate,modifiedDate)
        {
            Id = id;
            Subject = subject;
            Message = message;
            ChatId = chatid;
            CreatedDate = cretedate;
            ModifiedDate = modifiedDate;
        }

        public override string ToString()
        {
            return $"Id:{Id} Subject:{Subject} Message:{Message} ChatId:{ChatId} CreatedDate:{CreatedDate} ModifiedDate{ModifiedDate}";
        }

        public override bool Equals(object? obj)
        {
            if(obj is ChatMassage chatmessage)
            {
                return this.GetHashCode() == chatmessage.GetHashCode();
            }
            return false;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + Id;
            hash = hash * 23 + Subject.GetHashCode();
            hash = hash * 23 + Message.GetHashCode();
            return hash;
        }
    }
}
