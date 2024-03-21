using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary.Models
{
    public class Store
    {
        public Store()
        {
            Vendors = new List<Vendor>();
            Items = new List<Item>();
        }
        public string Name { get; set; }

        public List<Vendor> Vendors { get; set; }

        public List<Item> Items { get; set; }


    }
}
