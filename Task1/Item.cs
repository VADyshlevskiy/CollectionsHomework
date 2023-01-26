using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Item
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public Item(string name, long id)
        {
            Id = id;
            Name = name;
        }
    }
}
