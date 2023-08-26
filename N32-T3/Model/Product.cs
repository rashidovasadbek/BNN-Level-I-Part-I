using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N32_T3.Model
{
    public class Product
    {
        private string _name;
        private string _description;
        public Guid Id { get; init; }
        public string Name
        {
            get
            {
                return  _name;
            }
            private set
            {
                if (Name == null || string.IsNullOrEmpty(Name))
                    _name = value;
                else
                {
                    throw new InvalidOperationException("invalid Name");
                }
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            private set
            {
                if (Description == null || string.IsNullOrEmpty(Description))
                    _description = value;
                else
                {
                    throw new InvalidOperationException("invalid Description");
                }
            }

        }

        public Product(string name, string description)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
        }
        public Product(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            Description = product.Description;
        }
    }
}
