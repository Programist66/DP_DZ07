using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_DP07
{
    public class Product
    {
        public string Name { get; }
        public Product Next { get; set; }

        public Product(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}