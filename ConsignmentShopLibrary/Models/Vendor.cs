using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary.Models
{
    public class Vendor
    {
        public Vendor()
        {
            Commission = 0.5;
        }

        public string Display
        {
            get
            {
                return string.Format("{0} {1} - ${2}", FirstName,LastName,PaymentDue);
            }
        }
        public double PaymentDue { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double Commission { get; set; }
    }
}
