using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N28_HT2.model
{
    public class StorageFile :ICloneable
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Size { get; set; }

        public object Clone()
        {
            return new StorageFile()
            {
                Id = this.Id,
                Name = this.Name,
                Description = this.Description,
                Size = this.Size
                
            };

        }

        public override string ToString()
        {
            return $"Id:{Id},Name:{Name},Description:{Description},Size:{Size}\n";
        }
    }

}
