using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson7
{
    class Product
    {
        public int price, id, count;
        public Product(int id, int count, int price)
            {
                this.id = id;
                this.count = count;
                this.price = price;
            }
        public class Fruits : Product
        {
            public string name;
        public Fruits(int id, int count, int price, string name) : base(id, count, price)
            {
                this.name = name;
            }
        }
        public class Vegetables : Product
        {
            public string name;
        public Vegetables(int id, int count, int price, string name) : base(id, count, price)
            {
                this.name = name;
            }       
        }
    }
}
